
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
    public class DarkButton : Button, IControl
    {


        /**
         * 
         */
        public DarkButton()
        {
            this.BackColor = Color.FromArgb(99,161,118);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            
        }

        public override Components.IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkButton();

            //set info for newControl
            //....

            return newControl;

        }



        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            //Draw border
            Brush b = new SolidBrush(this.BackColor);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(143,140,137), 2), 0, 0, this.Width, this.Height);

        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            try
            {

                base.OnPaintBackground(e);

                Color backColor = BackColor;

                if (isHovered && !isPressed && Enabled)
                {
                    backColor = Color.FromArgb(102, 39, 55);
                }
                else if (isHovered && isPressed && Enabled)
                {
                    backColor = Color.FromArgb(81, 31, 44);
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