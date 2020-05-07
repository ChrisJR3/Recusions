namespace Recusions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.factorialButton = new System.Windows.Forms.Button();
            this.factorialInput = new System.Windows.Forms.TextBox();
            this.factorialOutput = new System.Windows.Forms.Label();
            this.gcdOutput = new System.Windows.Forms.Label();
            this.gcd1Input = new System.Windows.Forms.TextBox();
            this.gcd2Input = new System.Windows.Forms.TextBox();
            this.gcdButton = new System.Windows.Forms.Button();
            this.hanoiButton = new System.Windows.Forms.Button();
            this.hanoiOutput = new System.Windows.Forms.Label();
            this.scrambleInput = new System.Windows.Forms.TextBox();
            this.scrambleButton = new System.Windows.Forms.Button();
            this.scrambleOutput = new System.Windows.Forms.Label();
            this.number1Label = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.facLabel = new System.Windows.Forms.Label();
            this.stringLabel = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // factorialButton
            // 
            this.factorialButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialButton.Location = new System.Drawing.Point(191, 39);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(86, 43);
            this.factorialButton.TabIndex = 0;
            this.factorialButton.Text = "Factorial";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // factorialInput
            // 
            this.factorialInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialInput.Location = new System.Drawing.Point(112, 49);
            this.factorialInput.Name = "factorialInput";
            this.factorialInput.Size = new System.Drawing.Size(55, 25);
            this.factorialInput.TabIndex = 1;
            // 
            // factorialOutput
            // 
            this.factorialOutput.BackColor = System.Drawing.Color.White;
            this.factorialOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.factorialOutput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialOutput.Location = new System.Drawing.Point(40, 95);
            this.factorialOutput.Name = "factorialOutput";
            this.factorialOutput.Size = new System.Drawing.Size(237, 26);
            this.factorialOutput.TabIndex = 2;
            this.factorialOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcdOutput
            // 
            this.gcdOutput.BackColor = System.Drawing.Color.White;
            this.gcdOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcdOutput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcdOutput.Location = new System.Drawing.Point(40, 236);
            this.gcdOutput.Name = "gcdOutput";
            this.gcdOutput.Size = new System.Drawing.Size(237, 28);
            this.gcdOutput.TabIndex = 3;
            this.gcdOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcd1Input
            // 
            this.gcd1Input.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcd1Input.Location = new System.Drawing.Point(112, 170);
            this.gcd1Input.Name = "gcd1Input";
            this.gcd1Input.Size = new System.Drawing.Size(55, 25);
            this.gcd1Input.TabIndex = 4;
            // 
            // gcd2Input
            // 
            this.gcd2Input.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcd2Input.Location = new System.Drawing.Point(112, 198);
            this.gcd2Input.Name = "gcd2Input";
            this.gcd2Input.Size = new System.Drawing.Size(55, 25);
            this.gcd2Input.TabIndex = 5;
            // 
            // gcdButton
            // 
            this.gcdButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcdButton.Location = new System.Drawing.Point(191, 170);
            this.gcdButton.Name = "gcdButton";
            this.gcdButton.Size = new System.Drawing.Size(86, 50);
            this.gcdButton.TabIndex = 6;
            this.gcdButton.Text = "GCD";
            this.gcdButton.UseVisualStyleBackColor = true;
            this.gcdButton.Click += new System.EventHandler(this.gcdButton_Click);
            // 
            // hanoiButton
            // 
            this.hanoiButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanoiButton.Location = new System.Drawing.Point(366, 39);
            this.hanoiButton.Name = "hanoiButton";
            this.hanoiButton.Size = new System.Drawing.Size(86, 43);
            this.hanoiButton.TabIndex = 7;
            this.hanoiButton.Text = "Hanoi";
            this.hanoiButton.UseVisualStyleBackColor = true;
            this.hanoiButton.Click += new System.EventHandler(this.hanoiButton_Click);
            // 
            // hanoiOutput
            // 
            this.hanoiOutput.BackColor = System.Drawing.Color.White;
            this.hanoiOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hanoiOutput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanoiOutput.Location = new System.Drawing.Point(362, 99);
            this.hanoiOutput.Name = "hanoiOutput";
            this.hanoiOutput.Size = new System.Drawing.Size(239, 417);
            this.hanoiOutput.TabIndex = 8;
            // 
            // scrambleInput
            // 
            this.scrambleInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrambleInput.Location = new System.Drawing.Point(112, 319);
            this.scrambleInput.Name = "scrambleInput";
            this.scrambleInput.Size = new System.Drawing.Size(56, 25);
            this.scrambleInput.TabIndex = 9;
            // 
            // scrambleButton
            // 
            this.scrambleButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrambleButton.Location = new System.Drawing.Point(188, 309);
            this.scrambleButton.Name = "scrambleButton";
            this.scrambleButton.Size = new System.Drawing.Size(86, 43);
            this.scrambleButton.TabIndex = 10;
            this.scrambleButton.Text = "Scramble";
            this.scrambleButton.UseVisualStyleBackColor = true;
            this.scrambleButton.Click += new System.EventHandler(this.scrambleButton_Click);
            // 
            // scrambleOutput
            // 
            this.scrambleOutput.BackColor = System.Drawing.Color.White;
            this.scrambleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scrambleOutput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrambleOutput.Location = new System.Drawing.Point(40, 368);
            this.scrambleOutput.Name = "scrambleOutput";
            this.scrambleOutput.Size = new System.Drawing.Size(237, 148);
            this.scrambleOutput.TabIndex = 11;
            this.scrambleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number1Label
            // 
            this.number1Label.AutoSize = true;
            this.number1Label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1Label.Location = new System.Drawing.Point(36, 173);
            this.number1Label.Name = "number1Label";
            this.number1Label.Size = new System.Drawing.Size(71, 19);
            this.number1Label.TabIndex = 12;
            this.number1Label.Text = "Number 1";
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Label.Location = new System.Drawing.Point(36, 203);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(71, 19);
            this.number2Label.TabIndex = 13;
            this.number2Label.Text = "Number 2";
            // 
            // facLabel
            // 
            this.facLabel.AutoSize = true;
            this.facLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facLabel.Location = new System.Drawing.Point(36, 52);
            this.facLabel.Name = "facLabel";
            this.facLabel.Size = new System.Drawing.Size(60, 19);
            this.facLabel.TabIndex = 14;
            this.facLabel.Text = "Factorial";
            // 
            // stringLabel
            // 
            this.stringLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringLabel.Location = new System.Drawing.Point(39, 309);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(67, 46);
            this.stringLabel.TabIndex = 15;
            this.stringLabel.Text = "String (max 4)";
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.Black;
            this.lineLabel.Location = new System.Drawing.Point(315, 39);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(10, 477);
            this.lineLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 554);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.facLabel);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number1Label);
            this.Controls.Add(this.scrambleOutput);
            this.Controls.Add(this.scrambleButton);
            this.Controls.Add(this.scrambleInput);
            this.Controls.Add(this.hanoiOutput);
            this.Controls.Add(this.hanoiButton);
            this.Controls.Add(this.gcdButton);
            this.Controls.Add(this.gcd2Input);
            this.Controls.Add(this.gcd1Input);
            this.Controls.Add(this.gcdOutput);
            this.Controls.Add(this.factorialOutput);
            this.Controls.Add(this.factorialInput);
            this.Controls.Add(this.factorialButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Recursion Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.TextBox factorialInput;
        private System.Windows.Forms.Label factorialOutput;
        private System.Windows.Forms.Label gcdOutput;
        private System.Windows.Forms.TextBox gcd1Input;
        private System.Windows.Forms.TextBox gcd2Input;
        private System.Windows.Forms.Button gcdButton;
        private System.Windows.Forms.Button hanoiButton;
        private System.Windows.Forms.Label hanoiOutput;
        private System.Windows.Forms.TextBox scrambleInput;
        private System.Windows.Forms.Button scrambleButton;
        private System.Windows.Forms.Label scrambleOutput;
        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.Label facLabel;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label lineLabel;
    }
}

