namespace Practica
{
    partial class RaportCostProductie
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCostProductie = new Practica.DataSetCostProductie();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbDenProdus = new System.Windows.Forms.ComboBox();
            this.DataTable1TableAdapter = new Practica.DataSetCostProductieTableAdapters.DataTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCostProductie)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetCostProductie;
            // 
            // DataSetCostProductie
            // 
            this.DataSetCostProductie.DataSetName = "DataSetCostProductie";
            this.DataSetCostProductie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Practica.ReportCostProductie.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(50, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(660, 279);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbDenProdus
            // 
            this.cmbDenProdus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDenProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDenProdus.FormattingEnabled = true;
            this.cmbDenProdus.Location = new System.Drawing.Point(286, 19);
            this.cmbDenProdus.Name = "cmbDenProdus";
            this.cmbDenProdus.Size = new System.Drawing.Size(149, 28);
            this.cmbDenProdus.TabIndex = 1;
            this.cmbDenProdus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteaza denumirea produsului:";
            // 
            // RaportCostProductie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDenProdus);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportCostProductie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport Cost Productie";
            this.Load += new System.EventHandler(this.RaportCostProductie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCostProductie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetCostProductie DataSetCostProductie;
        private System.Windows.Forms.ComboBox cmbDenProdus;
        private DataSetCostProductieTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
    }
}