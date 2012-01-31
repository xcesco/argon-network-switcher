using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceProcess;

namespace Argon.OperatingSystem
{
    /// <summary>
    /// Indiica lo stato in cui si desidera che il controller sia.
    /// </summary>
    public enum ServiceForcedStatus
    {
        /// <summary>
        /// In esecuzione
        /// </summary>
        RUNNING,
        /// <summary>
        /// Bloccato
        /// </summary>
        STOPPED,
        /// <summary>
        /// Indifferente, ovvero rimane com'e'
        /// </summary>
        NONE

    }
}
