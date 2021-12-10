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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.mTBLot = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePark = new System.Windows.Forms.Button();
            this.btnParkAdd = new System.Windows.Forms.Button();
            this.tBParkName = new System.Windows.Forms.TextBox();
            this.lBParking = new System.Windows.Forms.ListBox();
            this.lParking = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(904, 590);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTake);
            this.groupBox1.Controls.Add(this.mTBLot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(911, 284);
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
            // btnRemovePark
            // 
            this.btnRemovePark.Location = new System.Drawing.Point(911, 201);
            this.btnRemovePark.Name = "btnRemovePark";
            this.btnRemovePark.Size = new System.Drawing.Size(134, 23);
            this.btnRemovePark.TabIndex = 13;
            this.btnRemovePark.Text = "Удалить парковку";
            this.btnRemovePark.UseVisualStyleBackColor = true;
            this.btnRemovePark.Click += new System.EventHandler(this.btnRemovePark_Click);
            // 
            // btnParkAdd
            // 
            this.btnParkAdd.Location = new System.Drawing.Point(911, 70);
            this.btnParkAdd.Name = "btnParkAdd";
            this.btnParkAdd.Size = new System.Drawing.Size(134, 23);
            this.btnParkAdd.TabIndex = 12;
            this.btnParkAdd.Text = "Добавить парковку";
            this.btnParkAdd.UseVisualStyleBackColor = true;
            this.btnParkAdd.Click += new System.EventHandler(this.btnParkAdd_Click);
            // 
            // tBParkName
            // 
            this.tBParkName.Location = new System.Drawing.Point(911, 43);
            this.tBParkName.Name = "tBParkName";
            this.tBParkName.Size = new System.Drawing.Size(134, 20);
            this.tBParkName.TabIndex = 11;
            // 
            // lBParking
            // 
            this.lBParking.FormattingEnabled = true;
            this.lBParking.Location = new System.Drawing.Point(911, 99);
            this.lBParking.Name = "lBParking";
            this.lBParking.Size = new System.Drawing.Size(134, 95);
            this.lBParking.TabIndex = 10;
            this.lBParking.SelectedIndexChanged += new System.EventHandler(this.lBParking_SelectedIndexChanged);
            // 
            // lParking
            // 
            this.lParking.AutoSize = true;
            this.lParking.Location = new System.Drawing.Point(949, 27);
            this.lParking.Name = "lParking";
            this.lParking.Size = new System.Drawing.Size(57, 13);
            this.lParking.TabIndex = 9;
            this.lParking.Text = "Парковки";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(911, 230);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(134, 48);
            this.btnChoose.TabIndex = 14;
            this.btnChoose.Text = "Добавить";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // GavanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 617);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnRemovePark);
            this.Controls.Add(this.btnParkAdd);
            this.Controls.Add(this.tBParkName);
            this.Controls.Add(this.lBParking);
            this.Controls.Add(this.lParking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GavanForm";
            this.Text = "Gavan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.MaskedTextBox mTBLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePark;
        private System.Windows.Forms.Button btnParkAdd;
        private System.Windows.Forms.TextBox tBParkName;
        private System.Windows.Forms.ListBox lBParking;
        private System.Windows.Forms.Label lParking;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}