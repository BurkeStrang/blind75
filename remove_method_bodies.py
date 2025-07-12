#!/usr/bin/env python3
"""
Script to remove C# method implementations for practice mode.
Replaces method bodies with NotImplementedException throws.
"""

import sys
import re
import os

def analyze_return_type(signature):
    """Analyze method signature to determine return type."""
    # Remove access modifiers and keywords
    clean_sig = re.sub(r'\b(public|private|protected|internal|static|virtual|override|async)\b\s*', '', signature)
    
    # Extract return type (first word before method name)
    parts = clean_sig.strip().split()
    if len(parts) >= 2:
        return_type = parts[0]
        # Handle generic types
        if '<' in return_type and not return_type.endswith('>'):
            # Find the complete generic type
            bracket_count = 0
            type_parts = []
            for part in parts:
                type_parts.append(part)
                bracket_count += part.count('<') - part.count('>')
                if bracket_count == 0:
                    break
            return_type = ' '.join(type_parts)
        return return_type
    return 'void'

def generate_throw_statement():
    """Generate a NotImplementedException throw statement."""
    return "        throw new NotImplementedException();"

def remove_method_implementations(content):
    """Remove implementations from all public methods."""
    
    # Add using System if not present
    if 'using System;' not in content:
        # Find the first namespace or using statement
        lines = content.split('\n')
        insert_index = 0
        for i, line in enumerate(lines):
            if line.strip().startswith('namespace ') or line.strip().startswith('using '):
                insert_index = i
                break
        
        # Insert using System at the top
        if insert_index == 0 or lines[insert_index].strip().startswith('namespace '):
            lines.insert(insert_index, 'using System;')
            lines.insert(insert_index + 1, '')
        else:
            # Find a good spot among other using statements
            while insert_index < len(lines) and lines[insert_index].strip().startswith('using '):
                insert_index += 1
            lines.insert(insert_index, 'using System;')
        
        content = '\n'.join(lines)
    
    # Pattern to match method signatures and their bodies
    # This is a complex pattern that handles nested braces
    method_pattern = r'''
        (                                           # Group 1: Method signature
            (?:^|\n)                               # Start of line
            \s*                                    # Optional whitespace
            (?:public|private|protected|internal)  # Access modifier
            \s+                                    # Whitespace
            (?:static\s+)?                         # Optional static
            (?:virtual\s+)?                        # Optional virtual
            (?:override\s+)?                       # Optional override
            (?:async\s+)?                          # Optional async
            [^{;]+?                                # Return type and method name
            \([^)]*\)                              # Parameters
            (?:\s*where\s+[^{]+)?                  # Optional where clause
        )
        \s*                                        # Optional whitespace
        \{                                         # Opening brace
        (                                          # Group 2: Method body
            (?:[^{}]*\{[^{}]*\})*                  # Nested braces (simple)
            [^{}]*                                 # Remaining content
        )
        \}                                         # Closing brace
    '''
    
    def replace_method_body(match):
        signature = match.group(1).strip()
        
        # Skip if it's already a throw NotImplementedException
        body = match.group(2)
        if 'throw new NotImplementedException()' in body:
            return match.group(0)  # Return unchanged
            
        return_stmt = generate_throw_statement()
        return f"{signature}\n    {{\n{return_stmt}\n    }}"
    
    # Use a more robust approach: find methods using a state machine
    lines = content.split('\n')
    result_lines = []
    in_method = False
    method_signature = []
    brace_count = 0
    i = 0
    
    while i < len(lines):
        line = lines[i]
        
        if not in_method:
            # Look for method signatures
            if re.search(r'^\s*(?:public|private|protected|internal)\s+(?:static\s+)?(?:virtual\s+)?(?:override\s+)?(?:async\s+)?[^{;]+\([^)]*\)\s*$', line):
                # This looks like a method signature, check if next non-empty line has opening brace
                method_signature = [line]
                j = i + 1
                while j < len(lines) and lines[j].strip() == '':
                    method_signature.append(lines[j])
                    j += 1
                if j < len(lines) and lines[j].strip() == '{':
                    # Found a method!
                    method_signature.append(lines[j])
                    
                    # Check if body already has NotImplementedException
                    method_body_preview = ""
                    for k in range(j + 1, min(j + 5, len(lines))):
                        method_body_preview += lines[k]
                    
                    if 'throw new NotImplementedException()' in method_body_preview:
                        # Already has NotImplementedException, keep as is
                        result_lines.extend(method_signature)
                        i = j
                        in_method = True
                        brace_count = 1
                    else:
                        # Replace with NotImplementedException
                        signature_str = '\n'.join(method_signature[:-1])  # All but the opening brace
                        result_lines.append(signature_str)
                        result_lines.append('    {')
                        result_lines.append('        throw new NotImplementedException();')
                        result_lines.append('    }')
                        
                        # Skip the original method body
                        i = j + 1  # Start after opening brace
                        brace_count = 1
                        while i < len(lines) and brace_count > 0:
                            if '{' in lines[i]:
                                brace_count += lines[i].count('{')
                            if '}' in lines[i]:
                                brace_count -= lines[i].count('}')
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
            if '{' in line:
                brace_count += line.count('{')
            if '}' in line:
                brace_count -= line.count('}')
            
            result_lines.append(line)
            
            if brace_count == 0:
                in_method = False
        
        i += 1
    
    return '\n'.join(result_lines)

def main():
    if len(sys.argv) != 3:
        print("Usage: python3 remove_method_bodies.py <input_file> <output_file>")
        sys.exit(1)
    
    input_file = sys.argv[1]
    output_file = sys.argv[2]
    
    try:
        with open(input_file, 'r', encoding='utf-8') as f:
            content = f.read()
        
        modified_content = remove_method_implementations(content)
        
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(modified_content)
        
        print(f"Successfully processed {input_file} -> {output_file}")
    
    except Exception as e:
        print(f"Error processing {input_file}: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main()