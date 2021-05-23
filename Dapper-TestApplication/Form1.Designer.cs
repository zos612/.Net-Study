namespace Dapper_TestApplication
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coluser_seq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemp_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemp_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.empBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(227, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(690, 367);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser_seq,
            this.colemp_no,
            this.colemp_nm});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataSource = typeof(Dapper_TestApplication.Emp);
            // 
            // coluser_seq
            // 
            this.coluser_seq.FieldName = "user_seq";
            this.coluser_seq.MinWidth = 30;
            this.coluser_seq.Name = "coluser_seq";
            this.coluser_seq.Visible = true;
            this.coluser_seq.VisibleIndex = 0;
            this.coluser_seq.Width = 112;
            // 
            // colemp_no
            // 
            this.colemp_no.FieldName = "emp_no";
            this.colemp_no.MinWidth = 30;
            this.colemp_no.Name = "colemp_no";
            this.colemp_no.Visible = true;
            this.colemp_no.VisibleIndex = 1;
            this.colemp_no.Width = 112;
            // 
            // colemp_nm
            // 
            this.colemp_nm.FieldName = "emp_nm";
            this.colemp_nm.MinWidth = 30;
            this.colemp_nm.Name = "colemp_nm";
            this.colemp_nm.Visible = true;
            this.colemp_nm.VisibleIndex = 2;
            this.colemp_nm.Width = 112;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 470);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource empBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_seq;
        private DevExpress.XtraGrid.Columns.GridColumn colemp_no;
        private DevExpress.XtraGrid.Columns.GridColumn colemp_nm;
    }
}

