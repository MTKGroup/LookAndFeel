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
        public int x;
        public int y;
        public float width;
        public float height;

        public Point Pos {
            get {
                return new Point(x, y);
            }
        }

        public SizeF Size {
            get {
                return new SizeF(width, height);
            }
        }
    }
}
