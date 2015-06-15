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
    public class LightGroupBox : GroupBox
    {
        private ComponentInfo info;

        public LightGroupBox()
        {
        }

        public LightGroupBox(ComponentInfo info)
            : base(info)
        {
            this.Font = new Font("Segoe UI", 11);
        }



        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightGroupBox(info);

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

            Pen pen = new Pen(ForeColor, 1f);
            int titleHeight = this.Height * 0.2 > 30 ? 30 : (int)(this.Height * 0.2);
            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);

            e.Graphics.Clear(BackColor);
            e.Graphics.DrawRectangle(pen, 0, (int)textSize.Height / 2, this.Width - 1 - textSize.Height / 2, this.Height - 1 - textSize.Height / 2);
            //e.Graphics.DrawLine(new Pen(ForeColor), 0, 0, this.Width - 1, 1);
            //e.Graphics.FillRectangle(new SolidBrush(ForeColor), 0, 0, this.Width - 1, titleHeight);

            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(2, 0), ForeColor, BackColor);
        }
    }
}
