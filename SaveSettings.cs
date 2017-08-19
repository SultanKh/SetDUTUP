using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SetThisUp
{
    class SaveSettings
    {
        public SaveSettings(XmlNodeList aNodes)
        {

        }
        public static void SaveAllSettings(XmlNodeList aNodes,Label errorMsg,Label errorMsg2, Label errorMsg3, CheckBox provision, TextBox dutIP, ComboBox platform
            , ComboBox platformType, ComboBox sku, ComboBox ppolicy,TextBox platform_username,TextBox platform_userpass, TextBox me_name,TextBox me_pass)
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
            string NewtValue;//0
            NewtValue = dutIP.Text;
            //Validate IP
            if (ValidateIPv4(NewtValue) == false)
            {
                errorMsg.Visible = true;
                errorMsg.Text = "**write correct IP";
                return;

            }
            //----------------------------------------------------------------


            string Newtplatform;//4
            Newtplatform = platform.Text;
            if (Newtplatform == "" || (Newtplatform != "KabyLake" && Newtplatform != "CanonLake" && Newtplatform != "IceLake"))
            {
                errorMsg3.Text = "Choose platform*";
                errorMsg3.Visible = true;
                return;
            }


            //----------------------------------------------------------------

            string NewtplatformType; //5
            NewtplatformType = platformType.Text;
            if (NewtplatformType == "" || (!NewtplatformType.Equals("Mobile") && !NewtplatformType.Equals("Desktop")))
            {
                errorMsg2.Visible = true;
                errorMsg2.Text = "Choose Type";
                return;
            }


            //----------------------------------------------------------------
            string Newtsku;//2
            Newtsku = sku.Text;
            if (Newtsku == "" || (!Newtsku.Equals("Consumer") && !Newtsku.Equals("Corporate")))
            {
                Newtsku = "Consumer";
            }
            if (Newtsku.Equals("Consumer"))
            {
                ppolicy.SelectedText = "PowerPolicy1";
                ppolicy.Enabled = false;
            }
            else
            {
                ppolicy.Enabled = true;

            }

            //----------------------------------------------------------------

            string Newpp; //8
            Newpp = ppolicy.Text;
            if (Newpp == "" || Newpp == null)
            {
                Newpp = "PowerPolicy1";
            }

            //----------------------------------------------------------------
            string Newplatformname = "";
            Newplatformname = platform_username.Text;
            if (Newplatformname == "" || Newplatformname == null)
            {
                return;
            }

            string Newplatformpass = "";
            Newplatformpass = platform_userpass.Text;
            if (Newplatformpass == "" || Newplatformpass == null)
            {
                return;
            }
            //----------------------------------------------------------------

            string NewMe_name = "";
            NewMe_name = me_name.Text;
            if (NewMe_name == "" || NewMe_name == null)
            {
                return;
            }

            string NewMe_pass = "";
            NewMe_pass = me_pass.Text;
            if (NewMe_pass == "" || NewMe_pass == null)
            {
                return;
            }


            //----------------------------------------------------------------
            //Save stuff
            aNodes[0].InnerText = NewtValue;
            aNodes[2].InnerText = Newtsku;
            aNodes[4].InnerText = Newtplatform;
            aNodes[5].InnerText = NewtplatformType;
            aNodes[8].InnerText = Newpp;

            aNodes[10].FirstChild.InnerText = Newplatformname;
            aNodes[10].LastChild.InnerText = Newplatformpass;


            aNodes[11].FirstChild.InnerText = NewMe_name;
            aNodes[11].LastChild.InnerText = NewMe_pass;

            if (provision.Checked)
            {

                aNodes[12].InnerText = "true";

            }
            else
            {
                aNodes[12].InnerText = "false";
            }



            // save the XmlDocument back to disk
        }



        #region validate User Input
        private static bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }


        #endregion

    }
}
