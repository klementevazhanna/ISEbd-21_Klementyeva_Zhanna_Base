namespace WindowsFormsCars1
{
	 public partial class FormCar
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonСreate = new System.Windows.Forms.Button();
            this.buttonLeft1 = new System.Windows.Forms.Button();
            this.buttonRight1 = new System.Windows.Forms.Button();
            this.buttonUp1 = new System.Windows.Forms.Button();
            this.buttonDown1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonСreate
            // 
            this.buttonСreate.Location = new System.Drawing.Point(435, 375);
            this.buttonСreate.Name = "buttonСreate";
            this.buttonСreate.Size = new System.Drawing.Size(213, 55);
            this.buttonСreate.TabIndex = 1;
            this.buttonСreate.Text = "Создать";
            this.buttonСreate.UseVisualStyleBackColor = true;
            this.buttonСreate.Click += new System.EventHandler(this.buttonСreate_Click);
            // 
            // buttonLeft1
            // 
            this.buttonLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft1.BackgroundImage = global::WindowsFormsCars1.Properties.Resources.влево_кружок;
            this.buttonLeft1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft1.Location = new System.Drawing.Point(753, 408);
            this.buttonLeft1.Name = "buttonLeft1";
            this.buttonLeft1.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft1.TabIndex = 2;
            this.buttonLeft1.UseVisualStyleBackColor = true;
            this.buttonLeft1.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight1
            // 
            this.buttonRight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight1.BackgroundImage = global::WindowsFormsCars1.Properties.Resources.вправо111;
            this.buttonRight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight1.Location = new System.Drawing.Point(825, 408);
            this.buttonRight1.Name = "buttonRight1";
            this.buttonRight1.Size = new System.Drawing.Size(30, 30);
            this.buttonRight1.TabIndex = 3;
            this.buttonRight1.UseVisualStyleBackColor = true;
            this.buttonRight1.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp1
            // 
            this.buttonUp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp1.BackgroundImage = global::WindowsFormsCars1.Properties.Resources.вверх_кружок1;
            this.buttonUp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp1.Location = new System.Drawing.Point(789, 375);
            this.buttonUp1.Name = "buttonUp1";
            this.buttonUp1.Size = new System.Drawing.Size(30, 30);
            this.buttonUp1.TabIndex = 4;
            this.buttonUp1.UseVisualStyleBackColor = true;
            this.buttonUp1.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown1
            // 
            this.buttonDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown1.BackgroundImage = global::WindowsFormsCars1.Properties.Resources.вниз_кружок;
            this.buttonDown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown1.Location = new System.Drawing.Point(789, 408);
            this.buttonDown1.Name = "buttonDown1";
            this.buttonDown1.Size = new System.Drawing.Size(30, 30);
            this.buttonDown1.TabIndex = 5;
            this.buttonDown1.UseVisualStyleBackColor = true;
            this.buttonDown1.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormCar
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonDown1);
            this.Controls.Add(this.buttonUp1);
            this.Controls.Add(this.buttonRight1);
            this.Controls.Add(this.buttonLeft1);
            this.Controls.Add(this.buttonСreate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FormCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCars;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		protected System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonСreate;
		private System.Windows.Forms.Button buttonLeft1;
		private System.Windows.Forms.Button buttonRight1;
		private System.Windows.Forms.Button buttonUp1;
		private System.Windows.Forms.Button buttonDown1;
    }
}

