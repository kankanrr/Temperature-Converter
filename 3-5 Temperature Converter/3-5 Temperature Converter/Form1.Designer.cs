namespace _3_5_Temperature_Converter
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputCelsius = new System.Windows.Forms.Label();
            this.buttonConvertCelsius = new System.Windows.Forms.Button();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputFahrenheit = new System.Windows.Forms.Label();
            this.buttonConvertFahrenheit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(31, 240);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(124, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(186, 239);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(124, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.outputCelsius);
            this.groupBox1.Controls.Add(this.buttonConvertCelsius);
            this.groupBox1.Controls.Add(this.textBoxCelsius);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert °F to °C";
            // 
            // outputCelsius
            // 
            this.outputCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCelsius.Location = new System.Drawing.Point(152, 56);
            this.outputCelsius.Name = "outputCelsius";
            this.outputCelsius.Size = new System.Drawing.Size(103, 18);
            this.outputCelsius.TabIndex = 8;
            this.outputCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConvertCelsius
            // 
            this.buttonConvertCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertCelsius.Location = new System.Drawing.Point(13, 51);
            this.buttonConvertCelsius.Name = "buttonConvertCelsius";
            this.buttonConvertCelsius.Size = new System.Drawing.Size(124, 23);
            this.buttonConvertCelsius.TabIndex = 2;
            this.buttonConvertCelsius.Text = "Convert to Celsius";
            this.buttonConvertCelsius.UseVisualStyleBackColor = true;
            this.buttonConvertCelsius.Click += new System.EventHandler(this.buttonConvertCelsius_Click);
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCelsius.Location = new System.Drawing.Point(152, 19);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(103, 20);
            this.textBoxCelsius.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Controls.Add(this.textBoxFahrenheit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.outputFahrenheit);
            this.groupBox2.Controls.Add(this.buttonConvertFahrenheit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 93);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert °C to °F";
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFahrenheit.Location = new System.Drawing.Point(152, 20);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.Size = new System.Drawing.Size(103, 20);
            this.textBoxFahrenheit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Temperature";
            // 
            // outputFahrenheit
            // 
            this.outputFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFahrenheit.Location = new System.Drawing.Point(152, 58);
            this.outputFahrenheit.Name = "outputFahrenheit";
            this.outputFahrenheit.Size = new System.Drawing.Size(103, 18);
            this.outputFahrenheit.TabIndex = 7;
            this.outputFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConvertFahrenheit
            // 
            this.buttonConvertFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertFahrenheit.Location = new System.Drawing.Point(13, 58);
            this.buttonConvertFahrenheit.Name = "buttonConvertFahrenheit";
            this.buttonConvertFahrenheit.Size = new System.Drawing.Size(124, 23);
            this.buttonConvertFahrenheit.TabIndex = 5;
            this.buttonConvertFahrenheit.Text = "Convert to Fahrenheit";
            this.buttonConvertFahrenheit.UseVisualStyleBackColor = true;
            this.buttonConvertFahrenheit.Click += new System.EventHandler(this.buttonConvertFahrenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label outputCelsius;
        private System.Windows.Forms.Button buttonConvertCelsius;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFahrenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputFahrenheit;
        private System.Windows.Forms.Button buttonConvertFahrenheit;
    }
}

