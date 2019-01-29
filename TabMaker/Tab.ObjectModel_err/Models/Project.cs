using System;
using System.Collections.Generic;
using System.Text;

namespace Tab.ObjectModel.Models
{
    public class Project : IProject
    {
        public string Title { get; set; }

        public string Comments { get; set; }

        public List<IPart> Parts { get; set; }
    }
}
