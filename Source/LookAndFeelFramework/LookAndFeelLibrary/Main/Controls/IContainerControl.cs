
using LookAndFeel.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls{
    /**
     * 
     */
    public interface IContainerControl : IControl {

        /**
         * @param c
         */
        void addChildren(IComponent c);

        /**
         * @return
         */
        IComponent[] getChildrens();

        /**
         * @param c
         */
        void removeChildren(IComponent c);

    }
}
