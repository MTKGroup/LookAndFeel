using LookAndFeel.Components;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public class DarkTextBox : TextBox, IControl
    {
        public DarkTextBox()
        {
            
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkTextBox();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            
            //e.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
            //System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, 7), Color.DarkGray);
        }
    }
}
