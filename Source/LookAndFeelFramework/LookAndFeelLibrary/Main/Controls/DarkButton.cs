
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls
{
    /**
     * 
     */
    public class DarkButton : Button
    {


        /**
         * 
         */
        public DarkButton()
        {
            this.BackColor = Color.FromArgb(34, 49, 63);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            
        }

        public override Components.IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkButton();

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

            //Draw border
            Brush b = new SolidBrush(this.BackColor);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(51, 110, 123), 2), 0, 0, this.Width, this.Height);

        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            try
            {

                base.OnPaintBackground(e);

                Color backColor = BackColor;

                if (isHovered && !isPressed && Enabled)
                {
                    backColor = Color.FromArgb(103, 128, 159);
                }
                else if (isHovered && isPressed && Enabled)
                {
                    backColor = Color.FromArgb(44, 62, 80);
                }
                else
                {
                    backColor = this.BackColor;
                }


                if (backColor.A == 255 && BackgroundImage == null)
                {
                    e.Graphics.Clear(backColor);
                    return;
                }



            }
            catch
            {
                Invalidate();
            }
        }
    }
}