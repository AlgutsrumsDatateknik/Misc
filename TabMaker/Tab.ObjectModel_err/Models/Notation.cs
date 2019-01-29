using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tab.ObjectModel.Models
{

    public class Notation : INotation
    {
        public int Fret { get; set; }
        public TabOperation Operation { get; set; }
        public int? DestinationFret { get; set; }


        public static Notation Parse(string input)
        {
            var m = Regex.Match(input, @"([0-9]{1,2})([a-z\/\\]{0,1})([0-9]*)");
            if (m.Success)
            {
                var not = new Notation();
                not.Fret = int.Parse(m.Groups[1].Value);
                not.Operation = Application.Operations[(m.Groups[2].Value)];
                not.DestinationFret = int.Parse(m.Groups[3]?.Value);
                return not;
            }

            return null;
        } 
    }

}
