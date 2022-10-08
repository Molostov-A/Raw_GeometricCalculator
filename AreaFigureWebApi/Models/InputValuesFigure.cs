using System.Text.Json.Serialization;

namespace AreaFigureWebApi.Models
{
    public class InputValuesFigure
    {
        [JsonPropertyName("values")]
        public double[] Values { get; set; }
    }
}