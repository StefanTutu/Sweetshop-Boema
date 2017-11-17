namespace Practica
{
    partial class Produse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produse));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProdus = new System.Windows.Forms.TextBox();
            this.txtDenumireProdus = new System.Windows.Forms.TextBox();
            this.txtUMProdus = new System.Windows.Forms.TextBox();
            this.txtPretCatalog = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUltimul = new System.Windows.Forms.Button();
            this.btnUrmator = new System.Windows.Forms.Button();
            this.btnPrimul = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalvare, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnModificare, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStergere, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIdProdus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDenumireProdus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUMProdus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPretCatalog, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdaugare, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 269);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Image = global::Practica.Properties.Resources.disk_save_icon;
            this.btnSalvare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvare.Location = new System.Drawing.Point(535, 212);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(139, 45);
            this.btnSalvare.TabIndex = 15;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvare.UseMnemonic = false;
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.Image = global::Practica.Properties.Resources.Document_2_Edit_icon;
            this.btnModificare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificare.Location = new System.Drawing.Point(532, 145);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(146, 45);
            this.btnModificare.TabIndex = 14;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificare.UseMnemonic = false;
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Image = global::Practica.Properties.Resources.Full_Recycle_Bin_64x64;
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStergere.Location = new System.Drawing.Point(532, 78);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(146, 45);
            this.btnStergere.TabIndex = 13;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.UseMnemonic = false;
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Produs:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire Produs:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unitate Masura Produs:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret Catalog Produs:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdProdus
            // 
            this.txtIdProdus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProdus.Location = new System.Drawing.Point(256, 19);
            this.txtIdProdus.MaxLength = 5;
            this.txtIdProdus.Name = "txtIdProdus";
            this.txtIdProdus.Size = new System.Drawing.Size(235, 29);
            this.txtIdProdus.TabIndex = 4;
            // 
            // txtDenumireProdus
            // 
            this.txtDenumireProdus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDenumireProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenumireProdus.Location = new System.Drawing.Point(256, 86);
            this.txtDenumireProdus.MaxLength = 20;
            this.txtDenumireProdus.Name = "txtDenumireProdus";
            this.txtDenumireProdus.Size = new System.Drawing.Size(235, 29);
            this.txtDenumireProdus.TabIndex = 5;
            // 
            // txtUMProdus
            // 
            this.txtUMProdus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUMProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMProdus.Location = new System.Drawing.Point(256, 153);
            this.txtUMProdus.MaxLength = 5;
            this.txtUMProdus.Name = "txtUMProdus";
            this.txtUMProdus.Size = new System.Drawing.Size(235, 29);
            this.txtUMProdus.TabIndex = 6;
            // 
            // txtPretCatalog
            // 
            this.txtPretCatalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretCatalog.Location = new System.Drawing.Point(256, 220);
            this.txtPretCatalog.MaxLength = 5;
            this.txtPretCatalog.Name = "txtPretCatalog";
            this.txtPretCatalog.Size = new System.Drawing.Size(235, 29);
            this.txtPretCatalog.TabIndex = 7;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Image = ((System.Drawing.Image)(resources.GetObject("btnAdaugare.Image")));
            this.btnAdaugare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdaugare.Location = new System.Drawing.Point(535, 11);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(139, 45);
            this.btnAdaugare.TabIndex = 12;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdaugare.UseMnemonic = false;
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.btnUltimul, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUrmator, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrimul, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrecedent, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAnulare, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 287);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(712, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUltimul
            // 
            this.btnUltimul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUltimul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimul.Image = global::Practica.Properties.Resources.finish;
            this.btnUltimul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimul.Location = new System.Drawing.Point(401, 13);
            this.btnUltimul.Name = "btnUltimul";
            this.btnUltimul.Size = new System.Drawing.Size(66, 33);
            this.btnUltimul.TabIndex = 11;
            this.btnUltimul.Text = ">>";
            this.btnUltimul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimul.UseMnemonic = false;
            this.btnUltimul.UseVisualStyleBackColor = true;
            this.btnUltimul.Click += new System.EventHandler(this.btnUltimul_Click);
            // 
            // btnUrmator
            // 
            this.btnUrmator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUrmator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrmator.Image = global::Practica.Properties.Resources.stock_illustration_36022180_vector_running_human_icon;
            this.btnUrmator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrmator.Location = new System.Drawing.Point(282, 13);
            this.btnUrmator.Name = "btnUrmator";
            this.btnUrmator.Size = new System.Drawing.Size(55, 34);
            this.btnUrmator.TabIndex = 10;
            this.btnUrmator.Text = ">";
            this.btnUrmator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrmator.UseVisualStyleBackColor = true;
            this.btnUrmator.Click += new System.EventHandler(this.btnUrmator_Click);
            // 
            // btnPrimul
            // 
            this.btnPrimul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrimul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimul.Image = global::Practica.Properties.Resources.start1;
            this.btnPrimul.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimul.Location = new System.Drawing.Point(29, 12);
            this.btnPrimul.Name = "btnPrimul";
            this.btnPrimul.Size = new System.Drawing.Size(65, 36);
            this.btnPrimul.TabIndex = 8;
            this.btnPrimul.Text = "<<";
            this.btnPrimul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimul.UseVisualStyleBackColor = true;
            this.btnPrimul.Click += new System.EventHandler(this.btnPrimul_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Image = global::Practica.Properties.Resources.stock_illustration_36022180_vector_running_human_icon___Copy;
            this.btnPrecedent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrecedent.Location = new System.Drawing.Point(158, 12);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(55, 36);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare.Image = global::Practica.Properties.Resources.red_31176_640;
            this.btnAnulare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnulare.Location = new System.Drawing.Point(526, 4);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(156, 52);
            this.btnAnulare.TabIndex = 15;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulare.UseMnemonic = false;
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Produse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.Produse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProdus;
        private System.Windows.Forms.TextBox txtDenumireProdus;
        private System.Windows.Forms.TextBox txtUMProdus;
        private System.Windows.Forms.TextBox txtPretCatalog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Button btnUltimul;
        private System.Windows.Forms.Button btnUrmator;
        private System.Windows.Forms.Button btnPrimul;
        private System.Windows.Forms.Button btnPrecedent;
    }
}