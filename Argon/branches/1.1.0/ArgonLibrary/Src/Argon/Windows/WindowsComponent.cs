using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Argon.Windows
{
    /// <summary>
    /// Base class for component defined in library
    /// </summary>
    [Serializable]
    public abstract class WindowsComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsComponent"/> class.
        /// </summary>
        public WindowsComponent()
        {
            _name = "";
            _description = "";
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _name;

        /// <summary>
        /// 
        /// </summary>
        protected string _description;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}
