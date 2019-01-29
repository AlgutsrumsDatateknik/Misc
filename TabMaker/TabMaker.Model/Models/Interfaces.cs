﻿using System.Collections.Generic;

namespace TabMaker.Model.Models
{
    public interface IProject
    {
        string Title { get; set; }
        string Comments { get; set; }
        List<IPart> Parts { get; set; }
    }

    public interface IPart
    {
        string Title { get; set; }
        string Comments { get; set; }
        IPartSettings Settings { get; set; }
        List<INotation> Notations { get; set; }
    }

    public interface IPartSettings
    {
        List<IStringSetting> Strings { get; set; }
    }

    public interface IStringSetting
    {
        string Tuning { get; set; }
    }

    public interface INotation
    {
        int? Fret { get; set; }
        TabOperation Operation { get; set; }
        int? DestinationFret { get; set; }
    }
}
