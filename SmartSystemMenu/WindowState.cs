﻿using System;
using SmartSystemMenu.Native;

namespace SmartSystemMenu
{
    public class WindowState : ICloneable
    {
        public string ProcessName { get; set; }

        public string ClassName { get; set; }

        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool? AeroGlass { get; set; }

        public bool? AlwaysOnTop { get; set; }

        public WindowAlignment? Alignment { get; set; }

        public int? Transparency { get; set; }

        public Priority? Priority { get; set; }

        public bool? MinimizeToTrayAlways { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}