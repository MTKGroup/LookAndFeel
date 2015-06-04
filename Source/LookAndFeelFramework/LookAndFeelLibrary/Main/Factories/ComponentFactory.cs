
using LookAndFeel.Components;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Factories{
    /**
     * 
     */
    public abstract class ComponentFactory {
        protected List<IComponent> samples;

        /**
         * We initalized this.samples in here. So derived class don't have to initalize it anymore.
         */
        public ComponentFactory()
        {
            samples = new List<IComponent>();
        }

        /**
         * Derived class don't have to implement this
         * @param type 
         * @return
         */
        public IComponent create(String type, ComponentInfo info) {
            foreach (var c in samples)
            {
                if (c.getType().ToLower().Equals(type.ToLower()))
                    return c.clone(info);
            }
            return null;
        }



    }
}
