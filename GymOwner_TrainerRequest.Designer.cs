﻿namespace Database_Project
{
    partial class GymOwner_TrainerRequest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainerAvailable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GymAvailable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(306, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 37);
            this.label3.TabIndex = 414;
            this.label3.Text = "Trainer Appointment Requests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(426, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 37);
            this.label4.TabIndex = 413;
            this.label4.Text = "GYM OWNER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(328, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 58);
            this.label5.TabIndex = 412;
            this.label5.Text = "FLEX TRAINER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(464, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 48);
            this.button2.TabIndex = 525;
            this.button2.Text = "Approve";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(464, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 52);
            this.button1.TabIndex = 524;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 523;
            this.label1.Text = "Trainer Available";
            // 
            // TrainerAvailable
            // 
            this.TrainerAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrainerAvailable.FormattingEnabled = true;
            this.TrainerAvailable.Location = new System.Drawing.Point(435, 328);
            this.TrainerAvailable.Name = "TrainerAvailable";
            this.TrainerAvailable.Size = new System.Drawing.Size(451, 28);
            this.TrainerAvailable.TabIndex = 522;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 531;
            this.label2.Text = "Gym Available";
            // 
            // GymAvailable
            // 
            this.GymAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GymAvailable.FormattingEnabled = true;
            this.GymAvailable.Location = new System.Drawing.Point(435, 243);
            this.GymAvailable.Name = "GymAvailable";
            this.GymAvailable.Size = new System.Drawing.Size(451, 28);
            this.GymAvailable.TabIndex = 530;
            this.GymAvailable.SelectedIndexChanged += new System.EventHandler(this.GymAvailable_SelectedIndexChanged);
            // 
            // GymOwner_TrainerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GymAvailable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainerAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "GymOwner_TrainerRequest";
            this.Text = "GymOwner_TrainerRequest";
            this.Load += new System.EventHandler(this.GymOwner_TrainerRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TrainerAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GymAvailable;
    }
}