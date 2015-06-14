
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
    public abstract class GroupBox : System.Windows.Forms.GroupBox , IControl {
        protected HashSet<IControl> controls = new HashSet<IControl>();
        protected List<ClickHandler> clickHandlers = new List<ClickHandler>();
        protected ComponentInfo info;
        /**
         * 
         */
        public GroupBox() {
        }

        public GroupBox(ComponentInfo info)
        {
            this.info = info.clone();
            this.Top = info.Y;
            this.Left = info.X;
            this.Name = this.Text = info.Name;
            this.Width = info.Width != 0 ? info.Width : this.Width;
            this.Height = info.Height != 0 ? info.Height : this.Height;
            info.Width = info.Width != 0 ? info.Width : this.Width;
            info.Height = info.Height != 0 ? info.Height : this.Height;

            this.ParentChanged += (sender, e) => {
                                        var parent =  ((GroupBox)sender).Parent;
                                        if (parent != null) 
                                        {
                                            BackColor = parent.BackColor;
                                            ForeColor = parent.ForeColor;
                                        }
                                    };
        }


        

        public event ClickHandler ClickListener
        {
            add
            {
                this.clickHandlers.Add(value);
            }
            remove
            {
                this.clickHandlers.Remove(value);
            }
        }

        /**
         * @param f 
         * @return
         */
        public IComponent convert(ComponentFactory f) {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public abstract IComponent clone(ComponentInfo info);

        /**
         * @return
         */
        public String getType() {
            return "GroupBox";
        }

        public void addControl(IControl component)
        {
            this.controls.Add(component);
            this.Controls.Add((System.Windows.Forms.Control)component);
        }

        

    }
}
