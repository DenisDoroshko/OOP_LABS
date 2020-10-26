using System;
namespace UserInterface
{
    partial class EditForm
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
            this.clearDayButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clearDayLabel = new System.Windows.Forms.Label();
            this.SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.clearLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.clearDayButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.clearDayLabel);
            this.panel1.Controls.Add(this.SelectedDate);
            this.panel1.Controls.Add(this.clearLabel);
            this.panel1.Controls.Add(this.clearAllButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 379);
            this.panel1.TabIndex = 2;
            // 
            // clearDayButton
            // 
            this.clearDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.clearDayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearDayButton.FlatAppearance.BorderSize = 0;
            this.clearDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearDayButton.Location = new System.Drawing.Point(448, 148);
            this.clearDayButton.Name = "clearDayButton";
            this.clearDayButton.Size = new System.Drawing.Size(79, 31);
            this.clearDayButton.TabIndex = 9;
            this.clearDayButton.Text = "Clear";
            this.clearDayButton.UseVisualStyleBackColor = false;
            this.clearDayButton.Click += new System.EventHandler(this.clearDayButton_Click);
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
            this.clearDayLabel.Location = new System.Drawing.Point(80, 150);
            this.clearDayLabel.Name = "clearDayLabel";
            this.clearDayLabel.Size = new System.Drawing.Size(120, 24);
            this.clearDayLabel.TabIndex = 6;
            this.clearDayLabel.Text = "Clear the day";
            // 
            // SelectedDate
            // 
            this.SelectedDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.SelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectedDate.Location = new System.Drawing.Point(229, 154);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Size = new System.Drawing.Size(200, 20);
            this.SelectedDate.TabIndex = 4;
            this.SelectedDate.Value = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, 0);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLabel.Location = new System.Drawing.Point(225, 220);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(77, 24);
            this.clearLabel.TabIndex = 3;
            this.clearLabel.Text = "Clear all";
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(138)))), ((int)(((byte)(234)))));
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAllButton.Location = new System.Drawing.Point(308, 216);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(79, 31);
            this.clearAllButton.TabIndex = 2;
            this.clearAllButton.Text = "Clear";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
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
            this.AppLabel.Text = "Edit data";
            this.AppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 379);
            this.Controls.Add(this.panel1);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label clearDayLabel;
        private System.Windows.Forms.DateTimePicker SelectedDate;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Button clearDayButton;
    }
}