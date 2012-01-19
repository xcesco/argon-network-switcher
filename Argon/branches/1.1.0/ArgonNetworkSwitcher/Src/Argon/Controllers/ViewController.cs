using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows.Forms;
using System.Windows.Forms;

namespace Argon.Controllers
{
    public class ViewController : MiniController
    {
        protected List<ToolStripButton> _listToolStripButton;

        protected ViewRender _view;

        public ViewController(Controller controller) : base(controller)
        {
            _view = controller.View;
        }
       
    }
}
