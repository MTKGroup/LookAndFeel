
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
    public class LightButton : Button
    {
        /**
         * 
         */
        public LightButton()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(150, 40, 27);

            this.Font = new Font("Segoe UI", 8);

        }

        public LightButton(ComponentInfo info)
            : base(info)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(150, 40, 27);

            this.Font = new Font("Segoe UI", 8);
            SetStyle(System.Windows.Forms.ControlStyles.StandardClick | System.Windows.Forms.ControlStyles.StandardDoubleClick, true);
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightButton(info);

            //set info for newControl
            //....

            return newControl;

        }

        protected override void OnDoubleClick(EventArgs e)
        {
            
            base.OnDoubleClick(e);

            foreach (var handler in this.clickHandlers)
            {
                handler(this);
            }
        }
        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Clicks >= 2)
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
                Color borderColor = ForeColor;

                if (isHovered && !isPressed && Enabled)
                {
                    backColor = Color.FromArgb(255,  246,  237);
                }
                else if (isHovered && isPressed && Enabled)
                {
                    //backColor = BackColor;
                }
                else if (Focused)
                {
                    foreColor = Color.FromArgb(
                                        Math.Min((int)(ForeColor.R * 1.4f), 255),
                                        Math.Min((int)(ForeColor.G * 1.4f), 255),
                                        Math.Min((int)(ForeColor.B * 1.4f), 255));
                }

                if (backColor.A == 255 && BackgroundImage == null)
                {
                    e.Graphics.Clear(backColor);
                }

                e.Graphics.DrawRectangle(new Pen(borderColor), 0, 0, this.Width - 1, this.Height - 1);

                System.Windows.Forms.TextRenderer.DrawText(e.Graphics,
                        this.Text, this.Font,
                        new Point(this.Width, this.Height / 2),
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