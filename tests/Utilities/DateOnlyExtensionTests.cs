using PersonalWebsite.Utilities;

namespace PersonalWebsite.Tests.Utilities;

public class DateOnlyExtensionTests
{
    [Test]
    public void GetDateString_EndDateProvided_DateRangeStringReturned()
    {
        DateOnly
            startDate = new(2000, 1, 1),
            endDate = new(2001, 12, 31);
        var response = DateOnlyExtensions.GetDateString(startDate, endDate);

        Assert.That(response, Is.EqualTo("(2000-01-01 - 2001-12-31)"));
    }

    [Test]
    public void GetDateString_EndDateNotProvided_PresentStringReturned()
    {
        var startDate = new DateOnly(2000, 1, 1);
        var response = DateOnlyExtensions.GetDateString(startDate, null);

        Assert.That(response, Is.EqualTo("(2000-01-01 - Present)"));
    }
}