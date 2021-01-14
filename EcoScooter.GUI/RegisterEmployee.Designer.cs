namespace EcoScooter.GUI
{
    partial class RegisterEmployee
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelCognoms = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelCorreu = new System.Windows.Forms.Label();
            this.textBoxCorreu = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDataDeNaixement = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataDeNaixement = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPosicio = new System.Windows.Forms.TextBox();
            this.textBoxSalari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRepeteixContrasenya = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.textBoxRepeteixPIN = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIBAN = new System.Windows.Forms.Label();
            this.textBoxIBAN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelErrorRegister = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelErrorRegister, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(38, 41, 38, 41);
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(800, 464);
            this.tableLayoutPanel4.TabIndex = 8;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(41, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dades personals";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDNI, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCognoms, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCorreu, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCorreu, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTelefon, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDataDeNaixement, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTelefon, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDataDeNaixement, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 38, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 210);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.AccessibleName = "tb_dp_dni";
            this.textBoxDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDNI.Location = new System.Drawing.Point(171, 53);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(94, 20);
            this.textBoxDNI.TabIndex = 5;
            // 
            // labelCognoms
            // 
            this.labelCognoms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCognoms.AutoSize = true;
            this.labelCognoms.Location = new System.Drawing.Point(20, 56);
            this.labelCognoms.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelCognoms.Name = "labelCognoms";
            this.labelCognoms.Size = new System.Drawing.Size(26, 13);
            this.labelCognoms.TabIndex = 2;
            this.labelCognoms.Text = "DNI";
            // 
            // labelNom
            // 
            this.labelNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(20, 14);
            this.labelNom.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(69, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom complet";
            // 
            // textBoxNom
            // 
            this.textBoxNom.AccessibleName = "tb_dp_nom";
            this.textBoxNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNom.Location = new System.Drawing.Point(143, 11);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(150, 20);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlNoNumbers);
            // 
            // labelCorreu
            // 
            this.labelCorreu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCorreu.AutoSize = true;
            this.labelCorreu.Location = new System.Drawing.Point(20, 182);
            this.labelCorreu.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelCorreu.Name = "labelCorreu";
            this.labelCorreu.Size = new System.Drawing.Size(38, 13);
            this.labelCorreu.TabIndex = 10;
            this.labelCorreu.Text = "Correu";
            // 
            // textBoxCorreu
            // 
            this.textBoxCorreu.AccessibleName = "tb_dp_correu";
            this.textBoxCorreu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCorreu.Location = new System.Drawing.Point(148, 179);
            this.textBoxCorreu.Name = "textBoxCorreu";
            this.textBoxCorreu.Size = new System.Drawing.Size(140, 20);
            this.textBoxCorreu.TabIndex = 12;
            // 
            // labelTelefon
            // 
            this.labelTelefon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(20, 98);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 3;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelDataDeNaixement
            // 
            this.labelDataDeNaixement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDataDeNaixement.AutoSize = true;
            this.labelDataDeNaixement.Location = new System.Drawing.Point(20, 134);
            this.labelDataDeNaixement.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelDataDeNaixement.Name = "labelDataDeNaixement";
            this.labelDataDeNaixement.Size = new System.Drawing.Size(55, 26);
            this.labelDataDeNaixement.TabIndex = 4;
            this.labelDataDeNaixement.Text = "Data de naixement";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.AccessibleName = "tb_dp_telf";
            this.textBoxTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTelefon.Location = new System.Drawing.Point(171, 95);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(94, 20);
            this.textBoxTelefon.TabIndex = 7;
            this.textBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTelephone);
            // 
            // dateTimePickerDataDeNaixement
            // 
            this.dateTimePickerDataDeNaixement.AccessibleName = "tb_dp_data";
            this.dateTimePickerDataDeNaixement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDataDeNaixement.Location = new System.Drawing.Point(144, 137);
            this.dateTimePickerDataDeNaixement.Name = "dateTimePickerDataDeNaixement";
            this.dateTimePickerDataDeNaixement.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerDataDeNaixement.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(430, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 229);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleat";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelRepeteixContrasenya, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelContrasenya, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPIN, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRepeteixPIN, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPosicio, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxSalari, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(38, 3, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(323, 210);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salari";
            // 
            // textBoxPosicio
            // 
            this.textBoxPosicio.AccessibleName = "tb_u_rpass";
            this.textBoxPosicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPosicio.Location = new System.Drawing.Point(182, 176);
            this.textBoxPosicio.Name = "textBoxPosicio";
            this.textBoxPosicio.Size = new System.Drawing.Size(120, 20);
            this.textBoxPosicio.TabIndex = 10;
            this.textBoxPosicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlNoNumbers);
            // 
            // textBoxSalari
            // 
            this.textBoxSalari.AccessibleName = "tb_u_rpass";
            this.textBoxSalari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSalari.Location = new System.Drawing.Point(182, 130);
            this.textBoxSalari.Name = "textBoxSalari";
            this.textBoxSalari.Size = new System.Drawing.Size(120, 20);
            this.textBoxSalari.TabIndex = 9;
            this.textBoxSalari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlSalari);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Posició";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRepeteixContrasenya
            // 
            this.labelRepeteixContrasenya.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRepeteixContrasenya.AutoSize = true;
            this.labelRepeteixContrasenya.Location = new System.Drawing.Point(20, 77);
            this.labelRepeteixContrasenya.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelRepeteixContrasenya.Name = "labelRepeteixContrasenya";
            this.labelRepeteixContrasenya.Size = new System.Drawing.Size(70, 13);
            this.labelRepeteixContrasenya.TabIndex = 5;
            this.labelRepeteixContrasenya.Text = "Repeteix PIN";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Location = new System.Drawing.Point(20, 18);
            this.labelContrasenya.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(25, 13);
            this.labelContrasenya.TabIndex = 2;
            this.labelContrasenya.Text = "PIN";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.AccessibleName = "tb_u_pass";
            this.textBoxPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPIN.Location = new System.Drawing.Point(182, 14);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.PasswordChar = '*';
            this.textBoxPIN.Size = new System.Drawing.Size(120, 20);
            this.textBoxPIN.TabIndex = 4;
            // 
            // textBoxRepeteixPIN
            // 
            this.textBoxRepeteixPIN.AccessibleName = "tb_u_rpass";
            this.textBoxRepeteixPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRepeteixPIN.Location = new System.Drawing.Point(182, 73);
            this.textBoxRepeteixPIN.Name = "textBoxRepeteixPIN";
            this.textBoxRepeteixPIN.PasswordChar = '*';
            this.textBoxRepeteixPIN.Size = new System.Drawing.Size(120, 20);
            this.textBoxRepeteixPIN.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(233, 306);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 80);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compte Bancari";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.labelIBAN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIBAN, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(75, 41, 75, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 61);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labelIBAN
            // 
            this.labelIBAN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIBAN.AutoSize = true;
            this.labelIBAN.Location = new System.Drawing.Point(20, 24);
            this.labelIBAN.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelIBAN.Name = "labelIBAN";
            this.labelIBAN.Size = new System.Drawing.Size(32, 13);
            this.labelIBAN.TabIndex = 1;
            this.labelIBAN.Text = "IBAN";
            // 
            // textBoxIBAN
            // 
            this.textBoxIBAN.AccessibleName = "tb_t_iban";
            this.textBoxIBAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIBAN.Location = new System.Drawing.Point(106, 20);
            this.textBoxIBAN.Name = "textBoxIBAN";
            this.textBoxIBAN.Size = new System.Drawing.Size(197, 20);
            this.textBoxIBAN.TabIndex = 4;
            this.textBoxIBAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlIBAN);
            // 
            // button1
            // 
            this.button1.AccessibleName = "botoRegistrar";
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(202)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(693, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RegistrarEmployee);
            // 
            // labelErrorRegister
            // 
            this.labelErrorRegister.AccessibleName = "textErrorRegUsuari";
            this.labelErrorRegister.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelErrorRegister.AutoSize = true;
            this.labelErrorRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelErrorRegister.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRegister.Location = new System.Drawing.Point(627, 433);
            this.labelErrorRegister.Name = "labelErrorRegister";
            this.labelErrorRegister.Size = new System.Drawing.Size(132, 13);
            this.labelErrorRegister.TabIndex = 11;
            this.labelErrorRegister.Text = "Aquí va el missatge d\'error";
            this.labelErrorRegister.Visible = false;
            // 
            // RegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterEmployee";
            this.Text = "RegisterEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelCognoms;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelDataDeNaixement;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDeNaixement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelRepeteixContrasenya;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.TextBox textBoxRepeteixPIN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelIBAN;
        private System.Windows.Forms.TextBox textBoxIBAN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelErrorRegister;
        private System.Windows.Forms.Label labelCorreu;
        private System.Windows.Forms.TextBox textBoxCorreu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPosicio;
        private System.Windows.Forms.TextBox textBoxSalari;
    }
}