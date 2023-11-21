namespace PersonalWebsite.Models;

/// <summary>
/// Computer programming languages.
/// </summary>
public enum ProgrammingLanguage
{
    /// <summary>
    /// C# programming language.
    /// </summary>
    CSharp,

    /// <summary>
    /// C++ programming language.
    /// </summary>
    CPlusPlus,

    /// <summary>
    /// Rust programming language.
    /// </summary>
    Rust,

    /// <summary>
    /// Python programming language.
    /// </summary>
    Python
}

/// <summary>
/// Utility methods for <see cref="ProgrammingLanguage"/>.
/// </summary>
public static class ProgrammingLanguageUtilities
{
    /// <summary>
    /// Gets the string to display for a <see cref="ProgrammingLanguage"/>.
    /// </summary>
    public static string GetFormattedString(this ProgrammingLanguage programmingLanguage)
    {
        return programmingLanguage switch
        {
            ProgrammingLanguage.CSharp => "C#",
            ProgrammingLanguage.CPlusPlus => "C++",
            ProgrammingLanguage.Rust => "Rust",
            ProgrammingLanguage.Python => "Python",
            _ => string.Empty
        };
    }

    /// <summary>
    /// Gets the color to display for a <see cref="ProgrammingLanguage"/>.
    /// </summary>
    public static string GetColor(this ProgrammingLanguage programmingLanguage, string? start = null)
    {
        var color = programmingLanguage switch
        {
            ProgrammingLanguage.CSharp => "purple",
            ProgrammingLanguage.CPlusPlus => "sky",
            ProgrammingLanguage.Rust => "red",
            ProgrammingLanguage.Python => "blue",
            _ => "green"
        };

        return $"{start ?? "text"}-{color}-500";
    }
}