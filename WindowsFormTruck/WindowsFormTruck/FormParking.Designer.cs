namespace WindowsFormTruck
{
    partial class FormParking
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
            this.buttonSetTruck = new System.Windows.Forms.Button();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetAotutruck = new System.Windows.Forms.Button();
            this.Take = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxTake = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetTruck
            // 
            this.buttonSetTruck.Location = new System.Drawing.Point(902, 126);
            this.buttonSetTruck.Name = "buttonSetTruck";
            this.buttonSetTruck.Size = new System.Drawing.Size(109, 53);
            this.buttonSetTruck.TabIndex = 1;
            this.buttonSetTruck.Text = "Припарковать грузовик ";
            this.buttonSetTruck.UseVisualStyleBackColor = true;
            this.buttonSetTruck.Click += new System.EventHandler(this.buttonSetTruck_Click);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1048, 493);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetAotutruck
            // 
            this.buttonSetAotutruck.Location = new System.Drawing.Point(903, 185);
            this.buttonSetAotutruck.Name = "buttonSetAotutruck";
            this.buttonSetAotutruck.Size = new System.Drawing.Size(108, 50);
            this.buttonSetAotutruck.TabIndex = 6;
            this.buttonSetAotutruck.Text = "Припарковать  грузовик полуприцеп";
            this.buttonSetAotutruck.UseVisualStyleBackColor = true;
            this.buttonSetAotutruck.Click += new System.EventHandler(this.buttonSetAotutruck_Click);
            // 
            // Take
            // 
            this.Take.AutoSize = true;
            this.Take.Location = new System.Drawing.Point(883, 250);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(91, 13);
            this.Take.TabIndex = 7;
            this.Take.Text = "Забрать машину";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(886, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Место:";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(886, 294);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 9;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTake.Location = new System.Drawing.Point(886, 323);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(136, 117);
            this.pictureBoxTake.TabIndex = 10;
            this.pictureBoxTake.TabStop = false;
            // 
            // maskedTextBoxTake
            // 
            this.maskedTextBoxTake.Location = new System.Drawing.Point(943, 268);
            this.maskedTextBoxTake.Name = "maskedTextBoxTake";
            this.maskedTextBoxTake.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxTake.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(902, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Уровни:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.maskedTextBoxTake);
            this.Controls.Add(this.pictureBoxTake);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Take);
            this.Controls.Add(this.buttonSetAotutruck);
            this.Controls.Add(this.buttonSetTruck);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парковка ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetTruck;
        private System.Windows.Forms.Button buttonSetAotutruck;
        private System.Windows.Forms.Label Take;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTake;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}
