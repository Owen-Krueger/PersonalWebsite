namespace PersonalWebsite.Models.Portfolio;

/// <summary>
/// A programming project.
/// </summary>
public class Project
{
    /// <summary>
    /// The name of the project.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The programming languages used for the project.
    /// </summary>
    public List<ProgrammingLanguage> Languages { get; set; } = new();

    /// <summary>
    /// A link to the project.
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// Additional information about the project.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}