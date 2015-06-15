
using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Forms{
    /**
     * 
     */
    public abstract class Form :  MetroFramework.Forms.MetroForm, IComponent {

        protected ComponentInfo info;
        protected System.Drawing.Color backColor = System.Drawing.Color.White;
        protected System.Drawing.Color foreColor = System.Drawing.Color.Black;
        protected System.Drawing.Color lineColor = System.Drawing.Color.BlueViolet;

        protected Button[] windowButtons = new Button[3];
        /**
         * 
         */
        public Form() {
            
        }

        public Form(ComponentInfo info)
        {
            this.info = info.clone();
            this.Top = info.Y;
            this.Left = info.X;
            this.Name = this.Text = info.Name;
            this.Width = info.Width >= 0 ? info.Width : this.Width;
            this.Height = info.Height >= 0 ? info.Height : this.Height;
            info.Width = info.Width >= 0 ? info.Width : this.Width;
            info.Height = info.Height >= 0 ? info.Height : this.Height;


            AddWindowButtons();
        }

        
        private void AddWindowButtons()
        {
            ComponentInfo info;
            Button btn;


            info = new ComponentInfo(this.Width - 25, 4, 25, 25, "r");
            btn = new WindowButton(info);
            btn.Tag = 25;
            this.Controls.Add(btn); 
            btn.Parent = this;
            btn.Click += btn_Click;
            windowButtons[0] = btn;


            info = new ComponentInfo(this.Width - 50, 4, 25, 25, "0");
            btn = new WindowButton(info);
            btn.Tag = 50;
            this.Controls.Add(btn);
            btn.Parent = this;
            btn.Click += (sender, e) => { this.WindowState = System.Windows.Forms.FormWindowState.Minimized; };

            windowButtons[1] = btn;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<System.Windows.Forms.Control> list = new List<System.Windows.Forms.Control>();


            //Extract default window button
            foreach (System.Windows.Forms.Control item in this.Controls)
	        {
                if (item.GetType().Name.Equals("MetroFormButton"))
                    list.Add(item);
	        } 
            
            //remove
            foreach (var item in list)
            {
                this.Controls.Remove(item);
            }
            this.Font = new System.Drawing.Font("Segoe UI", 8);
            Invalidate();
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            updateWindowButton();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            updateWindowButton();
        }

        private void updateWindowButton()
        {
            foreach (var b in windowButtons)
            {
                if (b != null)
                {
                    b.Left = this.Width - (int)b.Tag;

                }
            }
        }

        

        void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * 
         */
        protected HashSet<IControl> controls = new HashSet<IControl>();

        /**
         * @param f 
         * @return
         */
        public IComponent convert(ComponentFactory f) 
        {
            ComponentInfo info = new ComponentInfo();
            var newForm = (Form)f.create(this.getType(), info);

            foreach (var c in this.controls)
            {
                newForm.addControl((IControl)c.convert(f));
            }

            return newForm;
        }

        public void addControl(IControl component)
        {
            //((System.Windows.Forms.Control)component).Parent = this;
            this.controls.Add(component);
            this.Controls.Add((System.Windows.Forms.Control)component);
        }

        public void removeControl(IControl component)
        {
            this.controls.Remove(component);
            this.Controls.Remove((System.Windows.Forms.Control)component);
           
        }

        /**
         * @return
         */
        public String getType()
        {
            // TODO implement here
            return "Form";
        }


        public abstract IComponent clone(ComponentInfo info);

        public override System.Drawing.Color BackColor
        {
            get
            {
                return this.backColor;
            }

            set
            {
                this.backColor = value;
            }
        }

        public override System.Drawing.Color ForeColor
        {
            get
            {
                return this.foreColor;
            }
            set
            {
                this.foreColor = value;
            }
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);


        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(this.lineColor),
                        0, 0, this.Width, 4);
            var font = new System.Drawing.Font(this.Font.FontFamily, 12);
            e.Graphics.DrawString(this.Text,
                                font,
                                new System.Drawing.SolidBrush(this.foreColor),
                                20, 20);
        }

        /**
         * Nested class WindowButton
        **/
        private class WindowButton : Button
        {
            public WindowButton(ComponentInfo info) : base(info)
            {
 
            }

            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                base.OnPaint(e);

                var backColor = this.Parent.BackColor;
                var foreColor = this.Parent.ForeColor;

                if (isHovered)
                {
                    backColor = System.Drawing.Color.FromArgb(
                                            (int)(backColor.R * 0.8f),
                                            (int)(backColor.G * 0.8f),
                                            (int)(backColor.B * 0.8f));
                }


                e.Graphics.Clear(backColor);
                var font = new System.Drawing.Font("Webdings", 9.25f);
                System.Windows.Forms.TextRenderer.DrawText(
                                    e.Graphics, 
                                    Text,
                                    font, 
                                    ClientRectangle,
                                    foreColor,
                                    backColor, 
                                    System.Windows.Forms.TextFormatFlags.HorizontalCenter | System.Windows.Forms.TextFormatFlags.VerticalCenter | System.Windows.Forms.TextFormatFlags.EndEllipsis);
            }

            public override IComponent clone(ComponentInfo info)
            {
                return new WindowButton(info);
            }
        }
    }
}