using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using xOSaClientNetLib;
namespace SetThisUp
{
    public partial class Form1 : Form
    {

        const string SharedFolderAddress = "\\\\10.12.215.43";
        string TargetAddress;

        XmlDocument docConfiguration;
        XmlNodeList aNodes;
        XmlNodeList runits;

        private readonly SynchronizationContext syncMyShit;
        private DateTime dt = DateTime.Now;


        public Form1()
        {
            InitializeComponent();


         



            //load Configuration for future editng
            docConfiguration = new XmlDocument();

            docConfiguration.Load(Environment.CurrentDirectory + @"\pmsp_files\UserFiles\Configuration\DefaultConfiguration.xml");
            aNodes = docConfiguration.SelectNodes("Configuration/HostConfig/*");
            runits = docConfiguration.SelectNodes("Configuration/RunConfig/*");

            syncMyShit = SynchronizationContext.Current;

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ImageBurnClass imageOnFire = new ImageBurnClass(openFileDialog1.FileName);
            Thread _th = new Thread(() => SetACDCWithThread(imageOnFire));
            _th.Start();

        }

        private void SetG3WithThread(ImageBurnClass imageOnFire)
        {

            //g3 machine
            try
            {
                imageOnFire.StateToG3MUDI();
                dutstate.Text = "Machine in G3";
                dutstate.Visible = true;
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't G3:\n" + ex.Message);
                dutstate.Text = "Check APS connection or APS confiuration";
                dutstate.Visible = true;

                return;
            }

        }
        private void SetACDCWithThread(ImageBurnClass imageOnFire)
        {
            try
            {
                imageOnFire.StateToAcdcMUDI();

                Thread.Sleep(5000);

                dutstate.Text = "Machine in S0";
                dutstate.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("can't acdc:\n check APS connection");
                dutstate.Text = "Check APS connection or APS confiuration";
                dutstate.Visible = true;

            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ImageBurnClass imageOnFire = new ImageBurnClass(openFileDialog1.FileName);
            Thread _th = new Thread(() => SetG3WithThread(imageOnFire));
            _th.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region TreeView INIIT
            /*
             * init TreeView
             */
            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory + @"\pmsp_files\UserFiles\Scripts");
            if (directoryInfo.Exists)
            {
                try
                {
                    treeView1.Nodes.Add(directoryInfo.Name);
                    DirectoryInfo[] directories = directoryInfo.GetDirectories();

                    foreach (FileInfo file in directoryInfo.GetFiles())
                    {
                        if (file.Exists)
                        {
                            TreeNode nodes = treeView1.Nodes[0].Nodes.Add(file.Name);
                        }
                    }


                    if (directories.Length > 0)
                    {
                        foreach (DirectoryInfo directory in directories)
                        {
                            TreeNode node = treeView1.Nodes[0].Nodes.Add(directory.Name);
                            node.ImageIndex = node.SelectedImageIndex = 0;
                            foreach (FileInfo file in directory.GetFiles())
                            {
                                if (file.Exists)
                                {
                                    TreeNode nodes = treeView1.Nodes[0].Nodes[node.Index].Nodes.Add(file.Name);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            #endregion


            #region display data to save time on hostconfig

            DisappearErrorMsg();
            dutIP.Text = aNodes[0].InnerText;
            platform.SelectedIndex = 1;
            platformType.SelectedIndex = 2;
            ppolicy.SelectedIndex = 1;
            sku.SelectedIndex = 1;

            platform_username.Text = aNodes[10].ChildNodes[0].InnerText;
            platform_userpass.Text = aNodes[10].ChildNodes[1].InnerText;

            me_name.Text = aNodes[11].FirstChild.InnerText;
            me_pass.Text = aNodes[11].LastChild.InnerText;
            numericUpDown1.Value = Convert.ToDecimal(runits[0].InnerText);

            TargetAddress = string.Format("{0}:6500", dutIP.Text);


            #endregion

        }




        #region TREEVIEW Things

        /*
     * START
     * <comment> section for tree view
     * START
     */

        //related to tree view


        bool busy = false;

        private void checkNodes(TreeNode node, bool check)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = check;
                checkNodes(child, check);
            }
        }

        private void treeView1_AfterCheck_1(object sender, TreeViewEventArgs e)
        {
            if (busy) return;
            busy = true;
            try
            {
                checkNodes(e.Node, e.Node.Checked);
            }
            finally
            {
                busy = false;
            }


        }

        #endregion



#region RUN Scripts Third TAB
        private void run_script_Click(object sender, EventArgs e)
        {
            // Creates and initializes a new Queue.

            TreeNodeCollection nodes = treeView1.Nodes[0].Nodes[0].Nodes;

            Queue<string> myQTest = new Queue<string>();

            
            foreach (TreeNode n in nodes)
            {
                if (n.Checked)
                {
                    myQTest.Enqueue(n.FullPath);
                }

            }
            if (myQTest.Count == 0)
            {
                return;
            }


            
            runits[0].InnerText = numericUpDown1.Value.ToString();
            docConfiguration.Save(Environment.CurrentDirectory + @"\pmsp_files\UserFiles\Configuration\DefaultConfiguration.xml");


    


            TestFlowRunner.RunMyTest(myQTest);
            TestFlowRunner.ResultOnTable(table_ressults);


        }

        /*
         * 
         * HERE WE RUN TEST
         */


        #endregion





















        private void saveSettings_Click(object sender, EventArgs e)
        {


            //0:<IpAddress>   2<FwSkuType> 4<PlatformVersion>   5<PlatformType>  8<PowerPolicyState>  
            /*
             *     9<PlatformAccount>
                        <UserName>Administrator</UserName>
                        <Password>P@ssw0rd</Password>
                   </PlatformAccount>
                   10<MeAccount>
                        <UserName>admin</UserName>
                        <Password>Admin!98</Password>
                   </MeAccount>
             * 
             */

            //HOSTConfiguration
            //XmlNodeList aNodes = docConfiguration.SelectNodes("Configuration/HostConfig/*");


            //IP Modifying

            SaveSettings.SaveAllSettings(aNodes, errorMsg, errorMsg2, errorMsg3, provision, dutIP, platform, platformType, sku, ppolicy, platform_username, platform_userpass, me_name, me_pass);

            // save the XmlDocument back to disk
            docConfiguration.Save(Environment.CurrentDirectory + @"\pmsp_files\UserFiles\Configuration\DefaultConfiguration.xml");




        }

        #region validate User Input


        #endregion

        #region PING click

        private void pint_dut_Click(object sender, EventArgs e)
        {
            //must see full results
            string strCmdText;
            strCmdText = string.Format("/K ping  {0} -t", dutIP.Text);

            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
            //processInfo.Verb = "runas";

            processInfo.Arguments = strCmdText;
            System.Diagnostics.Process.Start(processInfo);



        }

        #endregion

        private void DisappearErrorMsg()
        {
            //

            errorMsg.Visible = false;
            errorMsg2.Visible = false;
            errorMsg3.Visible = false;
            
        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }















#region First Level

        //Image Burn
        private void imageBurn_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                // MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }

            textBox1.Text = openFileDialog1.FileName;
            if (!openFileDialog1.FileName.EndsWith(".bin"))
            {
                MessageBox.Show("un authorized file");
                return;
            }


            string cons="Consumer", slim = "Slim";
            if(textBox1.Text.Contains(cons) || textBox1.Text.Contains(slim))
            {
                provision.Enabled = false;
            }

      

        }

        //Driver Path
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                sr.Close();
            }


            ip_address.Text = openFileDialog1.FileName;
            string DriverPathParent = DriverInstallerClass.GetParent(openFileDialog1.FileName);
            if (DriverPathParent == "")
            {//Path is wrong privide
                return;
            }



        }


        private void RunG3BurnImageWithThread(ImageBurnClass imageOnFire)
        {
            try
            {
                Thread _th = new Thread(() => imageOnFire.PreSetupBurnThatImage());
                _th.Start();
                _th.Join();

                
            }
            catch (Exception)
            {
                return;
            }

        }
        //Burn Image Install Driver
        private void setup_Click(object sender, EventArgs e)
        {
            ImageBurnClass imageOnFire = new ImageBurnClass(textBox1.Text);

            #region Burning Image

            if (checkImage.Checked)
            {
                if (textBox1.Text == "" || textBox1.Text == null)
                {
                    return;
                }





                 RunG3BurnImageWithThread(imageOnFire);


                
                //sleep...Waake
                Thread.Sleep(20000);
                imageOnFire.StateToAcdcUsingScript();
                Thread.Sleep(20000);
                this.logs.Text += "\n Finish Burning Image";

            }
            #endregion






            //Driver Installer
            #region DriverInstaller
            if (checkDriver.Checked)
            {
                //make it thread.... and fast
                //Thread _th3 = new Thread(() => DriverInstallerClass.CopyInstallDriver(ip_address, TargetAddress, platform_username));
                //_th3.Start();
                MessageBox.Show(TargetAddress);
                DriverInstallerClass.CopyInstallDriver(ip_address, TargetAddress, platform_username);

                
                return;

            }
            #endregion
            #region provision Program
            //copy files

            //run script
            #endregion


            
            #region Dut general setup
            MotorAutoSetup mt = new MotorAutoSetup(dutIP.Text);
            mt.SetSettup();
            #endregion
            



        }

        #endregion









        private void sku_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)sku.SelectedItem,cons="Consumer";

