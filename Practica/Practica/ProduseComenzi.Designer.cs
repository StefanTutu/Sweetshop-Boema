namespace Practica
{
    partial class ProduseComenzi
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
            this.grdBonuriFiscale = new System.Windows.Forms.DataGridView();
            this.lblTotalComenzi = new System.Windows.Forms.Label();
            this.lblTotalBonuri = new System.Windows.Forms.Label();
            this.cboProduse = new System.Windows.Forms.ComboBox();
            this.lblProdus = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBonuriFiscale)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdComenzi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grdBonuriFiscale, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComenzi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalBonuri, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 331);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // grdBonuriFiscale
            // 
            this.grdBonuriFiscale.AllowUserToAddRows = false;
            this.grdBonuriFiscale.AllowUserToDeleteRows = false;
            this.grdBonuriFiscale.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdBonuriFiscale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBonuriFiscale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBonuriFiscale.Location = new System.Drawing.Point(3, 168);
            this.grdBonuriFiscale.Name = "grdBonuriFiscale";
            this.grdBonuriFiscale.Size = new System.Drawing.Size(772, 129);
            this.grdBonuriFiscale.TabIndex = 4;
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
            // cboProduse
            // 
            this.cboProduse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProduse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduse.FormattingEnabled = true;
            this.cboProduse.Location = new System.Drawing.Point(110, 4);
            this.cboProduse.Name = "cboProduse";
            this.cboProduse.Size = new System.Drawing.Size(121, 21);
            this.cboProduse.TabIndex = 2;
            this.cboProduse.SelectedIndexChanged += new System.EventHandler(this.cboProduse_SelectedIndexChanged);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.lblProdus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboProduse, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // ProduseComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 389);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProduseComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse Comenzi";
            this.Load += new System.EventHandler(this.ProduseComenzi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBonuriFiscale)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdComenzi;
        private System.Windows.Forms.DataGridView grdBonuriFiscale;
        private System.Windows.Forms.Label lblTotalComenzi;
        private System.Windows.Forms.Label lblTotalBonuri;
        private System.Windows.Forms.ComboBox cboProduse;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}