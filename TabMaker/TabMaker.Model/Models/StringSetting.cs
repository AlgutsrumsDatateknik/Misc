using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TabMaker.Model.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class StringSetting : IStringSetting
    {
        [JsonProperty(PropertyName = "tuning")]
        public string Tuning { get; set; }
    }
}
