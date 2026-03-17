namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.results = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_procent = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_qual = new System.Windows.Forms.Button();
            this.btn_AC = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.oldresults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.results.Font = new System.Drawing.Font("Arial Narrow", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.results.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.results.Location = new System.Drawing.Point(-1, 15);
            this.results.Margin = new System.Windows.Forms.Padding(0);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(375, 86);
            this.results.TabIndex = 0;
            this.results.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_1.Location = new System.Drawing.Point(17, 187);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(80, 80);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_2.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_2.Location = new System.Drawing.Point(103, 187);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(80, 80);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_3.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_3.Location = new System.Drawing.Point(189, 187);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(80, 80);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_6.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_6.Location = new System.Drawing.Point(189, 273);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(80, 80);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_5.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_5.Location = new System.Drawing.Point(103, 273);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(80, 80);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_4.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_4.Location = new System.Drawing.Point(17, 273);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(80, 80);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_9.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_9.Location = new System.Drawing.Point(189, 359);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(80, 80);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_8.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_8.Location = new System.Drawing.Point(103, 359);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(80, 80);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_7.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_7.Location = new System.Drawing.Point(17, 359);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(80, 80);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_0.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_0.Location = new System.Drawing.Point(103, 445);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(80, 80);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_procent
            // 
            this.btn_procent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_procent.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_procent.Location = new System.Drawing.Point(17, 445);
            this.btn_procent.Name = "btn_procent";
            this.btn_procent.Size = new System.Drawing.Size(80, 80);
            this.btn_procent.TabIndex = 11;
            this.btn_procent.Text = "%";
            this.btn_procent.UseVisualStyleBackColor = false;
            this.btn_procent.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_dot.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_dot.Location = new System.Drawing.Point(189, 445);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(80, 80);
            this.btn_dot.TabIndex = 12;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_plus.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_plus.Location = new System.Drawing.Point(277, 187);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(80, 80);
            this.btn_plus.TabIndex = 13;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minus.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_minus.Location = new System.Drawing.Point(277, 273);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(80, 80);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_qual
            // 
            this.btn_qual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_qual.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_qual.Location = new System.Drawing.Point(275, 359);
            this.btn_qual.Name = "btn_qual";
            this.btn_qual.Size = new System.Drawing.Size(80, 166);
            this.btn_qual.TabIndex = 15;
            this.btn_qual.Text = "=";
            this.btn_qual.UseVisualStyleBackColor = false;
            this.btn_qual.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_AC
            // 
            this.btn_AC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AC.Font = new System.Drawing.Font("Arial", 28F);
            this.btn_AC.Location = new System.Drawing.Point(17, 101);
            this.btn_AC.Name = "btn_AC";
            this.btn_AC.Size = new System.Drawing.Size(80, 80);
            this.btn_AC.TabIndex = 16;
            this.btn_AC.Text = "AC";
            this.btn_AC.UseVisualStyleBackColor = false;
            this.btn_AC.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_division.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_division.Location = new System.Drawing.Point(103, 101);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(80, 80);
            this.btn_division.TabIndex = 17;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_multi.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_multi.Location = new System.Drawing.Point(189, 101);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(80, 80);
            this.btn_multi.TabIndex = 18;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_back.Location = new System.Drawing.Point(277, 101);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(80, 80);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // oldresults
            // 
            this.oldresults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldresults.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldresults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oldresults.Location = new System.Drawing.Point(17, -2);
            this.oldresults.Margin = new System.Windows.Forms.Padding(0);
            this.oldresults.Name = "oldresults";
            this.oldresults.Size = new System.Drawing.Size(340, 30);
            this.oldresults.TabIndex = 20;
            this.oldresults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(374, 543);
            this.Controls.Add(this.oldresults);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_AC);
            this.Controls.Add(this.btn_qual);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_procent);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.results);
            this.Name = "Calculator";
            this.Text = "Calculator by f0ldeR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_procent;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_qual;
        private System.Windows.Forms.Button btn_AC;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label oldresults;
    }
}

