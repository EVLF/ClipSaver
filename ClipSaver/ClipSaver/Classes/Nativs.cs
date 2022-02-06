using Microsoft.VisualBasic;
using System;

using System.Runtime.InteropServices;

namespace ClipSaver
{
    class Nativs
    {


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
