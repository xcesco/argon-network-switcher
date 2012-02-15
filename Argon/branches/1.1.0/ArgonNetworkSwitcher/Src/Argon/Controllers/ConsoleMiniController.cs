using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows.Forms;
using System.Runtime.InteropServices;
using Argon.Models;

namespace Argon.Controllers
{        

    public class ConsoleMiniController : MiniController
    {
        /// <summary>
        /// 
        /// </summary>
        protected FormConsole _viewConsole;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleMiniController"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        internal ConsoleMiniController(Controller controller) : base(controller)
        {
            _viewConsole = ViewModel.ConsoleView;            
        }


        
    }
}
