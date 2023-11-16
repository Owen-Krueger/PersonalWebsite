﻿using Newtonsoft.Json;

namespace PersonalWebsite.Models.Portfolio;

public class PortfolioLanguage
{
    [JsonProperty("Name")]
    public ProgrammingLanguage Language { get; set; }

    public decimal Rating { get; set; }
}