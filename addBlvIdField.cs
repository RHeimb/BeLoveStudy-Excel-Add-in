using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;

namespace add_BLV_ID
{
    public partial class addBlvIdField
    {
        private void addBlvIdField_Load(object sender, RibbonUIEventArgs e)
        {
            this.column_editBox.Text = "A";
            this.row_editBox.Text = "1";
            this.editBox2.Text = Globals.addBeLoveId.pathToSafeTablesForDFD.ToString();
            this.editBox3.Text = Globals.addBeLoveId.regexString;
        }

        private void btn_add_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet activeSheet = Globals.addBeLoveId.GetActiveWS();
            string markedCell = GetCoordinatesFromEditbox();
            if (activeSheet.Range[markedCell,markedCell].Value2 == null)
            {
                activeSheet.Range[markedCell,markedCell].Value2 = this.editBox1.Text;
            }
            else
            {
                Globals.addBeLoveId.InsertEntireRowAbove(activeSheet, markedCell);              
                activeSheet.Range[markedCell,markedCell].Value2 = this.editBox1.Text;
            }
        }

        private void editBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void btn_select_Click(object sender, RibbonControlEventArgs e)
        {
            //markiere Zelle
            Globals.addBeLoveId.SelectCell(this.column_editBox.Text, this.row_editBox.Text);       
        }

        private void row_editBox_TextChanged(object sender, RibbonControlEventArgs e)
        {
            this.row_editBox.Text = this.row_editBox.Text;
        }

        private string GetCoordinatesFromEditbox()
        {
            return this.column_editBox.Text + this.row_editBox.Text;
        }

        private void editBox2_TextChanged(object sender, RibbonControlEventArgs e)
        {
        }

        private void btn_changePath_Click(object sender, RibbonControlEventArgs e)
        {
            string newPath = this.editBox2.Text;
            Globals.addBeLoveId.SetPathToSafeTablesForDFD(newPath);
        }

        private void btn_changeRegEx_Click(object sender, RibbonControlEventArgs e)
        {
            string newRegEx = this.editBox3.Text;
            Globals.addBeLoveId.SetRegexForWorkBookNameCheck(newRegEx);
        }
    }
}
