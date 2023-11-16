using Newtonsoft.Json;

namespace PersonalWebsite.Models.Portfolio;

public class Work
{
    public List<Company> Companies { get; set; }
}

public class Company
{
    public string Name { get; set; }

    public List<Position> Positions { get; set; }
}

public class Position
{
    public string Title { get; set; }

    [JsonProperty("start")]
    public DateOnly StartDate { get; set; }

    [JsonProperty("end")]
    public DateOnly? EndDate { get; set; }

    public string Description { get; set; }
}