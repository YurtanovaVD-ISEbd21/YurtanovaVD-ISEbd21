namespace WindowsFormTruck
{
    partial class FormTruck
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
            this.buttonCreateTruck = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxTrucks = new System.Windows.Forms.PictureBox();
            this.buttonCreateAotutruck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrucks)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateTruck
            // 
            this.buttonCreateTruck.Location = new System.Drawing.Point(616, 15);
            this.buttonCreateTruck.Name = "buttonCreateTruck";
            this.buttonCreateTruck.Size = new System.Drawing.Size(109, 53);
            this.buttonCreateTruck.TabIndex = 1;
            this.buttonCreateTruck.Text = "Создать грузовик ";
            this.buttonCreateTruck.UseVisualStyleBackColor = true;
            this.buttonCreateTruck.Click += new System.EventHandler(this.buttonCreateTruck_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormTruck.Properties.Resources.стрелка;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(799, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormTruck.Properties.Resources.право;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(835, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormTruck.Properties.Resources.лево;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(763, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormTruck.Properties.Resources.вверх;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(799, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxTrucks
            // 
            this.pictureBoxTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTrucks.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrucks.Name = "pictureBoxTrucks";
            this.pictureBoxTrucks.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTrucks.TabIndex = 0;
            this.pictureBoxTrucks.TabStop = false;
            // 
            // buttonCreateAotutruck
            // 
            this.buttonCreateAotutruck.Location = new System.Drawing.Point(731, 18);
            this.buttonCreateAotutruck.Name = "buttonCreateAotutruck";
            this.buttonCreateAotutruck.Size = new System.Drawing.Size(108, 50);
            this.buttonCreateAotutruck.TabIndex = 6;
            this.buttonCreateAotutruck.Text = "Создать грузовик полуприцеп";
            this.buttonCreateAotutruck.UseVisualStyleBackColor = true;
            this.buttonCreateAotutruck.Click += new System.EventHandler(this.buttonCreateAutotruck_Click);
            // 
            // FormTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreateAotutruck);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateTruck);
            this.Controls.Add(this.pictureBoxTrucks);
            this.Name = "FormTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Грузовик-полуприцеп ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrucks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrucks;
        private System.Windows.Forms.Button buttonCreateTruck;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateAotutruck;
    }
}
