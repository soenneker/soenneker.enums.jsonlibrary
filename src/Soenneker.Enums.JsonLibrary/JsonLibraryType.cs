using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.JsonLibrary;

/// <summary>
/// Identifies the .NET JSON serialization library used to process a payload.
/// </summary>
[EnumValue]
public sealed partial class JsonLibraryType
{
    /// <summary>
    /// The built-in <c>System.Text.Json</c> serializer.
    /// </summary>
    public static readonly JsonLibraryType SystemTextJson = new(0);

    /// <summary>
    /// The Newtonsoft.Json serializer, also known as Json.NET.
    /// </summary>
    public static readonly JsonLibraryType Newtonsoft = new(1);
}
