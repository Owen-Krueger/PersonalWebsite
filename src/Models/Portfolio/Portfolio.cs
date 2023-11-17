namespace PersonalWebsite.Models.Portfolio;

/// <summary>
/// The portfolio. Contains all the information to display on the portfolio page.
/// </summary>
public class Portfolio
{
    /// <summary>
    /// Work experience.
    /// </summary>
    public Work Work { get; set; } = new();

    /// <summary>
    /// Projects completed.
    /// </summary>
    public List<Project> Projects { get; set; } = new();

    /// <summary>
    /// Computer programming languages used.
    /// </summary>
    public List<PortfolioLanguage> Languages { get; set; } = new();
}