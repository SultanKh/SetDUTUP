using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using xOSaClientNetLib;

namespace SetThisUp
{



    class MotorAutoSetup
    {

        private string Target_ip ="";

        //at first static oublic then to private part of object

        public MotorAutoSetup(string target_ip)
        {
            this.Target_ip = target_ip ;
          

        }


        private void setSettingsNowThread()
        {
            try
            {



                using (XosaClient xox = new XosaClient(this.Target_ip))
                {
                    var command = new XosaClient.RunCommandParameters();
                    Cli command_proc;

                    command.Command = "powercfg";
                    command.IsGui = false;

                    command.Args = new[] { "/DEVICEDISABLEWAKE", "HID-compliant mouse" };
                    command.IsGui = false;

                    command_proc = xox.RunCommand(command);
                    command_proc.WaitForExit(10);
                    string tmp = "";
                    command_proc.ReadStdOut(out tmp);

                    //8***** Next device

                    command.Args = new[] { "/DEVICEDISABLEWAKE", "Intel(R) Dual Band Wireless-AC 8265" };
                    command_proc = xox.RunCommand(command);
                    command_proc.WaitForExit(10);

                    command_proc.ReadStdOut(out tmp);

                    ////****** Next device Intel(R) Ethernet Connection (2) 1219-LM
                    command.Args = new[] { "/DEVICEDISABLEWAKE", "Intel(R) Ethernet Connection (2) I219-LM" };
                    command_proc = xox.RunCommand(command);
                    command_proc.WaitForExit(10);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("DUT Configs: cant make connection, Check DUT has IP and in S0 State and has Xosa installed");
                return;
            }

        }

        public void SetSettup()
        {
            Thread th1 = new Thread(() => setSettingsNowThread());
            th1.Start();
            th1.Join();

        }

        public void makeServiceAuto()
        {

        }

        public static void SetSettupStatic(string targetIP)
        {


        }















        public string GetTargetIP()
        {
            return Target_ip;
        }


        //give permision to folder
        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));

            dInfo.SetAccessControl(dSecurity);
        }

        private void DownloadIt()
        {

        }


    }
}
