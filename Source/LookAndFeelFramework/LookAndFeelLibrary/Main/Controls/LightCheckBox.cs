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
    public class LightCheckBox : CheckBox
    {
        private ComponentInfo info;


        public LightCheckBox()
        {
            this.Font = new Font("Segoe UI", 8);

        }

        public LightCheckBox(ComponentInfo info)
            : base(info)
        {
            this.Font = new Font("Segoe UI", 8);

        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightCheckBox(info);

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
            Color foreColor = this.Parent.ForeColor;
            Color backColor;

            if (isHovered)
                foreColor = Color.FromArgb(
                            Math.Min((int)(foreColor.R * 1.3f), 255),
                            Math.Min((int)(foreColor.G * 1.3f), 255),
                            Math.Min((int)(foreColor.B * 1.3f), 255));

            backColor = Color.FromArgb(
                                    (int)(foreColor.R * .7f),
                                    (int)(foreColor.G * .7f),
                                    (int)(foreColor.B * .7f));

            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
            e.Graphics.Clear(this.Parent.BackColor);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(14, (int)(this.Height / 2 - textSize.Height / 2)), foreColor);

            e.Graphics.DrawRectangle(new Pen(backColor), 0, this.Height / 4 - 1, this.Height / 2, this.Height / 2);
            if (this.Checked)
            {
                e.Graphics.FillRectangle(new SolidBrush(backColor),
                                            (int)(this.Height / 4 * 0.4),
                                            (int)(this.Height / 4 * 1.4 - 1),
                                            (int)(this.Height / 2 * 0.8),
                                            (int)(this.Height / 2 * 0.8));
            }




        }
    }
}
