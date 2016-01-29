namespace SelskapOgBursdagsPlanlegger
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kost = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.costBox = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(189, 177);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.kost);
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(181, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MiddagsSelskap";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // kost
            // 
            this.kost.AutoSize = true;
            this.kost.Location = new System.Drawing.Point(15, 106);
            this.kost.Name = "kost";
            this.kost.Size = new System.Drawing.Size(28, 13);
            this.kost.TabIndex = 4;
            this.kost.Text = "Cost";
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(18, 77);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(96, 17);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Location = new System.Drawing.Point(18, 54);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 2;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage2.Controls.Add(this.costBox);
            this.tabPage2.Controls.Add(this.Cost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(181, 151);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BursdagsSelskap";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(48, 116);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(86, 20);
            this.costBox.TabIndex = 6;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(16, 119);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(28, 13);
            this.Cost.TabIndex = 5;
            this.Cost.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cake Writing";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 54);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Fancy Decorations";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(19, 28);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of People";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(19, 90);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(115, 20);
            this.cakeWriting.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 181);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kost;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cakeWriting;
    }
}

