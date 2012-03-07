using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
namespace Argon.Common
{
    public class NotifyEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyEventArgs"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="error">if set to <c>true</c> [error].</param>
        public NotifyEventArgs(string description, bool error = false)
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
        public NotifyEventArgs(string description, int percentage, bool error = false)
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
