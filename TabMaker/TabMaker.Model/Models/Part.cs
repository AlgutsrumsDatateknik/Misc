using System.Collections.Generic;
using Newtonsoft.Json;

namespace TabMaker.Model.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Part : IPart
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }
        [JsonProperty(PropertyName = "settings")]
        public IPartSettings Settings { get; set; }
        [JsonProperty(PropertyName = "notations")]
        public List<INotation> Notations { get; set; }
    }
}
