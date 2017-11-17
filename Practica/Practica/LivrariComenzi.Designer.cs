namespace Practica
{
    partial class LivrariComenzi
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
            this.grdComenzi = new System.Windows.Forms.DataGridView();
            this.grdLivrari = new System.Windows.Forms.DataGridView();
            this.lblTotalComenzi = new System.Windows.Forms.Label();
            this.lblTotalBonuri = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClient = new System.Windows.Forms.Label();
            this.cboClienti = new System.Windows.Forms.ComboBox();
            this.lblLivrari = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivrari)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdComenzi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grdLivrari, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComenzi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalBonuri, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 331);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grdComenzi
            // 
            this.grdComenzi.AllowUserToAddRows = false;
            this.grdComenzi.AllowUserToDeleteRows = false;
            this.grdComenzi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdComenzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdComenzi.Location = new System.Drawing.Point(3, 33);
            this.grdComenzi.Name = "grdComenzi";
            this.grdComenzi.Size = new System.Drawing.Size(772, 129);
            this.grdComenzi.TabIndex = 3;
            this.grdComenzi.SelectionChanged += new System.EventHandler(this.grdComenzi_SelectionChanged);
            // 
            // grdLivrari
            // 
            this.grdLivrari.AllowUserToAddRows = false;
            this.grdLivrari.AllowUserToDeleteRows = false;
            this.grdLivrari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdLivrari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivrari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLivrari.Location = new System.Drawing.Point(3, 168);
            this.grdLivrari.Name = "grdLivrari";
            this.grdLivrari.Size = new System.Drawing.Size(772, 129);
            this.grdLivrari.TabIndex = 4;
            // 
            // lblTotalComenzi
            // 
            this.lblTotalComenzi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalComenzi.AutoSize = true;
            this.lblTotalComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComenzi.Location = new System.Drawing.Point(3, 5);
            this.lblTotalComenzi.Name = "lblTotalComenzi";
            this.lblTotalComenzi.Size = new System.Drawing.Size(120, 20);
            this.lblTotalComenzi.TabIndex = 6;
            this.lblTotalComenzi.Text = "Total comenzi";
            // 
            // lblTotalBonuri
            // 
            this.lblTotalBonuri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalBonuri.AutoSize = true;
            this.lblTotalBonuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBonuri.Location = new System.Drawing.Point(3, 305);
            this.lblTotalBonuri.Name = "lblTotalBonuri";
            this.lblTotalBonuri.Size = new System.Drawing.Size(0, 20);
            this.lblTotalBonuri.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.lblClient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboClienti, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(66, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 29);
            this.tableLayoutPanel2.TabIndex = 5;
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
            // cboClienti
            // 
            this.cboClienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboClienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienti.FormattingEnabled = true;
            this.cboClienti.Location = new System.Drawing.Point(110, 4);
            this.cboClienti.Name = "cboClienti";
            this.cboClienti.Size = new System.Drawing.Size(121, 21);
            this.cboClienti.TabIndex = 2;
            this.cboClienti.SelectedIndexChanged += new System.EventHandler(this.cboClienti_SelectedIndexChanged);
            // 
            // lblLivrari
            // 
            this.lblLivrari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLivrari.AutoSize = true;
            this.lblLivrari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivrari.Location = new System.Drawing.Point(28, 353);
            this.lblLivrari.Name = "lblLivrari";
            this.lblLivrari.Size = new System.Drawing.Size(101, 20);
            this.lblLivrari.TabIndex = 6;
            this.lblLivrari.Text = "Total livrari:";
            // 
            // LivrariComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 378);
            this.Controls.Add(this.lblLivrari);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LivrariComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti Comenzi";
            this.Load += new System.EventHandler(this.LivrariComenzi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivrari)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdComenzi;
        private System.Windows.Forms.DataGridView grdLivrari;
        private System.Windows.Forms.Label lblTotalComenzi;
        private System.Windows.Forms.Label lblTotalBonuri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cboClienti;
        private System.Windows.Forms.Label lblLivrari;
    }
}