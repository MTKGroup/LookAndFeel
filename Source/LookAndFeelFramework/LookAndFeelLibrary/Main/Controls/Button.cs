
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
        protected List<ClickHandler> clickHandlers;

        /**
         * 
         */
        public Button() {
            this.clickHandlers = new List<ClickHandler>();
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
            var info = new ComponentInfo();
            return f.create(this.getType(), info);    
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

    }
}
