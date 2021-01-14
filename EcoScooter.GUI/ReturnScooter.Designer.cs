namespace EcoScooter.GUI
{
    partial class ReturnScooter
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIBAN = new System.Windows.Forms.Label();
            this.comboBoxIDStation = new System.Windows.Forms.ComboBox();
            this.labelErrorRent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelErrorRent, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(38, 41, 38, 20);
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(538, 289);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(53, 65);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 118);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estació";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.64789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.35211F));
            this.tableLayoutPanel2.Controls.Add(this.labelIBAN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxIDStation, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 41, 75, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(426, 99);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labelIBAN
            // 
            this.labelIBAN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIBAN.AutoSize = true;
            this.labelIBAN.Location = new System.Drawing.Point(20, 34);
            this.labelIBAN.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelIBAN.Name = "labelIBAN";
            this.labelIBAN.Size = new System.Drawing.Size(52, 30);
            this.labelIBAN.TabIndex = 1;
            this.labelIBAN.Text = "ID de l\'estació";
            // 
            // comboBoxIDStation
            // 
            this.comboBoxIDStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxIDStation.DisplayMember = "Stations";
            this.comboBoxIDStation.FormattingEnabled = true;
            this.comboBoxIDStation.Location = new System.Drawing.Point(205, 38);
            this.comboBoxIDStation.Name = "comboBoxIDStation";
            this.comboBoxIDStation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDStation.TabIndex = 2;
            this.comboBoxIDStation.ValueMember = "Stations";
            // 
            // labelErrorRent
            // 
            this.labelErrorRent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelErrorRent.AutoSize = true;
            this.labelErrorRent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelErrorRent.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRent.Location = new System.Drawing.Point(222, 254);
            this.labelErrorRent.Name = "labelErrorRent";
            this.labelErrorRent.Size = new System.Drawing.Size(275, 15);
            this.labelErrorRent.TabIndex = 9;
            this.labelErrorRent.Text = "No hi ha patinets disponibles per aquesta estació";
            this.labelErrorRent.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(202)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(431, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tornar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.TornaScooter);
            // 
            // ReturnScooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 289);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "ReturnScooter";
            this.Text = "ReturnScooter";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelIBAN;
        private System.Windows.Forms.ComboBox comboBoxIDStation;
        private System.Windows.Forms.Label labelErrorRent;
        private System.Windows.Forms.Button button1;
    }
}