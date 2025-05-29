using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeminiAPI
{
    internal class GeminiRequest
    {
        [JsonPropertyName("contents")]
        public List<Content> Contents { get; set; }
    }
}
