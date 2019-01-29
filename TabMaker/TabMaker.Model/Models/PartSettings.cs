using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TabMaker.Model.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PartSettings : IPartSettings
    {
        [JsonProperty(PropertyName = "strings")]
        public List<IStringSetting> Strings { get; set; }
    }
}
