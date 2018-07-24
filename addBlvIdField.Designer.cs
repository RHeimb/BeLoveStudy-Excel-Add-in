namespace add_BLV_ID
{
    partial class addBlvIdField : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public addBlvIdField()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.btn_add = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.row_editBox = this.Factory.CreateRibbonEditBox();
            this.column_editBox = this.Factory.CreateRibbonEditBox();
            this.btn_select = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.editBox2 = this.Factory.CreateRibbonEditBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.btn_changePath = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btn_add);
            this.group1.Items.Add(this.editBox1);
            this.group1.Label = "Add BeLove-ID";
            this.group1.Name = "group1";
            // 
            // editBox1
            // 
            this.editBox1.Label = "BLV-ID:";
            this.editBox1.Name = "editBox1";
            this.editBox1.Text = null;
            this.editBox1.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBox1_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_add.Label = "Add";
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowImage = true;
            this.btn_add.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_add_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.row_editBox);
            this.group2.Items.Add(this.column_editBox);
            this.group2.Items.Add(this.btn_select);
            this.group2.Label = "Positon of BLV-ID";
            this.group2.Name = "group2";
            // 
            // row_editBox
            // 
            this.row_editBox.Label = "Row";
            this.row_editBox.Name = "row_editBox";
            this.row_editBox.Text = null;
            this.row_editBox.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.row_editBox_TextChanged);
            // 
            // column_editBox
            // 
            this.column_editBox.Label = "Column";
            this.column_editBox.Name = "column_editBox";
            this.column_editBox.Text = null;
            // 
            // btn_select
            // 
            this.btn_select.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_select.Label = "Select";
            this.btn_select.Name = "btn_select";
            this.btn_select.ShowImage = true;
            this.btn_select.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_select_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.editBox2);
            this.group3.Items.Add(this.btn_changePath);
            this.group3.Items.Add(this.label1);
            this.group3.Label = "group3";
            this.group3.Name = "group3";
            // 
            // editBox2
            // 
            this.editBox2.Label = "editBox2";
            this.editBox2.Name = "editBox2";
            this.editBox2.ShowLabel = false;
            this.editBox2.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Label = "Dateipfad zum Import durch DFD.";
            this.label1.Name = "label1";
            // 
            // btn_changePath
            // 
            this.btn_changePath.Label = "button1";
            this.btn_changePath.Name = "btn_changePath";
            this.btn_changePath.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_changePath_Click);
            // 
            // addBlvIdField
            // 
            this.Name = "addBlvIdField";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.addBlvIdField_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_add;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox row_editBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox column_editBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_select;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_changePath;
    }

    partial class ThisRibbonCollection
    {
        internal addBlvIdField addBlvIdField
        {
            get { return this.GetRibbon<addBlvIdField>(); }
        }
    }
}
