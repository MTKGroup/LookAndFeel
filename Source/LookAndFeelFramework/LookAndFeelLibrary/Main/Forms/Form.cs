
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
        /**
         * 
         */
        public Form() {
            this.controls = new HashSet<IControl>();
        }

        /**
         * 
         */
        protected HashSet<IControl> controls;

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
    }
}