using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Configuration;

namespace add_BLV_ID
{
    public partial class addBeLoveId
    {
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
            //trigger event when a workbook is opened
            this.Application.WorkbookOpen += new Excel.AppEvents_WorkbookOpenEventHandler(Application_WorkbookOpen);
        }

        #endregion
        
        //public variables
        public string pathToSafeTablesForDFD = ConfigurationManager.AppSettings["pathToSafeTablesForDFD"].ToString();
        public string regexString = ConfigurationManager.AppSettings["regexForWorkBookNameCheck"].ToString();
        //private variables
        
        //public methods
        public Excel.Worksheet GetActiveWS()
        {
            return Application.ActiveSheet;
        }

        public void SelectCell(string x, string y)
        {
            Excel.Worksheet activeSheet = GetActiveWS();
            string cell = x + y;
            var range = activeSheet.Range[cell];
            range.Select();
        }

        public void SetPathToSafeTablesForDFD(string path)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
            appSettingsSection.Settings["pathToSafeTablesForDFD"].Value = path;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void SetRegexForWorkBookNameCheck(string regexString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettingsSection = (AppSettingsSection)config.GetSection("appSettings");
            appSettingsSection.Settings["regexForWorkBookNameCheck"].Value = regexString;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void InsertEntireRowAbove(Excel.Worksheet activeSheet, string range)
        {
            Excel.Range r = activeSheet.get_Range(range,range).EntireRow;
            r.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
        }

        //private methods
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //check pathToSafeTablesForDFD (maybe ressource file?)
            //if nameOfWB like regex pattern {throw message with editfield; parse ID and write it in cell; safe WB in pathToSafeTablesForDFD}
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        } 

        private void Application_WorkbookOpen(Excel.Workbook Wb)
        {
            try
            {
                string nameOfWB = Application.ActiveWorkbook.Name;
                if (Regex.IsMatch(regexString, nameOfWB))
                {   
                    //check if "Cell" contains BLV-ID
                }
                else
                {
                    //pass
                }
            }
            catch (System.NullReferenceException)
            {
            }
        }
    }
}
