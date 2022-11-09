using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace SquareShape.WebApi.Models
{
    public class InformAboutFigure 
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("square")]
        public double Square { get; set; }
    }
}