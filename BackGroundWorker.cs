using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

//To delete this file
namespace SetThisUp
{
    class BackGroundInstaller: BackgroundWorker
    {

       
            //to start worker backgroundWorker1.RunWorkerAsync();
        
        public BackGroundInstaller()
        {
            this.DoWork += backgroundWorker1_DoWork;
            this.ProgressChanged += backgroundWorker1_ProgressChanged;
            this.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.Arguments = "/s /v /qn /min";
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = @"C:\Users\Administrator\Desktop\DriverMe\SetupME.exe";
            psi.UseShellExecute = false;
            System.Diagnostics.Process.Start(psi);


        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

    }
}
