namespace ThreadsLab
{
    partial class Form1
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
            this.ObjectCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaybieTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaybieCorrect = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SleepTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SleepCorrect = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LockTime = new System.Windows.Forms.Label();
            this.LockCorrect = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ProgresInfo1 = new System.Windows.Forms.Label();
            this.ProgresInfo2 = new System.Windows.Forms.Label();
            this.ProgresInfo3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectCount
            // 
            this.ObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ObjectCount.Location = new System.Drawing.Point(12, 39);
            this.ObjectCount.Name = "ObjectCount";
            this.ObjectCount.Size = new System.Drawing.Size(122, 26);
            this.ObjectCount.TabIndex = 0;
            this.ObjectCount.Text = "1000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość obiektów";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgresInfo1);
            this.groupBox1.Controls.Add(this.MaybieCorrect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MaybieTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(140, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Może się uda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProgresInfo2);
            this.groupBox2.Controls.Add(this.SleepCorrect);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SleepTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(140, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sleep";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProgresInfo3);
            this.groupBox3.Controls.Add(this.LockCorrect);
            this.groupBox3.Controls.Add(this.LockTime);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(140, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Czas:";
            // 
            // MaybieTime
            // 
            this.MaybieTime.AutoSize = true;
            this.MaybieTime.Location = new System.Drawing.Point(127, 27);
            this.MaybieTime.Name = "MaybieTime";
            this.MaybieTime.Size = new System.Drawing.Size(27, 20);
            this.MaybieTime.TabIndex = 1;
            this.MaybieTime.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Poprawność:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MaybieCorrect
            // 
            this.MaybieCorrect.AutoSize = true;
            this.MaybieCorrect.Location = new System.Drawing.Point(127, 57);
            this.MaybieCorrect.Name = "MaybieCorrect";
            this.MaybieCorrect.Size = new System.Drawing.Size(33, 20);
            this.MaybieCorrect.TabIndex = 3;
            this.MaybieCorrect.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Czas:";
            // 
            // SleepTime
            // 
            this.SleepTime.AutoSize = true;
            this.SleepTime.Location = new System.Drawing.Point(127, 27);
            this.SleepTime.Name = "SleepTime";
            this.SleepTime.Size = new System.Drawing.Size(27, 20);
            this.SleepTime.TabIndex = 2;
            this.SleepTime.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Poprawność:";
            // 
            // SleepCorrect
            // 
            this.SleepCorrect.AutoSize = true;
            this.SleepCorrect.Location = new System.Drawing.Point(127, 57);
            this.SleepCorrect.Name = "SleepCorrect";
            this.SleepCorrect.Size = new System.Drawing.Size(33, 20);
            this.SleepCorrect.TabIndex = 4;
            this.SleepCorrect.Text = "0%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Czas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Poprawność:";
            // 
            // LockTime
            // 
            this.LockTime.AutoSize = true;
            this.LockTime.Location = new System.Drawing.Point(127, 27);
            this.LockTime.Name = "LockTime";
            this.LockTime.Size = new System.Drawing.Size(27, 20);
            this.LockTime.TabIndex = 3;
            this.LockTime.Text = "00";
            // 
            // LockCorrect
            // 
            this.LockCorrect.AutoSize = true;
            this.LockCorrect.Location = new System.Drawing.Point(127, 57);
            this.LockCorrect.Name = "LockCorrect";
            this.LockCorrect.Size = new System.Drawing.Size(33, 20);
            this.LockCorrect.TabIndex = 4;
            this.LockCorrect.Text = "0%";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartButton.Location = new System.Drawing.Point(12, 86);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(122, 36);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ProgresInfo1
            // 
            this.ProgresInfo1.AutoSize = true;
            this.ProgresInfo1.Location = new System.Drawing.Point(6, 90);
            this.ProgresInfo1.Name = "ProgresInfo1";
            this.ProgresInfo1.Size = new System.Drawing.Size(92, 20);
            this.ProgresInfo1.TabIndex = 4;
            this.ProgresInfo1.Text = "Rozpocznij";
            // 
            // ProgresInfo2
            // 
            this.ProgresInfo2.AutoSize = true;
            this.ProgresInfo2.Location = new System.Drawing.Point(6, 88);
            this.ProgresInfo2.Name = "ProgresInfo2";
            this.ProgresInfo2.Size = new System.Drawing.Size(92, 20);
            this.ProgresInfo2.TabIndex = 5;
            this.ProgresInfo2.Text = "Rozpocznij";
            // 
            // ProgresInfo3
            // 
            this.ProgresInfo3.AutoSize = true;
            this.ProgresInfo3.Location = new System.Drawing.Point(6, 88);
            this.ProgresInfo3.Name = "ProgresInfo3";
            this.ProgresInfo3.Size = new System.Drawing.Size(92, 20);
            this.ProgresInfo3.TabIndex = 6;
            this.ProgresInfo3.Text = "Rozpocznij";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 397);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjectCount);
            this.Name = "Form1";
            this.Text = "Wątki";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ObjectCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MaybieCorrect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MaybieTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SleepCorrect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SleepTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LockCorrect;
        private System.Windows.Forms.Label LockTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ProgresInfo1;
        private System.Windows.Forms.Label ProgresInfo2;
        private System.Windows.Forms.Label ProgresInfo3;
    }
}