            if (selected == cons)
            {
                ppolicy.SelectedIndex = 1;
                ppolicy.Enabled = false;
            }
            else
            {
                ppolicy.Enabled = true;
            }

        }
























        private void runall_Click(object sender, EventArgs e)
        {

            //****************************** First Level ***************************************
            if (firstLevel.Checked)
            {

                if (textBox1.Text == "" || textBox1.Text == null)
                {
                    MessageBox.Show("choose image* or Uncheck in First Level");
                    return;
                }

                ImageBurnClass imageOnFire = new ImageBurnClass(textBox1.Text);


                #region Burning Image

                if (checkImage.Checked)
                {

                    //Set Machine to G3
                    textBox1.Text = openFileDialog1.FileName;
                    try
                    {
                        imageOnFire.StateToG3UsingScript();
                        Thread.Sleep(5000);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("can't G3:\n" + ex.Message);
                        return;
                    }
                    //========================================               ======================================
                    //======================================== Burning image ======================================
                    //========================================               ======================================
                    try
                    {
                        imageOnFire.BurnThatImage();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("can't burn image:\n" + ex.Message);
                        return;

                    }
                }
                #endregion

                //sleep...Waake
                Thread.Sleep(5000);
                imageOnFire.StateToAcdcUsingScript();
                Thread.Sleep(5000);

                //Driver Installer
                #region DriverInstaller
                if (checkDriver.Checked)
                {
                    MessageBox.Show(TargetAddress);

                    DriverInstallerClass.CopyInstallDriver(ip_address, TargetAddress, platform_username);

                }
                #endregion



                #region Dut general setup
                MotorAutoSetup mt = new MotorAutoSetup(dutIP.Text);
                mt.SetSettup();
                #endregion

            }


            //***********************************************************************************




            //*********************************Socend Level**************************************************


            if (twoLevel.Checked)
            {
                SaveSettings.SaveAllSettings(aNodes, errorMsg, errorMsg2, errorMsg3, provision, dutIP,
                    platform, platformType, sku, ppolicy, platform_username, platform_userpass, me_name, me_pass);
            }


            //***********************************************************************************


            //***********************************Third Level*************************************

            // Creates and initializes a new Queue.

            if (testflow.Checked)
            {
                TreeNodeCollection nodes = treeView1.Nodes[0].Nodes[0].Nodes;

                Queue<string> myQTest = new Queue<string>();


                foreach (TreeNode n in nodes)
                {
                    if (n.Checked)
                    {
                        myQTest.Enqueue(n.FullPath);
                    }

                }
                if (myQTest.Count == 0)
                {
                    return;
                }


                //Save Iterations
                runits[0].InnerText = numericUpDown1.Value.ToString();
                docConfiguration.Save(Environment.CurrentDirectory + @"\pmsp_files\UserFiles\Configuration\DefaultConfiguration.xml");


                //Start Running Test
                TestFlowRunner.RunMyTest(myQTest);
            }






            //***********************************************************************************
        }
    }

}
