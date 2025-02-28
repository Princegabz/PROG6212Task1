## ModuleDetails Class - README

### Overview
The `ModuleDetails` class is a simple data model for storing and managing details about academic modules. It contains properties related to module identification, credits, class hours, duration, and start date. This class is part of the `PROG6212Task1` namespace.

### Properties
- **ModuleCode** (`string`): The unique code identifying the module.
- **ModuleName** (`string`): The name of the academic module.
- **ICredits** (`int`): The number of credits associated with the module.
- **IClassHours** (`int`): The number of class hours per week.
- **IWeeks** (`int`): The duration of the module in weeks.
- **StartDate** (`string`): The start date of the module.

### Constructors
- **`ModuleDetails()`**: Initializes an empty module with default values.
- **`ModuleDetails(string moduleCode, string moduleName, int iCredits, int iClassHours, int iWeeks, string startDate)`**: Initializes a module with provided data.

### Methods
- **`ToString()`**: Returns a formatted string displaying the module's details.

### Indexers
The class supports two types of indexers:

1. **By Index (`this[int index]`)**:
   - `0`: `ModuleCode`
   - `1`: `ModuleName`
   - `2`: `ICredits`
   - `3`: `IClassHours`
   - `4`: `IWeeks`
   - `5`: `StartDate`

2. **By Attribute Name (`this[string attrName]`)**:
   - "modulecode": `ModuleCode`
   - "modulename": `ModuleName`
   - "icredits": `ICredits`
   - "iclasshours": `IClassHours`
   - "iweeks": `IWeeks`
   - "startdate": `StartDate`

Both indexers allow getting and setting the respective properties.

### Usage Example
```csharp
ModuleDetails module = new ModuleDetails("PROG6212", "Programming 2A", 15, 150, 10, "25/07/2022");
Console.WriteLine(module.ToString());

// Using index-based accessor
Console.WriteLine(module[0]); // Output: PROG6212

// Using name-based accessor
Console.WriteLine(module["modulename"]); // Output: Programming 2A

// Updating properties using indexer
module["startdate"] = "01/08/2022";
Console.WriteLine(module.StartDate1); // Output: 01/08/2022
```

### Notes
- The class uses private fields with public properties to manage access.
- Data types are enforced when using indexers.
- `ToLower()` is used for string-based indexers to ensure case-insensitive access.

