using System.Text.Json.Serialization;

namespace SquareShape.WebApi.Models
{
    public class InputValuesFigure
    {
        [JsonPropertyName("values")]
        public double[] Values { get; set; }
    }
}