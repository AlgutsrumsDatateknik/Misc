using System.Collections.Generic;

namespace TabMaker.Model.Models
{

    public enum TabOperation
    {
        None,
        HammerOn,
        PullOff,
        Bend,
        Release,
        SlideUp,
        SlideDown,
        Vibrato,
        Tap,
        Muted
    }

    public class Application
    {
        internal static Dictionary<string, TabOperation> Operations = new Dictionary<string, TabOperation>
        {
            {"", TabOperation.None},
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
