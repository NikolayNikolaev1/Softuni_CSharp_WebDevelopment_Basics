﻿namespace CarDealer.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Part
    {
        public int Id { get; set; }

        [MaxLength(Constants.StringMaxLength)]
        [MinLength(Constants.StringMinlength)]
        [Required]
        public string Name { get; set; }

        [Range(Constants.RangeMinValue, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public ICollection<CarPart> Cars { get; set; } = new List<CarPart>();

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }
    }
}
