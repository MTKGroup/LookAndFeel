
using LookAndFeel.Components;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;


namespace LookAndFeel.Controls
{
    /**
     * 
     */
    public class LightButton : Button
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        private DateTime backupTime;
        System.Threading.Thread thread;
        private double pressedTime = 0;
        private double TotalTime = 700;
        private bool isWorking = false;
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

 

             thread = new System.Threading.Thread(
                                                    () => {
                                                    abc:
                                                        if (!isWorking) goto abc;
                                                        
                                                        var distance = (DateTime.Now - backupTime).TotalMilliseconds;
                                                        if (distance >= 1000 / 60 &&
                                                            MouseButtons != System.Windows.Forms.MouseButtons.None
                                                            && pressedTime < TotalTime)
                                                        {
                                                            pressedTime += distance;
                                                            Invalidate();
                                                            backupTime = DateTime.Now;
                                                            
                                                        }
                                                        else if (pressedTime >= TotalTime)
                                                        {
                                                            isWorking = false;
                                                            this.Invoke((System.Windows.Forms.MethodInvoker)(()=>{
                                                                foreach (var h in clickHandlers)
                                                                {
                                                                    h(this);
                                                                }
                                                            }));

                                                        }

                                                        goto abc;
                                                        
                                                    }, 0);
             thread.Start();
              
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightButton(info);

            //set info for newControl
            //....

            return newControl;

        }



        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);

            backupTime = DateTime.Now;
            pressedTime = 0;
            isWorking = true;

            
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isWorking = false;
            pressedTime = 0;
            Invalidate();
     
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

                //Draw percent
                if (MouseButtons != System.Windows.Forms.MouseButtons.None && pressedTime > 0)
                {
                    backColor = Color.FromArgb(255, 246, 237);
                    var percentColor = Color.FromArgb(
                                        (int)(backColor.R * .7f),
                                        (int)(backColor.G * .7f),
                                        (int)(backColor.B * .7f));
                    percentColor = Color.FromArgb(255 , 146,  142);
                    e.Graphics.FillRectangle(new SolidBrush(percentColor), 0, 0,
                                            (float)this.pressedTime / (float)this.TotalTime * (this.Width - 1),
                                            this.Height);
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

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (thread != null && thread.ThreadState == ThreadState.Running)
            {

                thread.Abort();
            }
            
            
        }
    }
}