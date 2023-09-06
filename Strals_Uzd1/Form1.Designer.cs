namespace Strals_Uzd1
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
            this.buttonPoga = new System.Windows.Forms.Button();
            this.labelTeksts = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonPoga
            // 
            this.buttonPoga.Location = new System.Drawing.Point(311, 114);
            this.buttonPoga.Name = "buttonPoga";
            this.buttonPoga.Size = new System.Drawing.Size(75, 23);
            this.buttonPoga.TabIndex = 0;
            this.buttonPoga.Text = "Spiest mani";
            this.buttonPoga.UseVisualStyleBackColor = true;
            this.buttonPoga.Click += new System.EventHandler(this.buttonPoga_Click);
            // 
            // labelTeksts
            // 
            this.labelTeksts.AutoSize = true;
            this.labelTeksts.Location = new System.Drawing.Point(308, 152);
            this.labelTeksts.Name = "labelTeksts";
            this.labelTeksts.Size = new System.Drawing.Size(35, 13);
            this.labelTeksts.TabIndex = 1;
            this.labelTeksts.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lielais",
            "Mazais",
            "Vidējais",
            "Ar papildus sieru"});
            this.comboBox1.Location = new System.Drawing.Point(311, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTeksts);
            this.Controls.Add(this.buttonPoga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPoga;
        private System.Windows.Forms.Label labelTeksts;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

