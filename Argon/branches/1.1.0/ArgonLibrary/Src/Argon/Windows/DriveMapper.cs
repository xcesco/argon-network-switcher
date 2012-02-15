using System;
using System.Collections.Generic;
using System.Text;

namespace Argon.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public class DriveMapManager
    { 

        /// <summary>
        /// Applies the specified mapping list.
        /// </summary>
        /// <param name="mappingList">The mapping list.</param>
        public static void Apply(List<DriveMap> mappingList)
        {
            foreach (DriveMap item in mappingList)
            {
                Apply(item);
            }

        }

        /// <summary>
        /// Applies the specified mapping.
        /// </summary>
        /// <param name="mapping">The mapping.</param>
        /// <returns></returns>
        public static bool Apply(DriveMap mapping)
        {
            bool bRet = false;
            if (mapping.Type == DriveMapType.MOUNT)
            {                
                Unmount(mapping);
                bRet=Mount(mapping);
            }
            else
            {
                bRet=Unmount(mapping);
            }

            return bRet;
        }

        /// <summary>
        /// Maps the specified mapping.
        /// 
        /// 
        /// </summary>
        /// <param name="mapping">The mapping.</param>
        /// <returns></returns>
        public static bool Mount(DriveMap mapping)
        {
            //net use z: \\127.0.0.1\c$  3dylan3dog3 /USER:insiel\908099 /PERSISTENT:NO

            String temp="";

            if (mapping.Drive.Length>0)
            {
                temp+=mapping.Drive+" ";
            }

            if (mapping.RealPath.Length > 0)
            {
                string sTemp = mapping.RealPath.Trim();
                if (!sTemp.StartsWith(@"\\"))
                {
                    sTemp = @"\\" + sTemp;
                }
                
                temp+=""+sTemp+" ";
            }

            if (mapping.Username.Length > 0)
            {
                string pwd = mapping.Password;
                if (pwd != null)
                {
                    temp +=pwd + " ";
                }
                temp += "/USER:";
                temp+=mapping.Username + " ";
            }

            temp += "/PERSISTENT:NO";

            return WindowsExecutor.Execute("net", " use " + temp);            
        }

        /// <summary>
        /// Unmounts the specified map.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public static bool Unmount(DriveMap map)
        {
            // net use /DELETE z:
            return WindowsExecutor.Execute("net", " use /DELETE "+map.Drive);            
        }

        /// <summary>
        /// Tests the specified map.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public static bool Test(DriveMap map)
        {
            bool ret = true;
            ret=ret && Mount(map);
            ret=ret && Unmount(map);
            return ret;
        }
    }
}
