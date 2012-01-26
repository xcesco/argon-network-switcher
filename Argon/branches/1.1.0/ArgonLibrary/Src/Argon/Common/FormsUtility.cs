using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Argon.Common
{

    public abstract class FormsUtility
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();

        public static void SetMovable(IntPtr Handle)
        {
            FormsUtility.ReleaseCapture();
            FormsUtility.SendMessage(Handle, FormsUtility.WM_NCLBUTTONDOWN, FormsUtility.HT_CAPTION, 0);
        }

    }
}
