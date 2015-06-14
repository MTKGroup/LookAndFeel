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
    public class LightLabel : Label, IControl
    {
        public LightLabel()
        {
            this.Font = new Font("Segoe UI", 9);

        }

        public LightLabel(ComponentInfo info) : base(info)
        {
            this.Font = new Font("Segoe UI", 9);
            ForeColor = Color.FromArgb(150, 40, 27);

        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightLabel(info);

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            Font font = new System.Drawing.Font("Arial", 9);
            e.Graphics.Clear(this.Parent.BackColor);
            e.Graphics.DrawString(this.Text, font, new SolidBrush(ForeColor), 0, 0);


        }
    }
}