using Newtonsoft.Json;

namespace PersonalWebsite.Models.Portfolio;

/// <summary>
/// Education obtained.
/// </summary>
public class Education
{
    /// <summary>
    /// Schools attended.
    /// </summary>
    public List<School> Schools { get; set; } = new();
}

/// <summary>
/// Information about a school attended.
/// </summary>
public class School
{
    /// <summary>
    /// The name of the school.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The degree obtained.
    /// </summary>
    public string Degree { get; set; } = string.Empty;

    /// <summary>
    /// Major received.
    /// </summary>
    public string Major { get; set; } = string.Empty;

    /// <summary>
    /// Minor received, if applicable.
    /// </summary>
    public string? Minor { get; set; }

    /// <summary>
    /// Concentration received, if applicable.
    /// </summary>
    public string? Concentration { get; set; }

    /// <summary>
    /// Date started attending the school.
    /// </summary>
    [JsonProperty("start")]
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// Date stopped attending the school.
    /// </summary>
    [JsonProperty("end")]
    public DateOnly EndDate { get; set; }

    /// <summary>
    /// Grade point average received.
    /// </summary>
    public decimal Gpa { get; set; } = 0m;

    /// <summary>
    /// Relevant courses taken.
    /// </summary>
    public List<Course> Courses { get; set; } = new();
}

/// <summary>
/// Course taken.
/// </summary>
public class Course
{
    /// <summary>
    /// Name of the course.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Course number.
    /// </summary>
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Description of the course, if provided.
    /// </summary>
    public string? Description { get; set; }
}