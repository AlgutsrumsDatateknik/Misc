using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace TabMaker.Model.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Notation : INotation
    {
        [JsonProperty(PropertyName = "sourceFret", Required = Required.AllowNull)]
        public int? Fret { get; set; }
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public TabOperation Operation { get; set; }
        [JsonProperty(PropertyName = "destFret", Required = Required.AllowNull)]
        public int? DestinationFret { get; set; }


        public static Notation Parse(string input)
        {
            if (input == "x")
            {
                return new Notation
                {
                    Fret = null,
                    Operation = TabOperation.Muted,
                    DestinationFret = null
                };
            }
            var m = Regex.Match(input, @"([0-9]{1,2})([a-z\/\\]{0,1})([0-9]*)");

            if (!m.Success) return null;

            var not = new Notation
            {
                Fret = int.Parse(m.Groups[1].Value),
                Operation = Application.Operations[(m.Groups[2].Value)],
                DestinationFret = string.IsNullOrEmpty(m.Groups[3].Value)
                    ? (int?) null
                    : int.Parse(m.Groups[3].Value)
            };
            return not;

        }

        public override string ToString()
        {
            var key = Application.Operations.First(kv => kv.Value == Operation).Key;
            return $"{Fret}{key}{DestinationFret}";
        }
    }

}
