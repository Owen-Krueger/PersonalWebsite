using Newtonsoft.Json;

namespace PersonalWebsite.Models.Portfolio;

/// <summary>
/// Employment history.
/// </summary>
public class Work
{
    /// <summary>
    /// A list of companies worked at.
    /// </summary>
    public List<Company> Companies { get; set; } = new();
}

/// <summary>
/// An employer.
/// </summary>
public class Company
{
    /// <summary>
    /// The name of the company.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The various positions held at the company.
    /// </summary>
    public List<Position> Positions { get; set; } = new();
}

/// <summary>
/// A position held at a company.
/// </summary>
public class Position
{
    /// <summary>
    /// The title/role of the position.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The date the position started.
    /// </summary>
    [JsonProperty("start")]
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// The date the position ended. Null if still employed.
    /// </summary>
    [JsonProperty("end")]
    public DateOnly? EndDate { get; set; }

    /// <summary>
    /// Additional information about the position.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}