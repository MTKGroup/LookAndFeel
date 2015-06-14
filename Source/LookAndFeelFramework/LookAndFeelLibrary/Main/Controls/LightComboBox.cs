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
    public class LightComboBox : ComboBox
    {
        private ComponentInfo info;

        public LightComboBox()
        {
            UseCustomBackColor = true;
            BackColor = Color.FromArgb(241, 169, 160);
        }

        public LightComboBox(ComponentInfo info)
            : base(info)
        {
            UseCustomBackColor = true;
            BackColor = Color.FromArgb(255,  246,  237);
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightComboBox(info);


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

            Pen pen = new Pen(this.Parent.ForeColor, 1);

            e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
