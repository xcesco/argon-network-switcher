using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows.Forms;
using System.Runtime.InteropServices;

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
            _viewConsole = controller.View.ViewConsole;            
        }


        /// <summary>
        /// Infoes the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void Info(string msg)
        {
            string temp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - INFO - " + msg;
            _viewConsole.AddText(temp);
            
        }

        /// <summary>
        /// Errors the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void Error(string msg)
        {
            string temp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - ERR  - " + msg;
            _viewConsole.AddText(temp);          
        }
    }
}
