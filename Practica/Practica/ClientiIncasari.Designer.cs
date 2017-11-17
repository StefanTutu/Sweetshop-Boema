namespace Practica
{
    partial class ClientiIncasari
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
            this.lblTotalBonuri = new System.Windows.Forms.Label();
            this.lblTotalIncasari = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClient = new System.Windows.Forms.Label();
            this.cboClient = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lblTotalBonuri, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalIncasari, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 43);
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
            // lblTotalBonuri
            // 
            this.lblTotalBonuri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalBonuri.AutoSize = true;
            this.lblTotalBonuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBonuri.Location = new System.Drawing.Point(3, 5);
            this.lblTotalBonuri.Name = "lblTotalBonuri";
            this.lblTotalBonuri.Size = new System.Drawing.Size(104, 20);
            this.lblTotalBonuri.TabIndex = 6;
            this.lblTotalBonuri.Text = "Total bonuri";
            // 
            // lblTotalIncasari
            // 
            this.lblTotalIncasari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalIncasari.AutoSize = true;
            this.lblTotalIncasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncasari.Location = new System.Drawing.Point(3, 305);
            this.lblTotalIncasari.Name = "lblTotalIncasari";
            this.lblTotalIncasari.Size = new System.Drawing.Size(118, 20);
            this.lblTotalIncasari.TabIndex = 7;
            this.lblTotalIncasari.Text = "Total Incasari";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.lblClient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboClient, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 29);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblClient
            // 
            this.lblClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(3, 4);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(60, 20);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Client:";
            // 
            // cboClient
            // 
            this.cboClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(110, 4);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(121, 21);
            this.cboClient.TabIndex = 2;
            this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
            // 
            // ClientiIncasari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 386);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientiIncasari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti Incasari";
            this.Load += new System.EventHandler(this.ClientiIncasari_Load);
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
        private System.Windows.Forms.Label lblTotalBonuri;
        private System.Windows.Forms.Label lblTotalIncasari;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cboClient;
    }
}