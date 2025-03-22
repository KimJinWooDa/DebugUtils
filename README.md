# DebugHelper

DebugHelper is a lightweight Unity utility that provides conditional logging methods to output colored messages—and even highlight specific parts of a message—in the Unity Editor. These logging methods use the `[Conditional("UNITY_EDITOR")]` attribute, which ensures that all logging calls are automatically removed from builds, keeping your runtime code clean and efficient.

## Features

- **Colored Log Messages:**  
  Easily log messages with a specified color.
  
- **Highlighted Message Parts:**  
  Highlight a specific part of a message with a different color.
  
- **Optional Number Prefixing:**  
  Automatically prepend a number (or any numeric prefix) to your log messages for better organization.
  
- **Editor-Only Logging:**  
  All log calls are conditionally compiled to run only in the Unity Editor—no log overhead in builds.

## Installation

1. **Clone or Download:**  
   Clone this repository or download the `DebugUtils.cs` file.

2. **Import into Your Project:**  
   Place the file in your Unity project, e.g., under `Assets/Scripts/DebugHelper`.

3. **Start Using:**  
   Include the namespace in your scripts:
   ```csharp
   using DebugHelper;
