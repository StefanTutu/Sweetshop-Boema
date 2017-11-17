namespace Practica
{
    partial class LivrariTransporturi
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
            this.grdTransporturi = new System.Windows.Forms.DataGridView();
            this.grdLivrari = new System.Windows.Forms.DataGridView();
            this.lblTotalLivrari = new System.Windows.Forms.Label();
            this.lblTotalTransporturi = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSofer = new System.Windows.Forms.Label();
            this.cboSofer = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransporturi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivrari)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdTransporturi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grdLivrari, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalLivrari, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalTransporturi, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 331);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grdTransporturi
            // 
            this.grdTransporturi.AllowUserToAddRows = false;
            this.grdTransporturi.AllowUserToDeleteRows = false;
            this.grdTransporturi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdTransporturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransporturi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransporturi.Location = new System.Drawing.Point(3, 33);
            this.grdTransporturi.Name = "grdTransporturi";
            this.grdTransporturi.Size = new System.Drawing.Size(691, 129);
            this.grdTransporturi.TabIndex = 3;
            this.grdTransporturi.SelectionChanged += new System.EventHandler(this.grdTransporturi_SelectionChanged);
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
            this.grdLivrari.Size = new System.Drawing.Size(691, 129);
            this.grdLivrari.TabIndex = 4;
            // 
            // lblTotalLivrari
            // 
            this.lblTotalLivrari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalLivrari.AutoSize = true;
            this.lblTotalLivrari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLivrari.Location = new System.Drawing.Point(3, 305);
            this.lblTotalLivrari.Name = "lblTotalLivrari";
            this.lblTotalLivrari.Size = new System.Drawing.Size(102, 20);
            this.lblTotalLivrari.TabIndex = 7;
            this.lblTotalLivrari.Text = "Total Livrari";
            // 
            // lblTotalTransporturi
            // 
            this.lblTotalTransporturi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalTransporturi.AutoSize = true;
            this.lblTotalTransporturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransporturi.Location = new System.Drawing.Point(3, 5);
            this.lblTotalTransporturi.Name = "lblTotalTransporturi";
            this.lblTotalTransporturi.Size = new System.Drawing.Size(147, 20);
            this.lblTotalTransporturi.TabIndex = 6;
            this.lblTotalTransporturi.Text = "Total transporturi";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.lblSofer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboSofer, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 29);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblSofer
            // 
            this.lblSofer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSofer.AutoSize = true;
            this.lblSofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSofer.Location = new System.Drawing.Point(3, 4);
            this.lblSofer.Name = "lblSofer";
            this.lblSofer.Size = new System.Drawing.Size(58, 20);
            this.lblSofer.TabIndex = 3;
            this.lblSofer.Text = "Sofer:";
            // 
            // cboSofer
            // 
            this.cboSofer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSofer.FormattingEnabled = true;
            this.cboSofer.Location = new System.Drawing.Point(110, 4);
            this.cboSofer.Name = "cboSofer";
            this.cboSofer.Size = new System.Drawing.Size(121, 21);
            this.cboSofer.TabIndex = 2;
            this.cboSofer.SelectedIndexChanged += new System.EventHandler(this.cboSofer_SelectedIndexChanged);
            // 
            // LivrariTransporturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 382);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LivrariTransporturi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livrari Transporturi";
            this.Load += new System.EventHandler(this.LivrariTransporturi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransporturi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivrari)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdTransporturi;
        private System.Windows.Forms.DataGridView grdLivrari;
        private System.Windows.Forms.Label lblTotalTransporturi;
        private System.Windows.Forms.Label lblTotalLivrari;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSofer;
        private System.Windows.Forms.ComboBox cboSofer;
    }
}