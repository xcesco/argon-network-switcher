using System;
using System.Collections.Generic;
using System.Text;

namespace Argon.Windows.Forms
{
    /// <summary>
    /// Rapresents the set of views.
    /// </summary>
    public class ViewRender
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="View"/> class.
        /// </summary>
        public ViewRender()
        {            
            _viewMain = new FormMain();
            _viewAdapters = new FormNetworkCards();
            _viewProfiles = new FormProfiles();
            _viewConsole = new FormConsole();

            _listViewCardInfo = new List<FormNetworkCard>();
            _listViewProfile = new List<FormProfile>();

            _toolStripButtonManager = new ToolStripButtonManager(_viewMain);
        }
        #endregion

        #region Attributes
        protected FormConsole _viewConsole;
        protected FormProfile _currentFormProfile;
        protected FormNetworkCard _currentFormNetworkCard;
        protected FormMain _viewMain;
        protected FormNetworkCards _viewAdapters;
        protected FormProfiles _viewProfiles;
        protected List<FormProfile> _listViewProfile;
        protected List<FormNetworkCard> _listViewCardInfo;

        private ToolStripButtonManager _toolStripButtonManager;

        #endregion

        #region Methods

        public FormProfile CurrentFormProfile
        {
            get { return _currentFormProfile; }
            set { _currentFormProfile = value; }
        }

        public FormNetworkCard CurrentFormCardInfo
        {
            get { return _currentFormNetworkCard; }
            set { _currentFormNetworkCard = value; }
        }

        public FormConsole ViewConsole
        {
            get { return _viewConsole; }
            set { _viewConsole = value; }
        }

        public FormMain ViewMain
        {
            get { 
                return _viewMain; 
            }
            set { 
                _viewMain = value; 
            }
        }

        public FormProfiles ViewProfiles
        {
            get { return _viewProfiles; }
            set { _viewProfiles = value; }
        }

        public FormNetworkCards ViewAdapters
        {
            get { return _viewAdapters; }
            set { _viewAdapters = value; }
        }


        public List<FormProfile> ListViewProfile
        {
            get { return _listViewProfile; }
        }

        public List<FormNetworkCard> ListViewCardInfo
        {
            get { return _listViewCardInfo; }
        }

        public ToolStripButtonManager ToolStripButtonManager
        {
            get { return _toolStripButtonManager; }            
        }

        #endregion
    }
}
