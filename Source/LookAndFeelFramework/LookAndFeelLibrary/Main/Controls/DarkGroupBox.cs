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

        public DarkGroupBox(ComponentInfo info)
        {
            // TODO: Complete member initialization
            this.info = new ComponentInfo();
            this.info.x = info.x;
            this.info.y = info.y;
            this.info.width = info.width;
            this.info.height = info.height;
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

            Pen pen = new Pen(Color.DarkGray, .5f);

            e.Graphics.Clear(Color.White);

            e.Graphics.DrawRectangle(pen, 0, 0, this.Width-20, this.Height-20);
            e.Graphics.FillRectangle(Brushes.DarkGray, 0, 0, this.Width - 20, (int)(this.Height * 0.2));
            Font font = new Font("Helvetica", 10, FontStyle.Regular);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, font, new Point(2, 2), Color.White);
        }
    }
}
