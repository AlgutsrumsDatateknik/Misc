using System;
using System.Collections.Generic;
using System.Text;

namespace Tab.ObjectModel.Models
{
    public class Application
    {
        internal static Dictionary<string, TabOperation> Operations = new Dictionary<string, TabOperation>
        {
            {"h", TabOperation.HammerOn},
            {"p", TabOperation.PullOff},
            {"b", TabOperation.Bend},
            {"r", TabOperation.Release},
            {"/", TabOperation.SlideUp},
            {@"\", TabOperation.SlideDown},
            {"v", TabOperation.Vibrato},
            {"t", TabOperation.Tap},
            {"x", TabOperation.Muted},
        };

    }
}
