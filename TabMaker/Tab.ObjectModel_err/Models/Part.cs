using System;
using System.Collections.Generic;
using System.Text;

namespace Tab.ObjectModel.Models
{
    public class Part : IPart
    {
        public string Title { get; set; }
        public string Comments { get; set; }
        public IPartSettings Settings { get; set; }
        public List<INotation> Notations { get; set; }
    }
}
