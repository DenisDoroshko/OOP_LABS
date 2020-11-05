using System;

namespace UserInterface
{
    partial class ShowDayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDayForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.numberBalcony = new System.Windows.Forms.Label();
            this.numberLoggia = new System.Windows.Forms.Label();
            this.numberParterre = new System.Windows.Forms.Label();
            this.parterreLabel = new System.Windows.Forms.Label();
            this.balconyLabel = new System.Windows.Forms.Label();
            this.loggiaLabel = new System.Windows.Forms.Label();
            this.numberSold = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.numberBalcony);
            this.panel1.Controls.Add(this.numberLoggia);
            this.panel1.Controls.Add(this.numberParterre);
            this.panel1.Controls.Add(this.parterreLabel);
            this.panel1.Controls.Add(this.balconyLabel);
            this.panel1.Controls.Add(this.loggiaLabel);
            this.panel1.Controls.Add(this.numberSold);
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Controls.Add(this.SelectedDate);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.ShowButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 379);
            this.panel1.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(476, 310);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 37);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numberBalcony
            // 
            this.numberBalcony.AutoSize = true;
            this.numberBalcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberBalcony.Location = new System.Drawing.Point(373, 233);
            this.numberBalcony.Name = "numberBalcony";
            this.numberBalcony.Size = new System.Drawing.Size(0, 22);
            this.numberBalcony.TabIndex = 12;
            // 
            // numberLoggia
            // 
            this.numberLoggia.AutoSize = true;
            this.numberLoggia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLoggia.Location = new System.Drawing.Point(373, 202);
            this.numberLoggia.Name = "numberLoggia";
            this.numberLoggia.Size = new System.Drawing.Size(0, 22);
            this.numberLoggia.TabIndex = 11;
            // 
            // numberParterre
            // 
            this.numberParterre.AutoSize = true;
            this.numberParterre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberParterre.Location = new System.Drawing.Point(373, 169);
            this.numberParterre.Name = "numberParterre";
            this.numberParterre.Size = new System.Drawing.Size(0, 22);
            this.numberParterre.TabIndex = 10;
            // 
            // parterreLabel
            // 
            this.parterreLabel.AutoSize = true;
            this.parterreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parterreLabel.Location = new System.Drawing.Point(54, 169);
            this.parterreLabel.Name = "parterreLabel";
            this.parterreLabel.Size = new System.Drawing.Size(0, 22);
            this.parterreLabel.TabIndex = 9;
            // 
            // balconyLabel
            // 
            this.balconyLabel.AutoSize = true;
            this.balconyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balconyLabel.Location = new System.Drawing.Point(54, 233);
            this.balconyLabel.Name = "balconyLabel";
            this.balconyLabel.Size = new System.Drawing.Size(0, 22);
            this.balconyLabel.TabIndex = 8;
            // 
            // loggiaLabel
            // 
            this.loggiaLabel.AutoSize = true;
            this.loggiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loggiaLabel.Location = new System.Drawing.Point(54, 202);
            this.loggiaLabel.Name = "loggiaLabel";
            this.loggiaLabel.Size = new System.Drawing.Size(0, 22);
            this.loggiaLabel.TabIndex = 7;
            // 
            // numberSold
            // 
            this.numberSold.AutoSize = true;
            this.numberSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberSold.Location = new System.Drawing.Point(373, 138);
            this.numberSold.Name = "numberSold";
            this.numberSold.Size = new System.Drawing.Size(0, 22);
            this.numberSold.TabIndex = 6;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(54, 138);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 22);
            this.numberLabel.TabIndex = 5;
            // 
            // SelectedDate
            // 
            this.SelectedDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.SelectedDate.Checked = false;
            this.SelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectedDate.Location = new System.Drawing.Point(190, 103);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Size = new System.Drawing.Size(200, 20);
            this.SelectedDate.TabIndex = 4;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(54, 103);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(130, 22);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Select the date";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowButton.Location = new System.Drawing.Point(412, 95);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(97, 35);
            this.ShowButton.TabIndex = 2;
            this.ShowButton.Text = "show";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.AppLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 84);
            this.panel2.TabIndex = 1;
            // 
            // AppLabel
            // 
            this.AppLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.AppLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AppLabel.Location = new System.Drawing.Point(0, 0);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(612, 84);
            this.AppLabel.TabIndex = 0;
            this.AppLabel.Text = "Information about the day";
            this.AppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 379);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket accounting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowDayForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker SelectedDate;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label numberSold;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label parterreLabel;
        private System.Windows.Forms.Label balconyLabel;
        private System.Windows.Forms.Label loggiaLabel;
        private System.Windows.Forms.Label numberBalcony;
        private System.Windows.Forms.Label numberLoggia;
        private System.Windows.Forms.Label numberParterre;
        private System.Windows.Forms.Button backButton;
    }
}