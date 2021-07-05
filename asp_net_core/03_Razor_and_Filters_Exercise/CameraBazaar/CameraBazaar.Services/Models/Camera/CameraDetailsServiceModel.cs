﻿namespace CameraBazaar.Services.Models.Camera
{
    using Data.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CameraDetailsServiceModel
    {
        public MakeType Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public bool IsInStock { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Full Frame")]
        public bool IsFullFrame { get; set; }

        public int MinShutterSpeed { get; set; }

        public int MaxShutterSpeed { get; set; }

        public MinIsoType MinIso { get; set; }

        public int MaxIso { get; set; }

        public string VideoResolution { get; set; }

        public ICollection<LightMeteringType> LightMetering { get; set; }

        public string Description { get; set; }
    }
}
