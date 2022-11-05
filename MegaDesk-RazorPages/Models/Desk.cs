﻿namespace MegaDesk_RazorPages.Models
{
    public class Desk
    {
        public float DeskWidth { get; set; }
        public float DeskDepth { get; set; }
        public int NumDrawers { get; set; }


        public string DeskMaterial { get; set; }


        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 28;
        public const int MAXDEPTH = 48;
        public const int MINNUMOFDRAWERS = 0;
        public const int MAXNUMOFDRAWERS = 7;
    }
    public enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
