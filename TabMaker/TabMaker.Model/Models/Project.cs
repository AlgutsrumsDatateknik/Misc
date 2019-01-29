using System.Collections.Generic;
using Newtonsoft.Json;

namespace TabMaker.Model.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Project : IProject
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        [JsonProperty(PropertyName = "parts")]
        public List<IPart> Parts { get; set; }
    }
}
