
namespace Conversions
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.inchestocmLabel = new System.Windows.Forms.Label();
            this.feettocmLabel = new System.Windows.Forms.Label();
            this.yardstomLabel = new System.Windows.Forms.Label();
            this.mitokmsLabel = new System.Windows.Forms.Label();
            this.conversionChoiceLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.choiceInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.ConvetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(110, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(260, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversions";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inchestocmLabel
            // 
            this.inchestocmLabel.Location = new System.Drawing.Point(155, 69);
            this.inchestocmLabel.Name = "inchestocmLabel";
            this.inchestocmLabel.Size = new System.Drawing.Size(142, 23);
            this.inchestocmLabel.TabIndex = 1;
            this.inchestocmLabel.Text = "1. Inches to Centimeters";
            // 
            // feettocmLabel
            // 
            this.feettocmLabel.Location = new System.Drawing.Point(155, 104);
            this.feettocmLabel.Name = "feettocmLabel";
            this.feettocmLabel.Size = new System.Drawing.Size(142, 23);
            this.feettocmLabel.TabIndex = 2;
            this.feettocmLabel.Text = "2. Feet to Centimetres";
            // 
            // yardstomLabel
            // 
            this.yardstomLabel.Location = new System.Drawing.Point(155, 140);
            this.yardstomLabel.Name = "yardstomLabel";
            this.yardstomLabel.Size = new System.Drawing.Size(142, 23);
            this.yardstomLabel.TabIndex = 3;
            this.yardstomLabel.Text = "3. Yards to Metres";
            // 
            // mitokmsLabel
            // 
            this.mitokmsLabel.Location = new System.Drawing.Point(155, 178);
            this.mitokmsLabel.Name = "mitokmsLabel";
            this.mitokmsLabel.Size = new System.Drawing.Size(142, 23);
            this.mitokmsLabel.TabIndex = 4;
            this.mitokmsLabel.Text = "4. Miles to Kilometres";
            // 
            // conversionChoiceLabel
            // 
            this.conversionChoiceLabel.Location = new System.Drawing.Point(113, 223);
            this.conversionChoiceLabel.Name = "conversionChoiceLabel";
            this.conversionChoiceLabel.Size = new System.Drawing.Size(152, 23);
            this.conversionChoiceLabel.TabIndex = 5;
            this.conversionChoiceLabel.Text = "Enter Conversion Choice (1-4)";
            // 
            // valueLabel
            // 
            this.valueLabel.Location = new System.Drawing.Point(113, 265);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(142, 23);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Enter Value to Be Converted";
            // 
            // choiceInput
            // 
            this.choiceInput.Location = new System.Drawing.Point(285, 220);
            this.choiceInput.Name = "choiceInput";
            this.choiceInput.Size = new System.Drawing.Size(100, 20);
            this.choiceInput.TabIndex = 7;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(285, 262);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 8;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(71, 345);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(358, 79);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvetButton
            // 
            this.ConvetButton.Location = new System.Drawing.Point(206, 300);
            this.ConvetButton.Name = "ConvetButton";
            this.ConvetButton.Size = new System.Drawing.Size(91, 28);
            this.ConvetButton.TabIndex = 10;
            this.ConvetButton.Text = "Convert";
            this.ConvetButton.UseVisualStyleBackColor = true;
            this.ConvetButton.Click += new System.EventHandler(this.ConvetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(490, 433);
            this.Controls.Add(this.ConvetButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.choiceInput);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.conversionChoiceLabel);
            this.Controls.Add(this.mitokmsLabel);
            this.Controls.Add(this.yardstomLabel);
            this.Controls.Add(this.feettocmLabel);
            this.Controls.Add(this.inchestocmLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label inchestocmLabel;
        private System.Windows.Forms.Label feettocmLabel;
        private System.Windows.Forms.Label yardstomLabel;
        private System.Windows.Forms.Label mitokmsLabel;
        private System.Windows.Forms.Label conversionChoiceLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox choiceInput;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button ConvetButton;
    }
}

