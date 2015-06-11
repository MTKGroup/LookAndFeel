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
    public class DarkCheckBox : CheckBox
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            foreach (var handler in this.clickHandlers)
            {
                handler(this);
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
            e.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, (int)(this.Height/2 - textSize.Height/2)), Color.DarkGray);

            e.Graphics.DrawRectangle(Pens.Black, 0, this.Height/4, this.Height/2, this.Height/2);
            if (this.Checked)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray,
                                            (int)(this.Height / 4 * 0.4),
                                            (int)(this.Height / 4 *1.4),
                                            (int)(this.Height / 2 * 0.8),
                                            (int)(this.Height / 2 * 0.8));
            }
        }
    }
}
