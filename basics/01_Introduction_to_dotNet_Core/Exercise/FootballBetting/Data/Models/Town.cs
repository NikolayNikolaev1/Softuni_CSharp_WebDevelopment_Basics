﻿namespace FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string CountryId { get; set; }

        public Country Country { get; set; }

        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
