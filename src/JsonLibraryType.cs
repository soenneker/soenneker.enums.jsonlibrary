using Ardalis.SmartEnum;
using Newtonsoft.Json;

namespace Soenneker.Enums.JsonLibrary;

/// <summary>
/// An enumeration for common JSON library types
/// </summary>
public sealed class JsonLibraryType : SmartEnum<JsonLibraryType>
{
    public static readonly JsonLibraryType SystemTextJson = new(nameof(SystemTextJson), 0);

    /// <summary>
    /// JSON.net
    /// </summary>
    public static readonly JsonLibraryType Newtonsoft = new(nameof(Newtonsoft), 1);

    [JsonConstructor]
    private JsonLibraryType(string name, int value) : base(name, value)
    {
    }
}