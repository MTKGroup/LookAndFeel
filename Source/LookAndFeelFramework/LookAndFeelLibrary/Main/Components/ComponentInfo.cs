using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeelLibrary.Main.Components
{
    public class ComponentInfo
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public string Name;
        public object Tag;

        public ComponentInfo() { }

        public ComponentInfo(int x, int y, int width, int height) 
        {
            this.X      =   x;
            this.Y      =   y;
            this.Width  =   width;
            this.Height =   height;
        }

        public ComponentInfo(int p1, int p2, int p3, int p4, string p5)
        {
            // TODO: Complete member initialization
            this.X      =   p1;
            this.Y      =   p2;
            this.Width  =   p3;
            this.Height =   p4;
            this.Name   =   p5;
        }

        public Point Pos {
            get {
                return new Point(X, Y);
            }
        }

        public SizeF Size {
            get {
                return new SizeF(Width, Height);
            }
        }

        public ComponentInfo clone()
        {
            return this.MemberwiseClone() as ComponentInfo;
        }
    }
}
