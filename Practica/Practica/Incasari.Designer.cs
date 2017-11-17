namespace Practica
{
    partial class Incasari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incasari));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdIncasare = new System.Windows.Forms.TextBox();
            this.txtIdBonFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataIncasare = new System.Windows.Forms.TextBox();
            this.txtModPlata = new System.Windows.Forms.TextBox();
            this.txtSumaIncasata = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUltimul = new System.Windows.Forms.Button();
            this.btnUrmator = new System.Windows.Forms.Button();
            this.btnPrimul = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbModPlata = new System.Windows.Forms.ComboBox();
            this.cmbIdBF = new System.Windows.Forms.ComboBox();
            this.DataIncasare = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdIncasare, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIdBonFiscal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDataIncasare, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtModPlata, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSumaIncasata, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 269);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id incasare:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id bon fiscal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdIncasare
            // 
            this.txtIdIncasare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdIncasare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdIncasare.Location = new System.Drawing.Point(237, 12);
            this.txtIdIncasare.MaxLength = 5;
            this.txtIdIncasare.Name = "txtIdIncasare";
            this.txtIdIncasare.Size = new System.Drawing.Size(235, 29);
            this.txtIdIncasare.TabIndex = 4;
            // 
            // txtIdBonFiscal
            // 
            this.txtIdBonFiscal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdBonFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBonFiscal.Location = new System.Drawing.Point(237, 65);
            this.txtIdBonFiscal.MaxLength = 5;
            this.txtIdBonFiscal.Name = "txtIdBonFiscal";
            this.txtIdBonFiscal.Size = new System.Drawing.Size(235, 29);
            this.txtIdBonFiscal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Incasare : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mod de plata:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Suma incasata:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDataIncasare
            // 
            this.txtDataIncasare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataIncasare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataIncasare.Location = new System.Drawing.Point(237, 118);
            this.txtDataIncasare.Name = "txtDataIncasare";
            this.txtDataIncasare.Size = new System.Drawing.Size(235, 29);
            this.txtDataIncasare.TabIndex = 10;
            // 
            // txtModPlata
            // 
            this.txtModPlata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModPlata.Location = new System.Drawing.Point(237, 171);
            this.txtModPlata.MaxLength = 20;
            this.txtModPlata.Name = "txtModPlata";
            this.txtModPlata.Size = new System.Drawing.Size(235, 29);
            this.txtModPlata.TabIndex = 11;
            // 
            // txtSumaIncasata
            // 
            this.txtSumaIncasata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumaIncasata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaIncasata.Location = new System.Drawing.Point(237, 226);
            this.txtSumaIncasata.MaxLength = 5;
            this.txtSumaIncasata.Name = "txtSumaIncasata";
            this.txtSumaIncasata.Size = new System.Drawing.Size(235, 29);
            this.txtSumaIncasata.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnSalvare, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnAdaugare, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnStergere, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnModificare, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(525, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 273);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Image = global::Practica.Properties.Resources.disk_save_icon;
            this.btnSalvare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvare.Location = new System.Drawing.Point(30, 216);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(139, 45);
            this.btnSalvare.TabIndex = 16;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvare.UseMnemonic = false;
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Image = ((System.Drawing.Image)(resources.GetObject("btnAdaugare.Image")));
            this.btnAdaugare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdaugare.Location = new System.Drawing.Point(30, 11);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(139, 45);
            this.btnAdaugare.TabIndex = 13;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdaugare.UseMnemonic = false;
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Image = global::Practica.Properties.Resources.Full_Recycle_Bin_64x64;
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStergere.Location = new System.Drawing.Point(27, 79);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(146, 45);
            this.btnStergere.TabIndex = 14;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.UseMnemonic = false;
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.Image = global::Practica.Properties.Resources.Document_2_Edit_icon;
            this.btnModificare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificare.Location = new System.Drawing.Point(27, 147);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(146, 45);
            this.btnModificare.TabIndex = 15;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificare.UseMnemonic = false;
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 276);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(712, 45);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnUltimul
            // 
            this.btnUltimul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUltimul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimul.Image = global::Practica.Properties.Resources.finish;
            this.btnUltimul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimul.Location = new System.Drawing.Point(399, 5);
            this.btnUltimul.Name = "btnUltimul";
            this.btnUltimul.Size = new System.Drawing.Size(69, 34);
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
            this.btnUrmator.Location = new System.Drawing.Point(282, 7);
            this.btnUrmator.Name = "btnUrmator";
            this.btnUrmator.Size = new System.Drawing.Size(55, 31);
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
            this.btnPrimul.Location = new System.Drawing.Point(26, 6);
            this.btnPrimul.Name = "btnPrimul";
            this.btnPrimul.Size = new System.Drawing.Size(71, 32);
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
            this.btnPrecedent.Location = new System.Drawing.Point(157, 5);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(57, 35);
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
            this.btnAnulare.Location = new System.Drawing.Point(526, 3);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(156, 39);
            this.btnAnulare.TabIndex = 15;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulare.UseMnemonic = false;
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cmbIdBF, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbModPlata, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.DataIncasare, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(217, 48);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(302, 173);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // cmbModPlata
            // 
            this.cmbModPlata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModPlata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModPlata.FormattingEnabled = true;
            this.cmbModPlata.Items.AddRange(new object[] {
            "Card",
            "Cec",
            "Numerar"});
            this.cmbModPlata.Location = new System.Drawing.Point(52, 129);
            this.cmbModPlata.Name = "cmbModPlata";
            this.cmbModPlata.Size = new System.Drawing.Size(197, 28);
            this.cmbModPlata.TabIndex = 2;
            // 
            // cmbIdBF
            // 
            this.cmbIdBF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdBF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdBF.FormattingEnabled = true;
            this.cmbIdBF.Location = new System.Drawing.Point(52, 14);
            this.cmbIdBF.Name = "cmbIdBF";
            this.cmbIdBF.Size = new System.Drawing.Size(197, 28);
            this.cmbIdBF.TabIndex = 3;
            // 
            // DataIncasare
            // 
            this.DataIncasare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataIncasare.Location = new System.Drawing.Point(51, 75);
            this.DataIncasare.Name = "DataIncasare";
            this.DataIncasare.Size = new System.Drawing.Size(200, 20);
            this.DataIncasare.TabIndex = 4;
            // 
            // Incasari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 329);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Incasari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incasari";
            this.Load += new System.EventHandler(this.Incasari_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdIncasare;
        private System.Windows.Forms.TextBox txtIdBonFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataIncasare;
        private System.Windows.Forms.TextBox txtModPlata;
        private System.Windows.Forms.TextBox txtSumaIncasata;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnUltimul;
        private System.Windows.Forms.Button btnUrmator;
        private System.Windows.Forms.Button btnPrimul;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cmbIdBF;
        private System.Windows.Forms.ComboBox cmbModPlata;
        private System.Windows.Forms.DateTimePicker DataIncasare;
    }
}