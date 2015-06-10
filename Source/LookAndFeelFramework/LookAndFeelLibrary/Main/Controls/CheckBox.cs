using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public abstract class CheckBox : MetroFramework.Controls.MetroCheckBox, IControl
    {
        public CheckBox()
        {
        }

        /**
         * @return
         */
        public String getType() {
            return "CheckBox";
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
    }
}
