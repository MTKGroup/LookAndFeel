
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Components{
    /**
     * 
     */
    public interface IComponent {

        /**
         * @return
         */
        IComponent clone(ComponentInfo info);

        /**
         * @return
         */
        String getType();

        /**
         * @param f 
         * @return
         */
        IComponent convert(ComponentFactory f);


    }
}
