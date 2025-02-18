﻿namespace CameraBazaar.Data.Models
{
    using Enums;
    using System.ComponentModel.DataAnnotations;
    using Validations.Camera;

    using static Common.Constants.Properties.Camera;

    public class Camera
    {
        public int Id { get; set; }

        public MakeType Make { get; set; }

        [Model(nameof(Model))]
        public string Model { get; set; }

        [Range(PriceMinValue, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(QuantityMinValue, QuantityMaxValue)]
        public int Quantity { get; set; }

        [Range(MinShutterSpeedMinValue, MinShutterSpeedMaxValue)]
        // Seconds
        public int MinShutterSpeed { get; set; }

        [Range(MaxShutterSPeedMinValue, MaxShutterSpeedMaxValue)]
        // Fraction of a second
        public int MaxShutterSpeed { get; set; }

        public MinIsoType MinIso { get; set; }

        [Display(Name = "Max ISO")]
        [MaxIso(nameof(MaxIso))]
        public int MaxIso { get; set; }

        public bool IsFullFrame { get; set; }

        [MaxLength(VideoResolutionMaxLength)]
        [Required]
        public string VideoResolution { get; set; }

        public LightMeteringType LightMetering { get; set; }

        [MaxLength(DescriptionMaxLength)]
        [Required]
        public string Description { get; set; }

        [Url]
        [Required]
        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
