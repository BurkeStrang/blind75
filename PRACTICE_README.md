# 🎯 Blind75 Practice Script

A practice script that allows you to practice coding problems by removing method implementations and testing your solutions incrementally.

## 📖 Overview

The `practice` script helps you practice Blind75 coding problems by:
- Removing method implementations from source files
- Replacing them with `NotImplementedException` throws
- Allowing you to implement solutions and test them
- Providing easy restore functionality

## 🚀 Quick Start

```bash
# See available problem categories
./practice

# Start practicing graph problems
./practice Graphs

# Test your implementations
./practice Graphs test

# Restore original solutions
./practice Graphs restore
```

## 📋 Commands

| Command | Description |
|---------|-------------|
| `./practice <folder>` | Start practice mode for a folder |
| `./practice <folder> test` | Run tests for your implementations |
| `./practice <folder> restore` | Restore original implementations |
| `./practice restore` | Restore all backed up files |

## 📁 Available Categories

- **1dDynamicProgramming** - 1D Dynamic Programming problems
- **2dDynamicProgramming** - 2D Dynamic Programming problems
- **AdvancedGraphs** - Advanced graph algorithms
- **ArraysAndHashing** - Array and hash table problems
- **Backtracking** - Backtracking algorithms
- **BinarySearch** - Binary search problems
- **BitManipulation** - Bit manipulation problems
- **General** - General programming problems
- **Graphs** - Graph algorithms
- **Greedy** - Greedy algorithms
- **Heap** - Heap and priority queue problems
- **Intervals** - Interval problems
- **LinkedList** - Linked list problems
- **MathAndGeo** - Math and geometry problems
- **SlidingWindow** - Sliding window problems
- **Stack** - Stack problems
- **Trees** - Tree algorithms
- **Tries** - Trie data structure problems
- **TwoPointers** - Two pointers technique

## 🔧 How It Works

### 1. Practice Mode
When you run `./practice <folder>`, the script:
- Creates a backup of all original implementations
- Replaces method bodies with `throw new NotImplementedException();`
- Adds `using System;` directive if needed
- Preserves all comments and method signatures

### 2. Test Mode
When you run `./practice <folder> test`, the script:
- Builds the project to check for compilation errors
- Runs all tests for the specified folder
- Shows clear error messages for failed implementations

### 3. Restore Mode
When you run `./practice <folder> restore`, the script:
- Restores original implementations from backup
- Preserves your practice session state

## 💡 Example Workflow

```bash
# 1. Start practicing graphs
./practice Graphs

# 2. Open your editor and implement methods in Blind75/Graphs/*.cs
# For example, implement CloneGraph.CloneGraph() method

# 3. Test your implementation
./practice Graphs test

# 4. If tests pass, move to next problem
# If tests fail, fix your implementation and test again

# 5. When done, restore original solutions to compare
./practice Graphs restore
```

## 🧪 Testing Individual Problems

You can test specific problems using dotnet test filters:

```bash
# Test a specific test class
dotnet test --filter "CloneGraphTests"

# Test a specific test method
dotnet test --filter "CloneGraphTests.ReturnsValidClonedGraph"

# Test all problems in a category
dotnet test --filter "*Graphs*"
```

## 📂 File Structure

```
blind75/
├── practice                    # Main practice script
├── remove_method_bodies.py     # Python helper for method removal
├── .practice_backup/           # Backup directory (auto-created)
│   ├── Graphs/                # Backed up graph implementations
│   └── ...                    # Other category backups
└── Blind75/                   # Source code
    ├── Graphs/                # Graph problem implementations
    └── ...                    # Other categories
```

## ⚠️ Important Notes

1. **Backup Safety**: Original implementations are always backed up before modification
2. **Compilation**: The project will compile even with `NotImplementedException` throws
3. **Tests**: Tests will fail with clear error messages until you implement the methods
4. **Restore**: You can always restore original implementations

## 🎨 Features

- **🌈 Colored Output**: Clear visual feedback with colored messages
- **🔄 Safe Backups**: Automatic backup before any modifications
- **🏗️ Build Integration**: Seamless integration with dotnet build/test
- **📊 Progress Tracking**: See how many problems are in each category
- **🔍 Smart Processing**: Handles complex C# method signatures correctly

## 🤝 Contributing

If you find issues with the practice script:
1. Check that you're using the correct folder names (case-sensitive)
2. Ensure you have Python 3 installed for method body removal
3. Make sure dotnet SDK is properly installed

## 🔧 Troubleshooting

### Script won't run
```bash
chmod +x practice
```

### Python script errors
Make sure Python 3 is installed:
```bash
python3 --version
```

### Compilation errors
If you see compilation errors after practice mode, check that all method signatures are preserved correctly.

### Tests not found
Use the exact folder names as shown in the available folders list:
```bash
./practice  # Shows all available folders
```

Happy coding! 🚀