using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argon.Common
{    
        public class NotifyEventArgs : EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="NotifyEventArgs"/> class.
            /// </summary>
            /// <param name="description">The description.</param>
            /// <param name="error">if set to <c>true</c> [error].</param>
            public NotifyEventArgs(string description, bool error=false)
            {
                Description = description;
                Percentage = 100;
                Error = error;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="NotifyEventArgs"/> class.
            /// </summary>
            /// <param name="description">The description.</param>
            /// <param name="percentage">The percentage.</param>
            /// <param name="error">if set to <c>true</c> [error].</param>
            public NotifyEventArgs(string description, int percentage, bool error=false)
            {
                Description = description;
                Percentage = percentage;
                Error = error;
            }

            public int Percentage { get; set; }

            public string Description { get; set; }

            public bool Error { get; set; }
        }
}
