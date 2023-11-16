namespace PersonalWebsite.Models;

public enum ProgrammingLanguage
{
    CSharp,

    CPlusPlus,

    Rust
}

public static class ProgrammingLanguageUtilities
{
    public static string GetFormattedString(this ProgrammingLanguage programmingLanguage)
    {
        return programmingLanguage switch
        {
            ProgrammingLanguage.CSharp => "C#",
            ProgrammingLanguage.CPlusPlus => "C++",
            ProgrammingLanguage.Rust => "Rust",
            _ => string.Empty
        };
    }

    public static string GetColor(this ProgrammingLanguage programmingLanguage)
    {
        var color = programmingLanguage switch
        {
            ProgrammingLanguage.CSharp => "purple",
            ProgrammingLanguage.CPlusPlus => "sky",
            ProgrammingLanguage.Rust => "red",
            _ => "green"
        };

        return $"text-{color}-500";
    }
}