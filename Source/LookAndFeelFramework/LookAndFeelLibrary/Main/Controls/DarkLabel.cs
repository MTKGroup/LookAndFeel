using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls
{
    public class DarkLabel : Label, IControl
    {
        public DarkLabel()
        {
            
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkLabel();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            Font font = new System.Drawing.Font("Arial", 9);
            e.Graphics.Clear(Color.Transparent);
            e.Graphics.DrawString(this.Text, font, Brushes.DarkGray, 0, 0);
            

        }
    }
}
