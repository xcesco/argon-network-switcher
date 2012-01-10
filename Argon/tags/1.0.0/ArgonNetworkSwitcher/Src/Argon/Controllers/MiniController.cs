using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Controllers;

namespace Argon.Controllers
{
    public abstract class MiniController
    {
        protected Controller _controller;

        internal MiniController(Controller controller)
        {
            _controller = controller;
        }

    }
}
