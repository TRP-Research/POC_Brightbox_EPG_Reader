namespace POC_Brightbox_EPG_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHEader = new System.Windows.Forms.Panel();
            this.btnReadJson = new System.Windows.Forms.Button();
            this.lueCarriers = new DevExpress.XtraEditors.LookUpEdit();
            this.pnlMAin = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlHEader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCarriers.Properties)).BeginInit();
            this.pnlMAin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHEader
            // 
            this.pnlHEader.Controls.Add(this.btnReadJson);
            this.pnlHEader.Controls.Add(this.lueCarriers);
            this.pnlHEader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHEader.Location = new System.Drawing.Point(0, 0);
            this.pnlHEader.Name = "pnlHEader";
            this.pnlHEader.Size = new System.Drawing.Size(800, 100);
            this.pnlHEader.TabIndex = 0;
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(103, 45);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(116, 23);
            this.btnReadJson.TabIndex = 1;
            this.btnReadJson.Text = "Load Json";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // lueCarriers
            // 
            this.lueCarriers.Location = new System.Drawing.Point(367, 42);
            this.lueCarriers.Name = "lueCarriers";
            this.lueCarriers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCarriers.Properties.DisplayMember = "CarrierName";
            this.lueCarriers.Properties.NullText = "";
            this.lueCarriers.Properties.ValueMember = "CarrierIP";
            this.lueCarriers.Size = new System.Drawing.Size(214, 20);
            this.lueCarriers.TabIndex = 0;
            this.lueCarriers.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lueCarriers_Closed);
            // 
            // pnlMAin
            // 
            this.pnlMAin.Controls.Add(this.gridControl1);
            this.pnlMAin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMAin.Location = new System.Drawing.Point(0, 100);
            this.pnlMAin.Name = "pnlMAin";
            this.pnlMAin.Size = new System.Drawing.Size(800, 350);
            this.pnlMAin.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 350);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Date";
            this.gridColumn5.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "startTime";
            this.gridColumn5.MaxWidth = 80;
            this.gridColumn5.MinWidth = 80;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.UnboundDataType = typeof(System.DateTime);
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "start";
            this.gridColumn3.DisplayFormat.FormatString = "HH:mm";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "startTime";
            this.gridColumn3.MaxWidth = 60;
            this.gridColumn3.MinWidth = 60;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundDataType = typeof(System.DateTime);
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "end";
            this.gridColumn4.DisplayFormat.FormatString = "HH:mm";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "endTime";
            this.gridColumn4.MaxWidth = 60;
            this.gridColumn4.MinWidth = 60;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 60;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "duration";
            this.gridColumn6.FieldName = "dur";
            this.gridColumn6.MaxWidth = 60;
            this.gridColumn6.MinWidth = 60;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 60;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Title";
            this.gridColumn1.FieldName = "eventName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "eventText";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMAin);
            this.Controls.Add(this.pnlHEader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHEader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueCarriers.Properties)).EndInit();
            this.pnlMAin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHEader;
        private System.Windows.Forms.Panel pnlMAin;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnReadJson;
        private DevExpress.XtraEditors.LookUpEdit lueCarriers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}

