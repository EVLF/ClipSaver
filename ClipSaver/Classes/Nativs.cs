using Microsoft.VisualBasic;
using System;

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipSaver
{
    class Nativs
    {
        #region ShowInactiveTopmost
        private const int SW_SHOWNOACTIVATE = 4;
        private const int HWND_TOPMOST = -1;
        private const uint SWP_NOACTIVATE = 0x0010;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(
         int hWnd,             // Window handle
         int hWndInsertAfter,  // Placement-order handle
         int X,                // Horizontal position
         int Y,                // Vertical position
         int cx,               // Width
         int cy,               // Height
         uint uFlags);         // Window positioning flags

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

       public static void ShowInactiveTopmost(Form frm)
        {
            ShowWindow(frm.Handle, SW_SHOWNOACTIVATE);
            SetWindowPos(frm.Handle.ToInt32(), HWND_TOPMOST,
            frm.Left, frm.Top, frm.Width, frm.Height,
            SWP_NOACTIVATE);
        }
        #endregion

        #region Hookkeyb

        public class KeyHandler
        {
            [DllImport("user32.dll")]
            private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
            [DllImport("user32.dll")]
            private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

            private int modifier;
            private int key;
            private IntPtr hWnd;
            private int id;
            public KeyHandler(int modifier, Keys key, Form form)
            {
                this.modifier = modifier;
                this.key = (int)key;
                this.hWnd = form.Handle;
                id = this.GetHashCode();
            }
            public override int GetHashCode()
            {
                return modifier ^ key ^ hWnd.ToInt32();
            }
            public bool Register()
            {
                return RegisterHotKey(hWnd, id, modifier, key);
            }
            public bool Unregiser()
            {
                return UnregisterHotKey(hWnd, id);
            }
        }
        #endregion

        #region hookclipb
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        #endregion

        #region windowtitle
        public static string GetForegroundWindowTitle()
        {
            string result;
            try
            {

                IntPtr foregroundWindow = GetForegroundWindow();
                if (foregroundWindow == IntPtr.Zero)
                {
                    result = "";
                }
                else
                {
                    string text = "";
                    try
                    {
                        text = Strings.Space(checked(GetWindowTextLength((long)foregroundWindow) + 1));


                    }
                    catch (Exception e) { }
                    GetWindowText(foregroundWindow, ref text, text.Length);
                    result = text;
                }
            }
            catch { result = ""; }
            return result;
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextLengthA", ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowTextLength(long hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        #endregion

        #region clipboared


        public static class ClipboardCom
        {
            [DllImport("user32.dll")]
            static extern IntPtr GetClipboardData(uint uFormat);
            [DllImport("user32.dll")]
            static extern bool IsClipboardFormatAvailable(uint format);
            [DllImport("user32.dll", SetLastError = true)]
            static extern bool OpenClipboard(IntPtr hWndNewOwner);
            [DllImport("user32.dll", SetLastError = true)]
            static extern bool CloseClipboard();
            [DllImport("kernel32.dll")]
            static extern IntPtr GlobalLock(IntPtr hMem);
            [DllImport("kernel32.dll")]
            static extern bool GlobalUnlock(IntPtr hMem);

            const uint CF_UNICODETEXT = 13;

            public static string GetText()
            {
                if (!IsClipboardFormatAvailable(CF_UNICODETEXT))
                    return null;
                if (!OpenClipboard(IntPtr.Zero))
                    return null;

                string data = null;
                var hGlobal = GetClipboardData(CF_UNICODETEXT);
                if (hGlobal != IntPtr.Zero)
                {
                    var lpwcstr = GlobalLock(hGlobal);
                    if (lpwcstr != IntPtr.Zero)
                    {
                        data = Marshal.PtrToStringUni(lpwcstr);
                        GlobalUnlock(lpwcstr);
                    }
                }
                CloseClipboard();

                return data;
            }
        }
        #endregion
    }
}
