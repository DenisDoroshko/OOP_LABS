using System;
namespace UserInterface
{
    partial class PeriodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimalDaylabel = new System.Windows.Forms.Label();
            this.minimalLabel = new System.Windows.Forms.Label();
            this.showMinimalDaybutton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.balconyLabel = new System.Windows.Forms.Label();
            this.loggiaLabel = new System.Windows.Forms.Label();
            this.parterreLabel = new System.Windows.Forms.Label();
            this.averageParterreLabel = new System.Windows.Forms.Label();
            this.averageLoggiaLabel = new System.Windows.Forms.Label();
            this.averageBalconyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.clearDayLabel = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.clearLabel = new System.Windows.Forms.Label();
            this.showAveragesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.minimalDaylabel);
            this.panel1.Controls.Add(this.minimalLabel);
            this.panel1.Controls.Add(this.showMinimalDaybutton);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.balconyLabel);
            this.panel1.Controls.Add(this.loggiaLabel);
            this.panel1.Controls.Add(this.parterreLabel);
            this.panel1.Controls.Add(this.averageParterreLabel);
            this.panel1.Controls.Add(this.averageLoggiaLabel);
            this.panel1.Controls.Add(this.averageBalconyLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.clearDayLabel);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.clearLabel);
            this.panel1.Controls.Add(this.showAveragesButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 379);
            this.panel1.TabIndex = 3;
            // 
            // minimalDaylabel
            // 
            this.minimalDaylabel.AutoSize = true;
            this.minimalDaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimalDaylabel.Location = new System.Drawing.Point(12, 272);
            this.minimalDaylabel.Name = "minimalDaylabel";
            this.minimalDaylabel.Size = new System.Drawing.Size(0, 24);
            this.minimalDaylabel.TabIndex = 21;
            // 
            // minimalLabel
            // 
            this.minimalLabel.AutoSize = true;
            this.minimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimalLabel.Location = new System.Drawing.Point(299, 239);
            this.minimalLabel.Name = "minimalLabel";
            this.minimalLabel.Size = new System.Drawing.Size(0, 24);
            this.minimalLabel.TabIndex = 20;
            // 
            // showMinimalDaybutton
            // 
            this.showMinimalDaybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.showMinimalDaybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showMinimalDaybutton.FlatAppearance.BorderSize = 0;
            this.showMinimalDaybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMinimalDaybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMinimalDaybutton.Location = new System.Drawing.Point(321, 184);
            this.showMinimalDaybutton.Name = "showMinimalDaybutton";
            this.showMinimalDaybutton.Size = new System.Drawing.Size(137, 36);
            this.showMinimalDaybutton.TabIndex = 19;
            this.showMinimalDaybutton.Text = "show minimal";
            this.showMinimalDaybutton.UseVisualStyleBackColor = false;
            this.showMinimalDaybutton.Click += new System.EventHandler(this.showMinimalDaybutton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(317, 239);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 24);
            this.errorLabel.TabIndex = 18;
            // 
            // balconyLabel
            // 
            this.balconyLabel.AutoSize = true;
            this.balconyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balconyLabel.Location = new System.Drawing.Point(3, 306);
            this.balconyLabel.Name = "balconyLabel";
            this.balconyLabel.Size = new System.Drawing.Size(0, 24);
            this.balconyLabel.TabIndex = 17;
            // 
            // loggiaLabel
            // 
            this.loggiaLabel.AutoSize = true;
            this.loggiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loggiaLabel.Location = new System.Drawing.Point(4, 272);
            this.loggiaLabel.Name = "loggiaLabel";
            this.loggiaLabel.Size = new System.Drawing.Size(0, 24);
            this.loggiaLabel.TabIndex = 16;
            // 
            // parterreLabel
            // 
            this.parterreLabel.AutoSize = true;
            this.parterreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parterreLabel.Location = new System.Drawing.Point(3, 239);
            this.parterreLabel.Name = "parterreLabel";
            this.parterreLabel.Size = new System.Drawing.Size(0, 24);
            this.parterreLabel.TabIndex = 15;
            // 
            // averageParterreLabel
            // 
            this.averageParterreLabel.AutoSize = true;
            this.averageParterreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageParterreLabel.Location = new System.Drawing.Point(357, 239);
            this.averageParterreLabel.Name = "averageParterreLabel";
            this.averageParterreLabel.Size = new System.Drawing.Size(0, 24);
            this.averageParterreLabel.TabIndex = 14;
            // 
            // averageLoggiaLabel
            // 
            this.averageLoggiaLabel.AutoSize = true;
            this.averageLoggiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageLoggiaLabel.Location = new System.Drawing.Point(357, 272);
            this.averageLoggiaLabel.Name = "averageLoggiaLabel";
            this.averageLoggiaLabel.Size = new System.Drawing.Size(0, 24);
            this.averageLoggiaLabel.TabIndex = 13;
            // 
            // averageBalconyLabel
            // 
            this.averageBalconyLabel.AutoSize = true;
            this.averageBalconyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageBalconyLabel.Location = new System.Drawing.Point(357, 306);
            this.averageBalconyLabel.Name = "averageBalconyLabel";
            this.averageBalconyLabel.Size = new System.Drawing.Size(0, 24);
            this.averageBalconyLabel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "to";
            // 
            // toDatePicker
            // 
            this.toDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.toDatePicker.Checked = false;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(228, 152);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(483, 329);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 38);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearDayLabel
            // 
            this.clearDayLabel.AutoSize = true;
            this.clearDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearDayLabel.Location = new System.Drawing.Point(159, 126);
            this.clearDayLabel.Name = "clearDayLabel";
            this.clearDayLabel.Size = new System.Drawing.Size(47, 24);
            this.clearDayLabel.TabIndex = 6;
            this.clearDayLabel.Text = "from";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.fromDatePicker.Checked = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(228, 126);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 4;
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLabel.Location = new System.Drawing.Point(233, 97);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(182, 26);
            this.clearLabel.TabIndex = 3;
            this.clearLabel.Text = "Choice the period";
            // 
            // showAveragesButton
            // 
            this.showAveragesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.showAveragesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAveragesButton.FlatAppearance.BorderSize = 0;
            this.showAveragesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAveragesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAveragesButton.Location = new System.Drawing.Point(163, 184);
            this.showAveragesButton.Name = "showAveragesButton";
            this.showAveragesButton.Size = new System.Drawing.Size(137, 36);
            this.showAveragesButton.TabIndex = 2;
            this.showAveragesButton.Text = "show averages";
            this.showAveragesButton.UseVisualStyleBackColor = false;
            this.showAveragesButton.Click += new System.EventHandler(this.showAveragesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.AppLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 84);
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
            this.AppLabel.Size = new System.Drawing.Size(610, 84);
            this.AppLabel.TabIndex = 0;
            this.AppLabel.Text = "The period information";
            this.AppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 379);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PeriodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket accounting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PeriodForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label clearDayLabel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button showAveragesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label averageParterreLabel;
        private System.Windows.Forms.Label averageLoggiaLabel;
        private System.Windows.Forms.Label averageBalconyLabel;
        private System.Windows.Forms.Label balconyLabel;
        private System.Windows.Forms.Label loggiaLabel;
        private System.Windows.Forms.Label parterreLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button showMinimalDaybutton;
        private System.Windows.Forms.Label minimalDaylabel;
        private System.Windows.Forms.Label minimalLabel;
    }
}