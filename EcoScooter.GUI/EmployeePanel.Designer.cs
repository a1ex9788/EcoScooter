namespace EcoScooter.GUI
{
    partial class EmployeePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureRent = new System.Windows.Forms.PictureBox();
            this.pictureTorna = new System.Windows.Forms.PictureBox();
            this.pictureLogout = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelWelcome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(3, 8);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(173, 25);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Benvingut pepito";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AccessibleName = "pictureIncident";
            this.flowLayoutPanel1.Controls.Add(this.pictureRent);
            this.flowLayoutPanel1.Controls.Add(this.pictureTorna);
            this.flowLayoutPanel1.Controls.Add(this.pictureLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(671, 403);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureRent
            // 
            this.pictureRent.AccessibleName = "pictureLlogar";
            this.pictureRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureRent.Image = ((System.Drawing.Image)(resources.GetObject("pictureRent.Image")));
            this.pictureRent.Location = new System.Drawing.Point(10, 10);
            this.pictureRent.Margin = new System.Windows.Forms.Padding(10);
            this.pictureRent.Name = "pictureRent";
            this.pictureRent.Size = new System.Drawing.Size(200, 200);
            this.pictureRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRent.TabIndex = 0;
            this.pictureRent.TabStop = false;
            this.pictureRent.Click += new System.EventHandler(this.pictureAddScooter);
            // 
            // pictureTorna
            // 
            this.pictureTorna.AccessibleName = "pictureTornar";
            this.pictureTorna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTorna.Image = ((System.Drawing.Image)(resources.GetObject("pictureTorna.Image")));
            this.pictureTorna.Location = new System.Drawing.Point(230, 10);
            this.pictureTorna.Margin = new System.Windows.Forms.Padding(10);
            this.pictureTorna.Name = "pictureTorna";
            this.pictureTorna.Size = new System.Drawing.Size(200, 200);
            this.pictureTorna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTorna.TabIndex = 2;
            this.pictureTorna.TabStop = false;
            this.pictureTorna.Click += new System.EventHandler(this.pictureAddStation);
            // 
            // pictureLogout
            // 
            this.pictureLogout.AccessibleName = "pictureRecorreguts";
            this.pictureLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogout.Image")));
            this.pictureLogout.Location = new System.Drawing.Point(450, 10);
            this.pictureLogout.Margin = new System.Windows.Forms.Padding(10);
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.Size = new System.Drawing.Size(200, 200);
            this.pictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogout.TabIndex = 5;
            this.pictureLogout.TabStop = false;
            this.pictureLogout.Click += new System.EventHandler(this.pictureLogout_Click);
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeePanel";
            this.Text = "EmpleatPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureRent;
        private System.Windows.Forms.PictureBox pictureTorna;
        private System.Windows.Forms.PictureBox pictureLogout;
        private System.Windows.Forms.Label labelWelcome;
    }
}