
namespace PerhotelanZayyan
{
    partial class Fpembayaran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmbBook = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btntambah = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbMetode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtjumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbBook
            // 
            this.CmbBook.BackColor = System.Drawing.Color.Transparent;
            this.CmbBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.CmbBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBook.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbBook.ForeColor = System.Drawing.Color.Black;
            this.CmbBook.ItemHeight = 30;
            this.CmbBook.Location = new System.Drawing.Point(8, 63);
            this.CmbBook.Name = "CmbBook";
            this.CmbBook.Size = new System.Drawing.Size(215, 36);
            this.CmbBook.TabIndex = 28;
            this.CmbBook.SelectedIndexChanged += new System.EventHandler(this.CmbBook_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(306, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Jumlah";
            // 
            // btnsimpan
            // 
            this.btnsimpan.BorderRadius = 10;
            this.btnsimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(469, 224);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(177, 44);
            this.btnsimpan.TabIndex = 25;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click_1);
            // 
            // btntambah
            // 
            this.btntambah.BorderRadius = 10;
            this.btntambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btntambah.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btntambah.ForeColor = System.Drawing.Color.White;
            this.btntambah.Location = new System.Drawing.Point(244, 224);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(177, 44);
            this.btntambah.TabIndex = 24;
            this.btntambah.Text = "Ubah";
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(21, 224);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(177, 44);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Tampil";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeight = 18;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(9, 8);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1075, 144);
            this.guna2DataGridView1.TabIndex = 23;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(37)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick_1);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode_Booking";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tanggal_Bayar";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah_Bayar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Metode";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Status";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(623, 40);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 20);
            this.labelId.TabIndex = 21;
            this.labelId.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(230, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Metode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(454, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Form Pembayaran";
            // 
            // CmbMetode
            // 
            this.CmbMetode.BackColor = System.Drawing.Color.Transparent;
            this.CmbMetode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.CmbMetode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMetode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbMetode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbMetode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbMetode.ForeColor = System.Drawing.Color.Black;
            this.CmbMetode.ItemHeight = 30;
            this.CmbMetode.Location = new System.Drawing.Point(232, 63);
            this.CmbMetode.Name = "CmbMetode";
            this.CmbMetode.Size = new System.Drawing.Size(215, 36);
            this.CmbMetode.TabIndex = 31;
            // 
            // CmbStatus
            // 
            this.CmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.CmbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.CmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbStatus.ForeColor = System.Drawing.Color.Black;
            this.CmbStatus.ItemHeight = 30;
            this.CmbStatus.Items.AddRange(new object[] {
            "DP ",
            "LUNAS"});
            this.CmbStatus.Location = new System.Drawing.Point(458, 63);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(215, 36);
            this.CmbStatus.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Booking Id";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PerhotelanZayyan.Properties.Resources.Trash_Can_24px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 145;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.CmbStatus);
            this.guna2Panel1.Controls.Add(this.CmbMetode);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btntambah);
            this.guna2Panel1.Controls.Add(this.btnsimpan);
            this.guna2Panel1.Controls.Add(this.txtjumlah);
            this.guna2Panel1.Controls.Add(this.labelId);
            this.guna2Panel1.Controls.Add(this.CmbBook);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Location = new System.Drawing.Point(33, 239);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(688, 284);
            this.guna2Panel1.TabIndex = 34;
            // 
            // txtjumlah
            // 
            this.txtjumlah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtjumlah.BorderRadius = 6;
            this.txtjumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjumlah.DefaultText = "";
            this.txtjumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtjumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtjumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtjumlah.ForeColor = System.Drawing.Color.Black;
            this.txtjumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjumlah.Location = new System.Drawing.Point(10, 138);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.PlaceholderText = "";
            this.txtjumlah.SelectedText = "";
            this.txtjumlah.Size = new System.Drawing.Size(663, 36);
            this.txtjumlah.TabIndex = 22;
            this.txtjumlah.TextChanged += new System.EventHandler(this.txtjumlah_TextChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 6;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 202);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(682, 79);
            this.guna2Panel3.TabIndex = 34;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 6;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel2.Location = new System.Drawing.Point(33, 75);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1095, 158);
            this.guna2Panel2.TabIndex = 35;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(743, 292);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(382, 36);
            this.guna2TextBox1.TabIndex = 35;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(739, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Search";
            // 
            // Fpembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 708);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "Fpembayaran";
            this.Text = "Fpembayaran";
            this.Load += new System.EventHandler(this.Fpembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox CmbBook;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnsimpan;
        private Guna.UI2.WinForms.Guna2Button btntambah;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox CmbMetode;
        private Guna.UI2.WinForms.Guna2ComboBox CmbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtjumlah;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label7;
    }
}