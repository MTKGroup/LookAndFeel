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
    public class DarkLabel : Label
    {
        private ComponentInfo info;


        public DarkLabel()
        {
            this.Font = new Font("Segoe UI", 9);

        }

        public DarkLabel(ComponentInfo info) : base(info)
        {
            this.Font = new Font("Segoe UI", 9);

        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkLabel(info);

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

            Font font = this.Font;
            // System.Windows.Forms.TextRenderer.MeasureText(this.Text, font);
            e.Graphics.Clear(this.Parent.BackColor);
            e.Graphics.DrawString(this.Text, font, new SolidBrush(Color.FromArgb(189, 195, 199)), 0, 0);

        }
    }
}
