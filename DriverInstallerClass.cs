using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using xOSaClientNetLib;

namespace SetThisUp
{
    class DriverInstallerClass
    {


        public static void CopyInstallDriver(TextBox ip_address,string TargetAddress,TextBox platform_username)
        {

            if (ip_address.Text == "" || ip_address.Text == null)
            {
                MessageBox.Show("choose Driver* or Uncheck in First Level");
                return;
            }


            Thread th1 = new Thread(() => MakeConnectionusingThread(TargetAddress, ip_address, platform_username));
            th1.Start();

        }

        //make it -1 or 0
        private static void MakeConnectionusingThread(string TargetAddress, TextBox ip_address,TextBox platform_username)
        {
            try
            {

                using (XosaClient xox = new XosaClient(TargetAddress))
                {

                    string pathToDriver = ip_address.Text;


                    string DriverPathParent = GetParent(pathToDriver);
                    if (DriverPathParent == "")
                    {//Path is wrong privide
                        MessageBox.Show("Path is wrong, please provide a suitable driver");
                    }
                    else
                    {
                        string[] words=DriverPathParent.Split('\\');
                        string myPathtoExecute;
                        if (words.Length > 4)
                            myPathtoExecute = @"C:\Users\" + platform_username.Text + @"\Desktop\" + words[words.Length - 4];
                        else
                            myPathtoExecute = @"C:\Users\" + platform_username.Text + @"\Desktop\" + words[0];

                        xox.File.CreateDirectory(myPathtoExecute);
                        xox.File.Upload(DriverPathParent, myPathtoExecute);

                        //install driver after copying
                        //INSTALLING...

                        new DownloaderThread("", platform_username);
                        //xox.RunCommand(myPathtoExecute+@"\SetupME.exe"); 
                        //Cli DowProc = xox.RunCommand(myPathtoExecute + @"\SetupME.exe" , new[] { "/s", "/v" ,"/qn" ,"/min" }, myPathtoExecute);
                        //xox.RunCommand("CMD.exe", new[] { myPathtoExecute + @"\SetupME.exe", "/s", "/v", "/qn", "/min" })
                        //Cli DowProc = xox.RunCommand( "CMD.exe", new[] { myPathtoExecute + @"\SetupME.exe", "/s", "/v", "/qn", "/min" }, myPathtoExecute);


                        MessageBox.Show("Driver Installed");





                    }




                }

            }
            catch (Exception)
            {
                MessageBox.Show("MakeConnectionusingThread:\nCant Connect to remote DUT\n make sure XOSA is installed\n make sure IP is configured");
                return;
            }
        }


        public static string GetParent(string path)
        {
            string ret = "";
            try
            {
                System.IO.DirectoryInfo directoryInfo =
                    System.IO.Directory.GetParent(path);

                ret = directoryInfo.FullName;

                System.Console.WriteLine(directoryInfo.FullName);
            }
            catch (ArgumentNullException)
            {
                System.Console.WriteLine("Path is a null reference.");
                return "";
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Path is an empty string, " +
                    "contains only white spaces, or " +
                    "contains invalid characters.");
                return "";
            }

            return ret;
        }

    }
}
