namespace Practica
{
    partial class VanzariProprii_Incasari
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdBonuri = new System.Windows.Forms.DataGridView();
            this.grdIncasari = new System.Windows.Forms.DataGridView();
            this.lblBonuri = new System.Windows.Forms.Label();
            this.lblIncasari = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProdus = new System.Windows.Forms.Label();
            this.cboProdus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBonuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncasari)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdBonuri, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grdIncasari, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBonuri, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIncasari, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 331);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grdBonuri
            // 
            this.grdBonuri.AllowUserToAddRows = false;
            this.grdBonuri.AllowUserToDeleteRows = false;
            this.grdBonuri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdBonuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBonuri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBonuri.Location = new System.Drawing.Point(3, 33);
            this.grdBonuri.Name = "grdBonuri";
            this.grdBonuri.Size = new System.Drawing.Size(772, 129);
            this.grdBonuri.TabIndex = 3;
            this.grdBonuri.SelectionChanged += new System.EventHandler(this.grdBonuri_SelectionChanged);
            // 
            // grdIncasari
            // 
            this.grdIncasari.AllowUserToAddRows = false;
            this.grdIncasari.AllowUserToDeleteRows = false;
            this.grdIncasari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdIncasari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIncasari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIncasari.Location = new System.Drawing.Point(3, 168);
            this.grdIncasari.Name = "grdIncasari";
            this.grdIncasari.Size = new System.Drawing.Size(772, 129);
            this.grdIncasari.TabIndex = 4;
            // 
            // lblBonuri
            // 
            this.lblBonuri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBonuri.AutoSize = true;
            this.lblBonuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonuri.Location = new System.Drawing.Point(3, 5);
            this.lblBonuri.Name = "lblBonuri";
            this.lblBonuri.Size = new System.Drawing.Size(109, 20);
            this.lblBonuri.TabIndex = 6;
            this.lblBonuri.Text = "Total bonuri:";
            // 
            // lblIncasari
            // 
            this.lblIncasari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncasari.AutoSize = true;
            this.lblIncasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncasari.Location = new System.Drawing.Point(3, 305);
            this.lblIncasari.Name = "lblIncasari";
            this.lblIncasari.Size = new System.Drawing.Size(197, 20);
            this.lblIncasari.TabIndex = 7;
            this.lblIncasari.Text = "Total Incasari selectate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.lblProdus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboProdus, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(38, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 29);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblProdus
            // 
            this.lblProdus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProdus.AutoSize = true;
            this.lblProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdus.Location = new System.Drawing.Point(3, 4);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(70, 20);
            this.lblProdus.TabIndex = 3;
            this.lblProdus.Text = "Produs:";
            // 
            // cboProdus
            // 
            this.cboProdus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProdus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdus.FormattingEnabled = true;
            this.cboProdus.Location = new System.Drawing.Point(110, 4);
            this.cboProdus.Name = "cboProdus";
            this.cboProdus.Size = new System.Drawing.Size(121, 21);
            this.cboProdus.TabIndex = 2;
            this.cboProdus.SelectedIndexChanged += new System.EventHandler(this.cboProdus_SelectedIndexChanged);
            // 
            // VanzariProprii_Incasari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 389);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VanzariProprii_Incasari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanzari Proprii Incasari";
            this.Load += new System.EventHandler(this.VanzariProprii_Incasari_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBonuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncasari)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdBonuri;
        private System.Windows.Forms.DataGridView grdIncasari;
        private System.Windows.Forms.Label lblBonuri;
        private System.Windows.Forms.Label lblIncasari;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.ComboBox cboProdus;

    }
}