using APSCommon.Drivers;
using APSCommon.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SetThisUp
{
    // <info> "dpcmd.exe -u <file.bin>"
    class ImageBurnClass
    {
        private string image_path;

        public string MyImagePAth()
        {
            return image_path;
        }
       public ImageBurnClass(string image_path_file)
        {
            image_path = image_path_file;
        }

        public void BurnThatImage()
        {
            try
            {


                //must see full results
                string strCmdText;
                strCmdText = string.Format("/K {0} -u {1}", Environment.CurrentDirectory + @"\Dediprogfiles\dpcmd.exe", image_path);

                ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
                //processInfo.Verb = "runas";

                processInfo.Arguments = strCmdText;
                System.Diagnostics.Process.Start(processInfo);




                //---------------------------------------------------------------

                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = Environment.CurrentDirectory + @"\Dediprogfiles\dpcmd.exe";
                //startInfo.Arguments = "-u " + image_path;

                //startInfo.RedirectStandardOutput = true;
                //startInfo.UseShellExecute = true;

                //Process.Start(startInfo);
                

            }
            catch (Exception)
            {
                throw;
                
            }
        }

        public void PreSetupBurnThatImage()
        {
            //Set Machine to G3
            try
            {
                //StateToG3UsingScript();
                StateToG3MUDI();
                Thread.Sleep(5000);
                BurnThatImage();
            }
            catch (Exception)
            {
                MessageBox.Show("can't G3:\n check APS3");
                return;
            }
            //========================================               ======================================
            //======================================== Burning image ======================================
            //========================================               ======================================
          
               

        }

        public void StateToG3()
        {

            //State to G3   <<<<< does not work
            // IAPSDriver aps3 = APSDriverFactory.GetAPS3Driver();
            IAPSDriver aps3 = APSDriverFactory.GetAPS3Driver();



            APSConfiguration apsConfiguration = new APSConfiguration();
            apsConfiguration.PlatformType = PowerDataStructure.PlatformType.Mobile; // must change

            apsConfiguration.PlatformMappingTableDirectoryPath =Environment.CurrentDirectory + @"\PlatformMappings\"; //<<< ====================


            aps3.ConfigureAPS(apsConfiguration);
            if (!aps3.InitializeComponent())
            {
                throw new Exception("Faild to load APS3");
            }
            else
            {
                MessageBox.Show("Aps3 Intilize");
            }

            //aps3.SetPowerSource(PowerDataStructure.PowerSource.G3);



        }
        public void StateToG3UsingScript()
        {
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Program Files\Intel\Intel(R) Automated Power Switch Software\APS_Software.exe"; //must copy files
            p.StartInfo.Arguments = "g3";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();


        }

        public void StateToAcdcUsingScript()
        {

            Process p = new Process();
            p.StartInfo.FileName = @"C:\Program Files\Intel\Intel(R) Automated Power Switch Software\APS_Software.exe"; //must copy files
            p.StartInfo.Arguments = "acdc";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();


        }

        public void StateToAcdcMUDI()
        {

            Process p = new Process();
            
            p.StartInfo.FileName = @"C:\Program Files\Intel\Intel(R) Multi Devices Interface\MuDiSW\MuDi.Cli.exe"; //must copy files
            p.StartInfo.Arguments ="pwrctrl setpwrsrc acdc";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;


            p.Start();
            string output = p.StandardOutput.ReadToEnd();

           
        }

        public void StateToG3MUDI()
        {

            Process p = new Process();

            p.StartInfo.FileName = @"C:\Program Files\Intel\Intel(R) Multi Devices Interface\MuDiSW\MuDi.Cli.exe"; //must copy files

            p.StartInfo.Arguments = "pwrctrl setpwrsrc g3";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;


            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();
            string output = p.StandardOutput.ReadToEnd();


        }




    }
}
