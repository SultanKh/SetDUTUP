﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace SetThisUp
{
    class TestFlowRunner
    {
        public TestFlowRunner()
        {

        }

        public static void RunMyTest(Queue<string> myQTest)
        {




            string mainWorkingDir = AppDomain.CurrentDomain.BaseDirectory;
            string stst = AppDomain.CurrentDomain.BaseDirectory + @"pmsp_files\";
            try
            {
                Directory.SetCurrentDirectory(stst);
            }
            catch (Exception)
            {
                MessageBox.Show("missign PMSP");

            }

            try
            {
                
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");

                    string strCmdText;
                    string executename = "PMSP.Cli.exe";
 

                while (myQTest.Count > 0)
                {

                    string xmlFilename = myQTest.Dequeue();



                    string TestFlowFromQ = "\"" + AppDomain.CurrentDomain.BaseDirectory + @"pmsp_files\UserFiles\" + xmlFilename + "\"";
                    strCmdText = string.Format("/K {0} {1}", executename, TestFlowFromQ);
                    //processInfo.Verb = "runas";
                    processInfo.Arguments = strCmdText;



                    var pr = System.Diagnostics.Process.Start(processInfo);
                    pr.Dispose();
                    //Print Results-------------------------------------------------------------------



                }
            }
            catch
            {
                MessageBox.Show("Cant Run Test");
            }

            //return back to main Directory
            Directory.SetCurrentDirectory(mainWorkingDir);




        }
        /*
        private void SaveResultExcel()
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "First Name";
                oSheet.Cells[1, 2] = "Last Name";
                oSheet.Cells[1, 3] = "Full Name";
                oSheet.Cells[1, 4] = "Salary";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[5, 2];

                saNames[0, 0] = "John";
                saNames[0, 1] = "Smith";
                saNames[1, 0] = "Tom";

                saNames[4, 1] = "Johnson";

                //Fill A2:B6 with an array of values (First and Last Names).
                oSheet.get_Range("A2", "B6").Value2 = saNames;

                //Fill C2:C6 with a relative formula (=A2 & " " & B2).
                oRng = oSheet.get_Range("C2", "C6");
                oRng.Formula = "=A2 & \" \" & B2";

                //Fill D2:D6 with a formula(=RAND()*100000) and apply format.
                oRng = oSheet.get_Range("D2", "D6");
                oRng.Formula = "=RAND()*100000";
                oRng.NumberFormat = "$0.00";

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                oXL.Visible = false;
                oXL.UserControl = false;
                oWB.SaveAs("c:\\test\\test505.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                oWB.Close();
            }
            catch (Exception)
            {

            }

        }
        */

        public static void ResultOnTable(TableLayoutPanel t1)
        {
            //Design First Row Titles
            t1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            t1.Controls.Add(new Label() { Text = "TestFlow" }, 1, 0);
            t1.Controls.Add(new Label() { Text = "Iteration" }, 2, 0);
            t1.Controls.Add(new Label() { Text = "State" }, 3, 0);


            //start adding row results
        }
     


    }
}
