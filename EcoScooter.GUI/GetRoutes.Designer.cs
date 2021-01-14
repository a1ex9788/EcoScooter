namespace EcoScooter.GUI
{
    partial class GetRoutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetRoutes));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCognoms = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewRutes = new System.Windows.Forms.DataGridView();
            this.Inici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelError, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewRutes, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(38, 41, 38, 41);
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.31359F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.68641F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(789, 430);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(597, 373);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(151, 15);
            this.labelError.TabIndex = 14;
            this.labelError.Text = "Aquí va el missatge d\'error";
            this.labelError.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(202)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(682, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Obtindre rutes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ObtindreRutes);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(41, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interval de temps";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.labelCognoms, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 38, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 62);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelCognoms
            // 
            this.labelCognoms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCognoms.AutoSize = true;
            this.labelCognoms.Location = new System.Drawing.Point(20, 39);
            this.labelCognoms.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelCognoms.Name = "labelCognoms";
            this.labelCognoms.Size = new System.Drawing.Size(59, 15);
            this.labelCognoms.TabIndex = 2;
            this.labelCognoms.Text = "Data de fi";
            this.labelCognoms.Click += new System.EventHandler(this.labelCognoms_Click);
            // 
            // labelNom
            // 
            this.labelNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(20, 0);
            this.labelNom.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(53, 30);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Data de inici";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.bottoEnable);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dataGridViewRutes
            // 
            this.dataGridViewRutes.AllowUserToAddRows = false;
            this.dataGridViewRutes.AllowUserToDeleteRows = false;
            this.dataGridViewRutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inici,
            this.Fi,
            this.Preu,
            this.Origen,
            this.Desti});
            this.dataGridViewRutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRutes.Location = new System.Drawing.Point(41, 158);
            this.dataGridViewRutes.Margin = new System.Windows.Forms.Padding(3, 30, 3, 10);
            this.dataGridViewRutes.Name = "dataGridViewRutes";
            this.dataGridViewRutes.ReadOnly = true;
            this.dataGridViewRutes.RowHeadersWidth = 51;
            this.dataGridViewRutes.Size = new System.Drawing.Size(707, 161);
            this.dataGridViewRutes.TabIndex = 15;
            // 
            // Inici
            // 
            this.Inici.HeaderText = "Inici";
            this.Inici.MinimumWidth = 6;
            this.Inici.Name = "Inici";
            this.Inici.ReadOnly = true;
            this.Inici.Width = 150;
            // 
            // Fi
            // 
            this.Fi.HeaderText = "Fi";
            this.Fi.MinimumWidth = 6;
            this.Fi.Name = "Fi";
            this.Fi.ReadOnly = true;
            this.Fi.Width = 150;
            // 
            // Preu
            // 
            this.Preu.HeaderText = "Preu";
            this.Preu.MinimumWidth = 6;
            this.Preu.Name = "Preu";
            this.Preu.ReadOnly = true;
            this.Preu.Width = 125;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Estació origen";
            this.Origen.MinimumWidth = 6;
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 132;
            // 
            // Desti
            // 
            this.Desti.HeaderText = "Estació destí";
            this.Desti.MinimumWidth = 6;
            this.Desti.Name = "Desti";
            this.Desti.ReadOnly = true;
            this.Desti.Width = 132;
            // 
            // GetRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 430);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetRoutes";
            this.Text = "GetTrackPoints";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCognoms;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridView dataGridViewRutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desti;
    }
}