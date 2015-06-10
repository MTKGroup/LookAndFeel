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
    public class LightCheckBox : CheckBox, IControl
    {

        public LightCheckBox()
        {

        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightCheckBox();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.White, 20, 0, this.Width - 20, this.Height);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(18, 7), Color.LightBlue);
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);


        }
    }
}
