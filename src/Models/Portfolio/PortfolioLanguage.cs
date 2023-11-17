using Newtonsoft.Json;

namespace PersonalWebsite.Models.Portfolio;

/// <summary>
/// Computer programming languages used.
/// </summary>
public class PortfolioLanguage
{
    /// <summary>
    /// The name of the programming language.
    /// </summary>
    [JsonProperty("Name")]
    public ProgrammingLanguage Language { get; set; }

    /// <summary>
    /// The proficiency in the programming language out of 100.
    /// </summary>
    public int Proficiency { get; set; }
}