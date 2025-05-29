using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeminiAPI
{
    internal class Content
    {
        [JsonPropertyName("parts")]
        public List<Part> Parts { get; set; }
    }
}
