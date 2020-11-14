namespace UI
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.numberRadio = new System.Windows.Forms.RadioButton();
            this.scalarRadio = new System.Windows.Forms.RadioButton();
            this.vectorRadio = new System.Windows.Forms.RadioButton();
            this.mixedRadio = new System.Windows.Forms.RadioButton();
            this.typeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.mixedRadio);
            this.panel1.Controls.Add(this.vectorRadio);
            this.panel1.Controls.Add(this.scalarRadio);
            this.panel1.Controls.Add(this.numberRadio);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 463);
            this.panel1.TabIndex = 1;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectButton.Location = new System.Drawing.Point(327, 355);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(160, 37);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.mainLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 82);
            this.panel2.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(0, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainLabel.Size = new System.Drawing.Size(586, 82);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Work with vectors";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberRadio
            // 
            this.numberRadio.AutoSize = true;
            this.numberRadio.Checked = true;
            this.numberRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRadio.Location = new System.Drawing.Point(243, 140);
            this.numberRadio.Name = "numberRadio";
            this.numberRadio.Size = new System.Drawing.Size(112, 24);
            this.numberRadio.TabIndex = 4;
            this.numberRadio.TabStop = true;
            this.numberRadio.Text = "By number";
            this.numberRadio.UseVisualStyleBackColor = true;
            // 
            // scalarRadio
            // 
            this.scalarRadio.AutoSize = true;
            this.scalarRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scalarRadio.Location = new System.Drawing.Point(243, 180);
            this.scalarRadio.Name = "scalarRadio";
            this.scalarRadio.Size = new System.Drawing.Size(78, 24);
            this.scalarRadio.TabIndex = 5;
            this.scalarRadio.Text = "Scalar";
            this.scalarRadio.UseVisualStyleBackColor = true;
            // 
            // vectorRadio
            // 
            this.vectorRadio.AutoSize = true;
            this.vectorRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vectorRadio.Location = new System.Drawing.Point(243, 220);
            this.vectorRadio.Name = "vectorRadio";
            this.vectorRadio.Size = new System.Drawing.Size(80, 24);
            this.vectorRadio.TabIndex = 6;
            this.vectorRadio.Text = "Vector";
            this.vectorRadio.UseVisualStyleBackColor = true;
            // 
            // mixedRadio
            // 
            this.mixedRadio.AutoSize = true;
            this.mixedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mixedRadio.Location = new System.Drawing.Point(243, 260);
            this.mixedRadio.Name = "mixedRadio";
            this.mixedRadio.Size = new System.Drawing.Size(73, 24);
            this.mixedRadio.TabIndex = 7;
            this.mixedRadio.Text = "Mixed";
            this.mixedRadio.UseVisualStyleBackColor = true;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(210, 100);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(209, 20);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Select multiplication type";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(161, 355);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 37);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.RadioButton mixedRadio;
        private System.Windows.Forms.RadioButton vectorRadio;
        private System.Windows.Forms.RadioButton scalarRadio;
        private System.Windows.Forms.RadioButton numberRadio;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button backButton;
    }
}