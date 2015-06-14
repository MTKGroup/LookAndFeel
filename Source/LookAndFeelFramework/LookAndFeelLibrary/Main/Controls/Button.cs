
using LookAndFeel.Components;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls{
    /**
     * 
     */
    public abstract class Button : MetroFramework.Controls.MetroButton, IControl {
        protected bool isHovered;
        protected bool isPressed;
        protected List<ClickHandler> clickHandlers = new List<ClickHandler>();
        protected ComponentInfo info;

        /**
         * 
         */
        public Button() {
            info = new ComponentInfo();
        }

        public Button(ComponentInfo info)
        {
            // TODO: Complete member initialization
            this.info   = info.clone();
            this.Top    = info.Y;
            this.Left   = info.X;         
            this.Name   = this.Text = info.Name;
            this.Width  = info.Width    != 0 ? info.Width   : this.Width;
            this.Height = info.Height   != 0 ? info.Height  : this.Height;
            info.Width  = info.Width    != 0 ? info.Width   : this.Width;
            info.Height = info.Height   != 0 ? info.Height  : this.Height;


        }

        /**
         * @return
         */
        public String getType() {
            return "Button";
        }

        /**
         * @return
         */
        public abstract IComponent clone(ComponentInfo info);

        /**
         * @param f 
         * @return
         */
        public IComponent convert(ComponentFactory f) {
            return f.create(this.getType(), this.info);    
        }

        public event ClickHandler ClickListener 
        { 
            add{
                this.clickHandlers.Add(value);
            }
            remove {
                this.clickHandlers.Remove(value);
            }
        }

        

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isPressed = true;
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                this.Name = value;
                base.Text = value;
            }
        }


    }
}
