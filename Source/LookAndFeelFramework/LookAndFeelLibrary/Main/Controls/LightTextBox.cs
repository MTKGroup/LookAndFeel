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
        private bool focused;

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


        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            this.focused = true;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            this.focused = false;
            Invalidate();
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
            int lineWidth = 1;

            if (focused)
            {
                lineWidth = 2;
            }

            Pen pen = new Pen(this.Parent.ForeColor, lineWidth);
            Pen clearPen = new Pen(this.Parent.BackColor);

            

            e.Graphics.DrawRectangle(clearPen, 
                                0, 
                                0, 
                                this.Width - 1, 
                                this.Height - 1);
             
            e.Graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
            e.Graphics.DrawLine(pen, 0, this.Height - 1, 0, this.Height * .7f);
            e.Graphics.DrawLine(pen, this.Width - 1, this.Height - 1, this.Width - 1, this.Height * .7f);
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
