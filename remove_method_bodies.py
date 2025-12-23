#!/usr/bin/env python3
"""
Script to remove C# method implementations for practice mode.
Replaces method bodies with NotImplementedException throws.
"""

import sys
import re


def analyze_return_type(signature):
    """Analyze method signature to determine return type."""
    # Remove access modifiers and keywords
    clean_sig = re.sub(
        r"\b(public|private|protected|internal|static|virtual|override|async)\b\s*",
        "",
        signature,
    )

    # Extract return type (first word before method name)
    parts = clean_sig.strip().split()
    if len(parts) >= 2:
        return_type = parts[0]
        # Handle generic types
        if "<" in return_type and not return_type.endswith(">"):
            # Find the complete generic type
            bracket_count = 0
            type_parts = []
            for part in parts:
                type_parts.append(part)
                bracket_count += part.count("<") - part.count(">")
                if bracket_count == 0:
                    break
            return_type = " ".join(type_parts)
        return return_type
    return "void"


def generate_throw_statement():
    """Generate a NotImplementedException throw statement."""
    return "        throw new NotImplementedException();"


def remove_method_implementations(content):
    """Remove implementations from all public methods."""

    def replace_method_body(match):
        signature = match.group(1).strip()

        # Skip if it's already a throw NotImplementedException
        body = match.group(2)
        if "throw new NotImplementedException()" in body:
            return match.group(0)  # Return unchanged

        return_stmt = generate_throw_statement()
        return f"{signature}\n    {{\n{return_stmt}\n    }}"

    # Use a more robust approach: find methods using a state machine
    lines = content.split("\n")
    result_lines = []
    in_method = False
    method_signature = []
    brace_count = 0
    i = 0

    def is_class_declaration(line):
        """Check if a line is a class declaration (including primary constructors)"""
        stripped = line.strip()
        # Match class declarations with or without primary constructors
        return bool(
            re.match(
                r"^\s*(?:public|private|protected|internal)?\s*(?:abstract|sealed|static)?\s*(?:partial\s+)?class\s+\w+",
                stripped,
            )
        )

    def is_method_signature(line):
        """Check if a line looks like a method signature"""
        stripped = line.strip()
        # Skip class declarations
        if is_class_declaration(line):
            return False

        # Look for method signatures (but not class constructors in class declaration)
        # Improved pattern to handle arrays, generics, and complex return types
        method_pattern = r"^\s*(?:public|private|protected|internal)\s+(?:static\s+)?(?:virtual\s+)?(?:override\s+)?(?:async\s+)?(?!class\s+)[A-Za-z_][A-Za-z0-9_<>\[\],\s\?]*\s+[A-Za-z_][A-Za-z0-9_]*\s*\([^)]*\)\s*$"
        return bool(re.match(method_pattern, stripped))

    def is_expression_bodied_method(line):
        """Check if a line contains an expression-bodied method (using =>)"""
        stripped = line.strip()
        # Skip class declarations
        if is_class_declaration(line):
            return False

        # Look for method signatures with => (expression-bodied methods)
        method_pattern = r"^\s*(?:public|private|protected|internal)\s+(?:static\s+)?(?:virtual\s+)?(?:override\s+)?(?:async\s+)?(?!class\s+)[A-Za-z_][A-Za-z0-9_<>\[\],\s\?]*\s+[A-Za-z_][A-Za-z0-9_]*\s*\([^)]*\)\s*=>"
        return bool(re.match(method_pattern, stripped))

    while i < len(lines):
        line = lines[i]

        if not in_method:
            # Check for expression-bodied methods first
            if is_expression_bodied_method(line):
                # Extract the method signature part (before =>)
                arrow_pos = line.find("=>")
                signature_part = line[:arrow_pos].strip()

                # Check if it already throws NotImplementedException
                if "throw new NotImplementedException()" in line:
                    result_lines.append(line)
                else:
                    # Replace with traditional method body
                    result_lines.append(signature_part)
                    result_lines.append("    {")
                    result_lines.append(
                        "        throw new NotImplementedException();"
                    )
                    result_lines.append("    }")

                    # Skip any remaining parts of the expression (could span multiple lines)
                    # Find the end of the expression (semicolon)
                    if ";" not in line:
                        i += 1
                        while i < len(lines) and ";" not in lines[i]:
                            i += 1
            # Check if this is a method signature that might have => on next line
            elif is_method_signature(line):
                # Look ahead to see if next lines contain =>
                j = i + 1
                found_arrow = False
                temp_lines = [line]

                while (
                    j < len(lines) and j <= i + 3
                ):  # Look ahead up to 3 lines
                    temp_lines.append(lines[j])
                    if "=>" in lines[j]:
                        found_arrow = True
                        break
                    if lines[j].strip() == "{":
                        # Traditional method body
                        break
                    j += 1

                if found_arrow:
                    # This is an expression-bodied method split across lines
                    # Check if it already throws NotImplementedException
                    full_expression = "\n".join(temp_lines)
                    if (
                        "throw new NotImplementedException()"
                        in full_expression
                    ):
                        result_lines.extend(temp_lines)
                        i = j
                        # Skip any remaining parts of the expression
                        if ";" not in lines[j]:
                            i += 1
                            while i < len(lines) and ";" not in lines[i]:
                                i += 1
                    else:
                        # Replace with traditional method body
                        result_lines.append(line)
                        result_lines.append("    {")
                        result_lines.append(
                            "        throw new NotImplementedException();"
                        )
                        result_lines.append("    }")

                        # Skip the original expression
                        i = j
                        if ";" not in lines[j]:
                            i += 1
                            while i < len(lines) and ";" not in lines[i]:
                                i += 1
                else:
                    # Traditional method signature, handle normally
                    # This looks like a method signature, check if next non-empty line has opening brace
                    method_signature = [line]
                    j = i + 1
                    while j < len(lines) and lines[j].strip() == "":
                        method_signature.append(lines[j])
                        j += 1
                    if j < len(lines) and lines[j].strip() == "{":
                        # Found a method!
                        method_signature.append(lines[j])

                        # Check if body already has NotImplementedException
                        method_body_preview = ""
                        for k in range(j + 1, min(j + 5, len(lines))):
                            if k < len(lines):
                                method_body_preview += lines[k]

                        if (
                            "throw new NotImplementedException()"
                            in method_body_preview
                        ):
                            # Already has NotImplementedException, keep as is
                            result_lines.extend(method_signature)
                            i = j
                            in_method = True
                            brace_count = 1
                        else:
                            # Replace with NotImplementedException
                            # All but the opening brace
                            signature_str = "\n".join(method_signature[:-1])
                            result_lines.append(signature_str)
                            result_lines.append("    {")
                            result_lines.append(
                                "        throw new NotImplementedException();"
                            )
                            result_lines.append("    }")

                            # Skip the original method body
                            i = j + 1  # Start after opening brace
                            brace_count = 1
                            while i < len(lines) and brace_count > 0:
                                if "{" in lines[i]:
                                    brace_count += lines[i].count("{")
                                if "}" in lines[i]:
                                    brace_count -= lines[i].count("}")
                                i += 1
                            i -= 1  # Adjust for the outer loop increment
                    else:
                        # Not a method, add normally
                        result_lines.extend(method_signature)
                        i = j - 1
            else:
                result_lines.append(line)
        else:
            # We're inside a method, count braces to find the end
            if "{" in line:
                brace_count += line.count("{")
            if "}" in line:
                brace_count -= line.count("}")

            result_lines.append(line)

            if brace_count == 0:
                in_method = False

        i += 1

    return "\n".join(result_lines)


def main():
    if len(sys.argv) != 3:
        print(
            "Usage: python3 remove_method_bodies.py <input_file> <output_file>"
        )
        sys.exit(1)

    input_file = sys.argv[1]
    output_file = sys.argv[2]

    try:
        with open(input_file, "r", encoding="utf-8") as f:
            content = f.read()

        modified_content = remove_method_implementations(content)

        with open(output_file, "w", encoding="utf-8") as f:
            f.write(modified_content)

        print(f"Successfully processed {input_file} -> {output_file}")

    except Exception as e:
        print(f"Error processing {input_file}: {e}")
        sys.exit(1)


if __name__ == "__main__":
    main()
