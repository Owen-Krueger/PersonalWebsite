namespace PersonalWebsite.Models.Portfolio;

public class Portfolio
{
    public Work Work { get; set; }

    public List<Project> Projects { get; set; }

    public List<ProgrammingLanguage> Languages { get; set; }
}