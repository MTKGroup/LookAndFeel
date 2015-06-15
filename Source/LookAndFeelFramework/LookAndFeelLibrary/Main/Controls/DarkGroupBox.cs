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
    public class DarkGroupBox : GroupBox
    {
        private ComponentInfo info;

        public DarkGroupBox(){
        }

        public DarkGroupBox(ComponentInfo info) : base(info)
        {
            this.Font = new Font("Segoe UI", 11);
        }

        

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkGroupBox(info);

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

            Pen pen = new Pen(ForeColor, .5f);
            int titleHeight = this.Height * 0.2 > 30 ?  30 : (int)(this.Height * 0.2);
            e.Graphics.Clear(BackColor);

            e.Graphics.DrawRectangle(pen, 0, 0, this.Width-1, this.Height-1);
            e.Graphics.FillRectangle(new SolidBrush(ForeColor), 0, 0, this.Width - 1, titleHeight);

            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(2, titleHeight/2 - (int)textSize.Height/2), BackColor);
        }
    }
}
