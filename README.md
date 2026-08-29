[![](https://img.shields.io/nuget/v/Soenneker.Enums.JsonLibrary.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonLibrary/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonlibrary/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonlibrary/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.JsonLibrary.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.JsonLibrary/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.jsonlibrary/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.jsonlibrary/actions/workflows/codeql.yml)

# Soenneker.Enums.JsonLibrary

Identifies the .NET JSON serialization library used to process a payload.

## Install

```bash
dotnet add package Soenneker.Enums.JsonLibrary
```

## What you get

- `JsonLibraryType` — Identifies the .NET JSON serialization library used to process a payload.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `JsonLibraryType.SystemTextJson` | The built-in `System.Text.Json` serializer. | The built-in `System.Text.Json` serializer. |
| `JsonLibraryType.Newtonsoft` | The Newtonsoft.Json serializer, also known as Json.NET. | The Newtonsoft.Json serializer, also known as Json.NET. |
