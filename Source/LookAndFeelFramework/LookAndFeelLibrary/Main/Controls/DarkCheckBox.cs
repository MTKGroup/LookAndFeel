using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public class DarkCheckBox : CheckBox, IControl
    {

        public DarkCheckBox()
        {
            
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkCheckBox();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.White, 19, 0, this.Width - 19, this.Height);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, 7), Color.DarkGray);
        }
    }
}
