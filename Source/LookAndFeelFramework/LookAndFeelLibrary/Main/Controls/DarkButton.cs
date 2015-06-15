
using LookAndFeel.Components;
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
            this.ForeColor = Color.FromArgb(189, 195, 199);

            this.Font = new Font("Segoe UI", 8);
            
        }

        public DarkButton(ComponentInfo info) : base(info)
        {
            this.BackColor = Color.FromArgb(34, 49, 63);
            this.ForeColor = Color.FromArgb(189, 195, 199);

            this.Font = new Font("Segoe UI", 8);
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkButton(info);

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
            //Brush b = new SolidBrush(this.BackColor);
            //e.Graphics.DrawRectangle(new Pen(Color.FromArgb(51, 110, 123), 2), 0, 0, this.Width, this.Height);

            try
            {

                base.OnPaintBackground(e);

                Color backColor = BackColor;
                Color foreColor = ForeColor;
                Color borderColor =  Color.FromArgb(
                                        Math.Min((int)(foreColor.R * .7f), 255),
                                        Math.Min((int)(foreColor.G * .7f), 255),
                                        Math.Min((int)(foreColor.B * .7f), 255));

                if (isHovered && !isPressed && Enabled)
                {
                    backColor = Color.FromArgb(
                                        (int)(BackColor.R * 0.5f),
                                        (int)(BackColor.G * 0.5f),
                                        (int)(BackColor.B * 0.5f)
                                    );
                }
                else if (isHovered && isPressed && Enabled)
                {
                    //backColor = Color.FromArgb(44, 62, 80);
                    //foreColor = Color.FromArgb(239, 245, 249);
                }
                else if (Focused)
                {
                    foreColor = Color.White;
                }

                if (backColor.A == 255 && BackgroundImage == null)
                {
                    e.Graphics.Clear(backColor);
                }

                e.Graphics.DrawRectangle(new Pen(borderColor), 0, 0, this.Width - 1, this.Height - 1);

                System.Windows.Forms.TextRenderer.DrawText(e.Graphics,
                        this.Text, this.Font,
                        new Point(this.Width, this.Height/2),
                        foreColor,
                        Color.Transparent, 
                        System.Windows.Forms.TextFormatFlags.HorizontalCenter | System.Windows.Forms.TextFormatFlags.VerticalCenter);

            }
            catch
            {
                Invalidate();
            }
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}