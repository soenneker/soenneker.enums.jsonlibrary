using Intellenum;

namespace Soenneker.Enums.JsonLibrary;

/// <summary>
/// An enumeration for common JSON library types
/// </summary>
[Intellenum<int>]
public sealed partial class JsonLibraryType
{
    /// <summary>
    /// System.Text.Json
    /// </summary>
    public static readonly JsonLibraryType SystemTextJson = new(0);

    /// <summary>
    /// JSON.net
    /// </summary>
    public static readonly JsonLibraryType Newtonsoft = new(1);
}
