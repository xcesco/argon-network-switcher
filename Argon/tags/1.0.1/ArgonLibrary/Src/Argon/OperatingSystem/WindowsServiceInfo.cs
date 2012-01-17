using System;
using System.Collections.Generic;
using System.Text;

namespace Argon.OperatingSystem
{
    /// <summary>
    /// 
    /// </summary>
    public class WindowsServiceInfoImpl : IWindowsServiceInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsServiceInfoImpl"/> class.
        /// </summary>
        public WindowsServiceInfoImpl()
        {
            _serviceName = "";
            _forcedStatus = ServiceForcedStatus.NONE;
        }

        public static WindowsServiceInfoImpl Copy(WindowsServiceInfoImpl obj)
        {
            return (WindowsServiceInfoImpl)obj.MemberwiseClone();
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _serviceName;

        /// <summary>
        /// 
        /// </summary>
        protected ServiceForcedStatus _forcedStatus;

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        /// <summary>
        /// Gets or sets the forced status.
        /// </summary>
        /// <value>The forced status.</value>
        public ServiceForcedStatus ForcedStatus
        {
            get { return _forcedStatus; }
            set { _forcedStatus = value; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IWindowsServiceInfo
    {
        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        string ServiceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the forced status.
        /// </summary>
        /// <value>The forced status.</value>
        ServiceForcedStatus ForcedStatus
        {
            get;
            set;
        }

    }
}
