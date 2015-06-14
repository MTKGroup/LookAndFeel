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
    public class LightTextBox : TextBox
    {

        public LightTextBox()
        {


        }

        public LightTextBox(ComponentInfo info)
            : base(info)
        {
            BackColor = Color.FromArgb(255,  246,  237);
            FontSize = MetroFramework.MetroTextBoxSize.Medium;
            UseCustomBackColor = true;
            UseCustomForeColor = true;
            Style = MetroFramework.MetroColorStyle.Black;
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightTextBox(info);


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

            e.Graphics.DrawRectangle(new Pen(this.Parent.ForeColor), 0, 0, this.Width - 1, this.Height - 1);
        }


        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);

        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            //this.ForeColor = Color.DarkGray;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);

        }


    }
}
