namespace Practica
{
    partial class Transporturi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transporturi));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTransport = new System.Windows.Forms.TextBox();
            this.txtDataPlecare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNrInmatr = new System.Windows.Forms.TextBox();
            this.txtDataSosire = new System.Windows.Forms.TextBox();
            this.txtIdSofer = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.DataPlecare = new System.Windows.Forms.DateTimePicker();
            this.DataSosire = new System.Windows.Forms.DateTimePicker();
            this.cmbIdSofer = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.txtIdTransport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDataPlecare, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNrInmatr, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDataSosire, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIdSofer, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Text = "Id transport:";
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
            this.label2.Text = "Data plecare:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdTransport
            // 
            this.txtIdTransport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTransport.Location = new System.Drawing.Point(237, 12);
            this.txtIdTransport.MaxLength = 5;
            this.txtIdTransport.Name = "txtIdTransport";
            this.txtIdTransport.Size = new System.Drawing.Size(235, 29);
            this.txtIdTransport.TabIndex = 4;
            // 
            // txtDataPlecare
            // 
            this.txtDataPlecare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataPlecare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPlecare.Location = new System.Drawing.Point(237, 65);
            this.txtDataPlecare.Name = "txtDataPlecare";
            this.txtDataPlecare.Size = new System.Drawing.Size(235, 29);
            this.txtDataPlecare.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numar inmatriculare:";
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
            this.label4.Text = "Data sosire:";
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
            this.label5.Text = "Id sofer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNrInmatr
            // 
            this.txtNrInmatr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrInmatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrInmatr.Location = new System.Drawing.Point(237, 118);
            this.txtNrInmatr.MaxLength = 7;
            this.txtNrInmatr.Name = "txtNrInmatr";
            this.txtNrInmatr.Size = new System.Drawing.Size(235, 29);
            this.txtNrInmatr.TabIndex = 10;
            this.txtNrInmatr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNrInmatr_MouseClick);
            this.txtNrInmatr.MouseLeave += new System.EventHandler(this.txtNrInmatr_MouseLeave);
            // 
            // txtDataSosire
            // 
            this.txtDataSosire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataSosire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataSosire.Location = new System.Drawing.Point(237, 171);
            this.txtDataSosire.Name = "txtDataSosire";
            this.txtDataSosire.Size = new System.Drawing.Size(235, 29);
            this.txtDataSosire.TabIndex = 11;
            // 
            // txtIdSofer
            // 
            this.txtIdSofer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdSofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSofer.Location = new System.Drawing.Point(237, 226);
            this.txtIdSofer.MaxLength = 5;
            this.txtIdSofer.Name = "txtIdSofer";
            this.txtIdSofer.Size = new System.Drawing.Size(235, 29);
            this.txtIdSofer.TabIndex = 12;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(525, 12);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 279);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 60);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnUltimul
            // 
            this.btnUltimul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUltimul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimul.Image = global::Practica.Properties.Resources.finish;
            this.btnUltimul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimul.Location = new System.Drawing.Point(410, 14);
            this.btnUltimul.Name = "btnUltimul";
            this.btnUltimul.Size = new System.Drawing.Size(68, 31);
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
            this.btnUrmator.Location = new System.Drawing.Point(287, 14);
            this.btnUrmator.Name = "btnUrmator";
            this.btnUrmator.Size = new System.Drawing.Size(60, 32);
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
            this.btnPrimul.Location = new System.Drawing.Point(32, 13);
            this.btnPrimul.Name = "btnPrimul";
            this.btnPrimul.Size = new System.Drawing.Size(63, 34);
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
            this.btnPrecedent.Location = new System.Drawing.Point(161, 13);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(59, 34);
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
            this.btnAnulare.Location = new System.Drawing.Point(539, 4);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(156, 52);
            this.btnAnulare.TabIndex = 15;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulare.UseMnemonic = false;
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.DataPlecare, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(217, 59);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(302, 58);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.DataSosire, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbIdSofer, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(217, 174);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(302, 99);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // DataPlecare
            // 
            this.DataPlecare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataPlecare.Location = new System.Drawing.Point(51, 19);
            this.DataPlecare.Name = "DataPlecare";
            this.DataPlecare.Size = new System.Drawing.Size(200, 20);
            this.DataPlecare.TabIndex = 0;
            // 
            // DataSosire
            // 
            this.DataSosire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataSosire.Location = new System.Drawing.Point(51, 14);
            this.DataSosire.Name = "DataSosire";
            this.DataSosire.Size = new System.Drawing.Size(200, 20);
            this.DataSosire.TabIndex = 1;
            // 
            // cmbIdSofer
            // 
            this.cmbIdSofer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdSofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdSofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdSofer.FormattingEnabled = true;
            this.cmbIdSofer.Location = new System.Drawing.Point(90, 63);
            this.cmbIdSofer.Name = "cmbIdSofer";
            this.cmbIdSofer.Size = new System.Drawing.Size(121, 28);
            this.cmbIdSofer.TabIndex = 2;
            // 
            // Transporturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 344);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Transporturi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transporturi";
            this.Load += new System.EventHandler(this.Transporturi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTransport;
        private System.Windows.Forms.TextBox txtDataPlecare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNrInmatr;
        private System.Windows.Forms.TextBox txtDataSosire;
        private System.Windows.Forms.TextBox txtIdSofer;
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
        private System.Windows.Forms.DateTimePicker DataPlecare;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker DataSosire;
        private System.Windows.Forms.ComboBox cmbIdSofer;
    }
}