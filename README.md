[![](https://img.shields.io/nuget/v/Soenneker.Enums.JsonLibrary.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonLibrary/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonlibrary/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonlibrary/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.JsonLibrary.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonLibrary/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonlibrary/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonlibrary/actions/workflows/codeql.yml)

# Soenneker.Enums.JsonLibrary

An integer-backed enum-value type for selecting between `System.Text.Json` and Newtonsoft.Json in APIs that support both serializers.

## Install

```bash
dotnet add package Soenneker.Enums.JsonLibrary
```

## Usage

```csharp
using Soenneker.Enums.JsonLibrary;

JsonLibraryType library = JsonLibraryType.SystemTextJson;
int value = library.Value; // 0

if (JsonLibraryType.TryFromValue(configuredValue, out JsonLibraryType? parsed))
{
    library = parsed;
}
```

| Value | Numeric value | Serializer |
| --- | ---: | --- |
| `SystemTextJson` | `0` | `System.Text.Json` |
| `Newtonsoft` | `1` | Newtonsoft.Json / Json.NET |

The generated `System.Text.Json` converter writes the numeric value and accepts only defined values when reading. `FromValue` throws for an unknown integer; use `TryFromValue` when reading configuration or requests. `FromName` and `TryFromName` use the C# member names.

This package identifies a serializer; it does not serialize content or provide serializer settings. The consuming API must perform the dispatch and define the options used by each library. The two serializers can differ in naming, converters, reference handling, null handling, and accepted input, so selecting one does not guarantee identical payload behavior.
