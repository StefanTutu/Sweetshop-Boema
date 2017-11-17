namespace Practica
{
    partial class MateriiPrime_Produse
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
            this.grdProduse = new System.Windows.Forms.DataGridView();
            this.grdTva = new System.Windows.Forms.DataGridView();
            this.lblTotalProduse = new System.Windows.Forms.Label();
            this.lblTotalTva = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMateriiPrime = new System.Windows.Forms.Label();
            this.cboMatPrima = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTva)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdProduse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grdTva, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalProduse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalTva, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 43);
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
            // grdProduse
            // 
            this.grdProduse.AllowUserToAddRows = false;
            this.grdProduse.AllowUserToDeleteRows = false;
            this.grdProduse.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduse.Location = new System.Drawing.Point(3, 33);
            this.grdProduse.Name = "grdProduse";
            this.grdProduse.Size = new System.Drawing.Size(772, 129);
            this.grdProduse.TabIndex = 3;
            this.grdProduse.SelectionChanged += new System.EventHandler(this.grdProduse_SelectionChanged);
            // 
            // grdTva
            // 
            this.grdTva.AllowUserToAddRows = false;
            this.grdTva.AllowUserToDeleteRows = false;
            this.grdTva.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdTva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTva.Location = new System.Drawing.Point(3, 168);
            this.grdTva.Name = "grdTva";
            this.grdTva.Size = new System.Drawing.Size(772, 129);
            this.grdTva.TabIndex = 4;
            // 
            // lblTotalProduse
            // 
            this.lblTotalProduse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalProduse.AutoSize = true;
            this.lblTotalProduse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduse.Location = new System.Drawing.Point(3, 5);
            this.lblTotalProduse.Name = "lblTotalProduse";
            this.lblTotalProduse.Size = new System.Drawing.Size(119, 20);
            this.lblTotalProduse.TabIndex = 6;
            this.lblTotalProduse.Text = "Total produse";
            // 
            // lblTotalTva
            // 
            this.lblTotalTva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalTva.AutoSize = true;
            this.lblTotalTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTva.Location = new System.Drawing.Point(3, 305);
            this.lblTotalTva.Name = "lblTotalTva";
            this.lblTotalTva.Size = new System.Drawing.Size(88, 20);
            this.lblTotalTva.TabIndex = 7;
            this.lblTotalTva.Text = "Total TVA";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.52529F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.47471F));
            this.tableLayoutPanel2.Controls.Add(this.lblMateriiPrime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboMatPrima, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(49, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 29);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblMateriiPrime
            // 
            this.lblMateriiPrime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMateriiPrime.AutoSize = true;
            this.lblMateriiPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriiPrime.Location = new System.Drawing.Point(3, 4);
            this.lblMateriiPrime.Name = "lblMateriiPrime";
            this.lblMateriiPrime.Size = new System.Drawing.Size(124, 20);
            this.lblMateriiPrime.TabIndex = 3;
            this.lblMateriiPrime.Text = "Materie Prima:";
            // 
            // cboMatPrima
            // 
            this.cboMatPrima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMatPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatPrima.FormattingEnabled = true;
            this.cboMatPrima.Location = new System.Drawing.Point(162, 4);
            this.cboMatPrima.Name = "cboMatPrima";
            this.cboMatPrima.Size = new System.Drawing.Size(121, 21);
            this.cboMatPrima.TabIndex = 2;
            this.cboMatPrima.SelectedIndexChanged += new System.EventHandler(this.cboMatPrima_SelectedIndexChanged);
            // 
            // MateriiPrime_Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 379);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriiPrime_Produse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materii Prime Produse";
            this.Load += new System.EventHandler(this.MateriiPrime_Produse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTva)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdProduse;
        private System.Windows.Forms.DataGridView grdTva;
        private System.Windows.Forms.Label lblTotalProduse;
        private System.Windows.Forms.Label lblTotalTva;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMateriiPrime;
        private System.Windows.Forms.ComboBox cboMatPrima;
    }
}