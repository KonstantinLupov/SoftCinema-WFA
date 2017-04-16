﻿namespace SoftCinema.Client.Forms
{
    partial class SelectSeatsForm
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
            this.freeSeatsLegendLabel = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.freeSeatsLabel = new System.Windows.Forms.Label();
            this.takenSeatsLabel = new System.Windows.Forms.Label();
            this.takenSeatsLegendButton = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.chosenSeatsLabel = new System.Windows.Forms.Label();
            this.chosenSeatsLegendButton = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teamButton1 = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // freeSeatsLegendLabel
            // 
            this.freeSeatsLegendLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.freeSeatsLegendLabel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.freeSeatsLegendLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeSeatsLegendLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSeatsLegendLabel.ForeColor = System.Drawing.Color.White;
            this.freeSeatsLegendLabel.Location = new System.Drawing.Point(61, 64);
            this.freeSeatsLegendLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.freeSeatsLegendLabel.MinimumSize = new System.Drawing.Size(15, 15);
            this.freeSeatsLegendLabel.Name = "freeSeatsLegendLabel";
            this.freeSeatsLegendLabel.Padding = new System.Windows.Forms.Padding(3);
            this.freeSeatsLegendLabel.Size = new System.Drawing.Size(20, 20);
            this.freeSeatsLegendLabel.TabIndex = 0;
            this.freeSeatsLegendLabel.Text = "seatButton1";
            this.freeSeatsLegendLabel.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(55, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Please select your seats";
            // 
            // freeSeatsLabel
            // 
            this.freeSeatsLabel.AutoSize = true;
            this.freeSeatsLabel.Location = new System.Drawing.Point(89, 71);
            this.freeSeatsLabel.Name = "freeSeatsLabel";
            this.freeSeatsLabel.Size = new System.Drawing.Size(56, 13);
            this.freeSeatsLabel.TabIndex = 4;
            this.freeSeatsLabel.Text = "Free seats";
            // 
            // takenSeatsLabel
            // 
            this.takenSeatsLabel.AutoSize = true;
            this.takenSeatsLabel.Location = new System.Drawing.Point(199, 71);
            this.takenSeatsLabel.Name = "takenSeatsLabel";
            this.takenSeatsLabel.Size = new System.Drawing.Size(66, 13);
            this.takenSeatsLabel.TabIndex = 8;
            this.takenSeatsLabel.Text = "Taken seats";
            // 
            // takenSeatsLegendButton
            // 
            this.takenSeatsLegendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(116)))));
            this.takenSeatsLegendButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.takenSeatsLegendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takenSeatsLegendButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takenSeatsLegendButton.ForeColor = System.Drawing.Color.White;
            this.takenSeatsLegendButton.Location = new System.Drawing.Point(171, 64);
            this.takenSeatsLegendButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.takenSeatsLegendButton.MinimumSize = new System.Drawing.Size(15, 15);
            this.takenSeatsLegendButton.Name = "takenSeatsLegendButton";
            this.takenSeatsLegendButton.Padding = new System.Windows.Forms.Padding(3);
            this.takenSeatsLegendButton.Size = new System.Drawing.Size(20, 20);
            this.takenSeatsLegendButton.TabIndex = 7;
            this.takenSeatsLegendButton.Text = "0";
            this.takenSeatsLegendButton.UseVisualStyleBackColor = false;
            // 
            // chosenSeatsLabel
            // 
            this.chosenSeatsLabel.AutoSize = true;
            this.chosenSeatsLabel.Location = new System.Drawing.Point(321, 71);
            this.chosenSeatsLabel.Name = "chosenSeatsLabel";
            this.chosenSeatsLabel.Size = new System.Drawing.Size(71, 13);
            this.chosenSeatsLabel.TabIndex = 10;
            this.chosenSeatsLabel.Text = "Chosen seats";
            // 
            // chosenSeatsLegendButton
            // 
            this.chosenSeatsLegendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(36)))));
            this.chosenSeatsLegendButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.chosenSeatsLegendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chosenSeatsLegendButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenSeatsLegendButton.ForeColor = System.Drawing.Color.White;
            this.chosenSeatsLegendButton.Location = new System.Drawing.Point(293, 64);
            this.chosenSeatsLegendButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.chosenSeatsLegendButton.MinimumSize = new System.Drawing.Size(15, 15);
            this.chosenSeatsLegendButton.Name = "chosenSeatsLegendButton";
            this.chosenSeatsLegendButton.Padding = new System.Windows.Forms.Padding(3);
            this.chosenSeatsLegendButton.Size = new System.Drawing.Size(20, 20);
            this.chosenSeatsLegendButton.TabIndex = 9;
            this.chosenSeatsLegendButton.Text = "seatButton4";
            this.chosenSeatsLegendButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 276);
            this.dataGridView1.TabIndex = 11;
            // 
            // teamButton1
            // 
            this.teamButton1.BackColor = System.Drawing.Color.DimGray;
            this.teamButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.teamButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamButton1.ForeColor = System.Drawing.Color.Black;
            this.teamButton1.Location = new System.Drawing.Point(539, 56);
            this.teamButton1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teamButton1.MinimumSize = new System.Drawing.Size(100, 30);
            this.teamButton1.Name = "teamButton1";
            this.teamButton1.Padding = new System.Windows.Forms.Padding(3);
            this.teamButton1.Size = new System.Drawing.Size(154, 36);
            this.teamButton1.TabIndex = 12;
            this.teamButton1.Text = "Purchase";
            this.teamButton1.UseVisualStyleBackColor = false;
            this.teamButton1.Click += new System.EventHandler(this.teamButton1_Click);
            // 
            // SelectSeatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.teamButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chosenSeatsLabel);
            this.Controls.Add(this.chosenSeatsLegendButton);
            this.Controls.Add(this.takenSeatsLabel);
            this.Controls.Add(this.takenSeatsLegendButton);
            this.Controls.Add(this.freeSeatsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.freeSeatsLegendLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectSeatsForm";
            this.Text = "SelectSeatsForm";
            this.Load += new System.EventHandler(this.SelectSeatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilities.CustomTools.SeatButton freeSeatsLegendLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label freeSeatsLabel;
        private System.Windows.Forms.Label takenSeatsLabel;
        private Utilities.CustomTools.SeatButton takenSeatsLegendButton;
        private System.Windows.Forms.Label chosenSeatsLabel;
        private Utilities.CustomTools.SeatButton chosenSeatsLegendButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Utilities.CustomTools.TeamButton teamButton1;
    }
}