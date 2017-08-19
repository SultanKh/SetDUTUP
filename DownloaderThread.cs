using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SetThisUp
{
    class DownloaderThread
    {
        Thread th1;
        public DownloaderThread(TextBox platform_username)
        {
            //th1 = new Thread (() => ToDownloadDriver(""));
            //th1.Start();
            //th1.Join();
            ToDownloadDriver("", platform_username);


        }
        public DownloaderThread(string path_file,TextBox platform_username)
        {
            //th1 = new Thread(()=>ToDownloadDriver(path_file));
            //th1.Start();

            ToDownloadDriver(path_file, platform_username);

        }

        public void ToDownloadDriver(string path_file,TextBox platform_username)
        {
            if(path_file==null || path_file.ToString()=="")
                path_file=@"C:\Users\"+ platform_username.Text + @"\Desktop\DriverMe\SetupME.exe";


            //try
            //{


            //    ProcessStartInfo psi = new ProcessStartInfo();
            //    psi.Arguments = "/s /v /qn /min";
            //    psi.CreateNoWindow = true;
            //    psi.WindowStyle = ProcessWindowStyle.Hidden;
            //    psi.FileName = path_file;
            //    psi.UseShellExecute = false;
            //    System.Diagnostics.Process.Start(psi);
            //    MessageBox.Show("Finish Installing");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("DownloaderThread: Cant Install Driver...");

            //}

            //---------------------------------------------------------------------


            //must see full results
            //string strCmdText;
            //strCmdText = string.Format("/K {0} ", path_file);

            //ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
            ////processInfo.Verb = "runas";

            //processInfo.Arguments = strCmdText;
            //System.Diagnostics.Process.Start(processInfo);

            //-----------------------------------------------------------------------

            string ex1 = @"C:\Users\"+ platform_username.Text + @"\Desktop\DriverME";
            string ex2 = @"C:\Dir";

            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "SetupME.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }



        }

    }
}
