using System;
using System.Windows.Forms;

namespace BT5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Luôn bật kiểm tra truy cập Control sai luồng (mặc định chỉ bật khi Debug F5)
            Control.CheckForIllegalCrossThreadCalls = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmIoTMonitor());
        }
    }
}
