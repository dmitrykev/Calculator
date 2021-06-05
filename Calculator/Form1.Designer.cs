
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_eqully = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(11, 9);
            this.label.Name = "label";
            this.label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label.Size = new System.Drawing.Size(258, 70);
            this.label.TabIndex = 0;
            this.label.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(11, 87);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(60, 60);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_division
            // 
            this.button_division.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_division.Location = new System.Drawing.Point(77, 87);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(60, 60);
            this.button_division.TabIndex = 2;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multiply.Location = new System.Drawing.Point(143, 87);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(60, 60);
            this.button_multiply.TabIndex = 3;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_minus.Location = new System.Drawing.Point(209, 87);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(60, 60);
            this.button_minus.TabIndex = 4;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(11, 153);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(60, 60);
            this.button_7.TabIndex = 5;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(77, 153);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(60, 60);
            this.button_8.TabIndex = 6;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(143, 153);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(60, 60);
            this.button_9.TabIndex = 7;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(11, 219);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(60, 60);
            this.button_4.TabIndex = 8;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_5.Location = new System.Drawing.Point(77, 219);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(60, 60);
            this.button_5.TabIndex = 9;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(143, 219);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(60, 60);
            this.button_6.TabIndex = 10;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(11, 285);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(60, 60);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(77, 285);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(60, 60);
            this.button_2.TabIndex = 12;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(143, 285);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(60, 60);
            this.button_3.TabIndex = 13;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dot.Location = new System.Drawing.Point(143, 351);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(60, 60);
            this.button_dot.TabIndex = 14;
            this.button_dot.Text = ",";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(11, 351);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(126, 60);
            this.button_0.TabIndex = 15;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_plus.Location = new System.Drawing.Point(209, 153);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(60, 126);
            this.button_plus.TabIndex = 16;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_eqully
            // 
            this.button_eqully.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_eqully.Location = new System.Drawing.Point(209, 285);
            this.button_eqully.Name = "button_eqully";
            this.button_eqully.Size = new System.Drawing.Size(60, 126);
            this.button_eqully.TabIndex = 17;
            this.button_eqully.Text = "=";
            this.button_eqully.UseVisualStyleBackColor = true;
            this.button_eqully.Click += new System.EventHandler(this.button_equally_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 22);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(280, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_eqully);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_eqully;
        private System.Windows.Forms.Label label2;
    }
}

