
using LookAndFeel.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls{
    /**
     * 
     */
    public delegate void ClickHandler(object sender);
    public interface IControl : IComponent {


        event ClickHandler ClickListener;

    }
}
