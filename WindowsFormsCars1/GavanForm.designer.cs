namespace WindowsFormsCars1
{
    partial class GavanForm
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.btnParkBoat = new System.Windows.Forms.Button();
            this.btnParkCater = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.mTBLot = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(904, 590);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // btnParkBoat
            // 
            this.btnParkBoat.Location = new System.Drawing.Point(911, 12);
            this.btnParkBoat.Name = "btnParkBoat";
            this.btnParkBoat.Size = new System.Drawing.Size(134, 48);
            this.btnParkBoat.TabIndex = 1;
            this.btnParkBoat.Text = "Поставить судно";
            this.btnParkBoat.UseVisualStyleBackColor = true;
            this.btnParkBoat.Click += new System.EventHandler(this.btnParkBoat_Click);
            // 
            // btnParkCater
            // 
            this.btnParkCater.Location = new System.Drawing.Point(911, 67);
            this.btnParkCater.Name = "btnParkCater";
            this.btnParkCater.Size = new System.Drawing.Size(134, 48);
            this.btnParkCater.TabIndex = 2;
            this.btnParkCater.Text = "Поставить катер";
            this.btnParkCater.UseVisualStyleBackColor = true;
            this.btnParkCater.Click += new System.EventHandler(this.btnParkCater_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTake);
            this.groupBox1.Controls.Add(this.mTBLot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(911, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать транспорт";
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(29, 71);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 3;
            this.btnTake.Text = "Забрать";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // mTBLot
            // 
            this.mTBLot.Location = new System.Drawing.Point(52, 45);
            this.mTBLot.Mask = "09";
            this.mTBLot.Name = "mTBLot";
            this.mTBLot.Size = new System.Drawing.Size(52, 20);
            this.mTBLot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // GavanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnParkCater);
            this.Controls.Add(this.btnParkBoat);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "GavanForm";
            this.Text = "Gavan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button btnParkBoat;
        private System.Windows.Forms.Button btnParkCater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.MaskedTextBox mTBLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}