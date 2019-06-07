namespace DocumentGeneratorCP
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
            this.doctypelbl = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SpecifyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctypelbl
            // 
            this.doctypelbl.AutoSize = true;
            this.doctypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctypelbl.Location = new System.Drawing.Point(24, 35);
            this.doctypelbl.Name = "doctypelbl";
            this.doctypelbl.Size = new System.Drawing.Size(218, 18);
            this.doctypelbl.TabIndex = 0;
            this.doctypelbl.Text = "Choose the Document type:";
            this.doctypelbl.Click += new System.EventHandler(this.doctypelbl_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Application",
            "Affirmation",
            "An Apologetic Note"});
            this.typeComboBox.Location = new System.Drawing.Point(54, 72);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(153, 21);
            this.typeComboBox.TabIndex = 1;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // generatebtn
            // 
            this.generatebtn.Location = new System.Drawing.Point(54, 242);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(158, 41);
            this.generatebtn.TabIndex = 2;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.AcceptsReturn = true;
            this.resultBox.Location = new System.Drawing.Point(260, 62);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(456, 365);
            this.resultBox.TabIndex = 3;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // SpecifyLabel
            // 
            this.SpecifyLabel.AutoSize = true;
            this.SpecifyLabel.Location = new System.Drawing.Point(260, 43);
            this.SpecifyLabel.Name = "SpecifyLabel";
            this.SpecifyLabel.Size = new System.Drawing.Size(0, 13);
            this.SpecifyLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpecifyLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.doctypelbl);
            this.Name = "Form1";
            this.Text = "Document Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doctypelbl;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label SpecifyLabel;
    }
}

