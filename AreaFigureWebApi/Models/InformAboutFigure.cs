﻿using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace AreaFigureWebApi.Models
{
    public class InformAboutFigure 
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("sides")]
        public double[] Sides { get; set; }

        [JsonPropertyName("square")]
        public double Square { get; set; }

        [JsonPropertyName("failedMassage")]
        public string FailedMassage { get; set; }
    }
}