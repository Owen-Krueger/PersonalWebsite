namespace PersonalWebsite.Utilities;

public static class DateOnlyExtensions
{
    /// <summary>
    /// Gets a date string in the format of "startDate - endDate" or "startDate - Present" if endDate is null.
    /// </summary>
    public static string GetDateString(DateOnly startDate, DateOnly? endDate)
    {
        return $"({startDate} - {endDate?.ToString() ?? "Present"})";
    }
}