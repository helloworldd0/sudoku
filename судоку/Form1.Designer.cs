namespace судоку
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.easyMode = new System.Windows.Forms.Button();
            this.mediumMode = new System.Windows.Forms.Button();
            this.hardMode = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // easyMode
            // 
            this.easyMode.BackColor = System.Drawing.Color.Cornsilk;
            this.easyMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easyMode.Location = new System.Drawing.Point(267, 143);
            this.easyMode.Name = "easyMode";
            this.easyMode.Size = new System.Drawing.Size(255, 60);
            this.easyMode.TabIndex = 0;
            this.easyMode.Text = "Лёгкий";
            this.easyMode.UseVisualStyleBackColor = false;
            this.easyMode.Click += new System.EventHandler(this.easyMode_Click_1);
            this.easyMode.MouseEnter += new System.EventHandler(this.easyMode_MouseEnter);
            this.easyMode.MouseLeave += new System.EventHandler(this.easyMode_MouseLeave);
            // 
            // mediumMode
            // 
            this.mediumMode.BackColor = System.Drawing.Color.PeachPuff;
            this.mediumMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediumMode.Location = new System.Drawing.Point(267, 219);
            this.mediumMode.Name = "mediumMode";
            this.mediumMode.Size = new System.Drawing.Size(255, 60);
            this.mediumMode.TabIndex = 1;
            this.mediumMode.Text = "Средний";
            this.mediumMode.UseVisualStyleBackColor = false;
            this.mediumMode.Click += new System.EventHandler(this.mediumMode_Click);
            this.mediumMode.MouseEnter += new System.EventHandler(this.mediumMode_MouseEnter);
            this.mediumMode.MouseLeave += new System.EventHandler(this.mediumMode_MouseLeave);
            // 
            // hardMode
            // 
            this.hardMode.BackColor = System.Drawing.Color.LightSalmon;
            this.hardMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardMode.Location = new System.Drawing.Point(267, 294);
            this.hardMode.Name = "hardMode";
            this.hardMode.Size = new System.Drawing.Size(255, 60);
            this.hardMode.TabIndex = 2;
            this.hardMode.Text = "Сложный";
            this.hardMode.UseVisualStyleBackColor = false;
            this.hardMode.Click += new System.EventHandler(this.hardMode_Click);
            this.hardMode.MouseEnter += new System.EventHandler(this.hardMode_MouseEnter);
            this.hardMode.MouseLeave += new System.EventHandler(this.hardMode_MouseLeave);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.PaleGreen;
            this.text.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.text.Location = new System.Drawing.Point(180, 75);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(432, 44);
            this.text.TabIndex = 3;
            this.text.Text = "Уровень сложности";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(746, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.hardMode);
            this.Controls.Add(this.mediumMode);
            this.Controls.Add(this.easyMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyMode;
        private System.Windows.Forms.Button mediumMode;
        private System.Windows.Forms.Button hardMode;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

