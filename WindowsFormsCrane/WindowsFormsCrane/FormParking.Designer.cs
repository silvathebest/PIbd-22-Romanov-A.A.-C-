﻿namespace WindowsFormsCrane
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonCrateTrackedVehicle = new System.Windows.Forms.Button();
            this.buttonCreateCrane = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonTakeVehicle = new System.Windows.Forms.Button();
            this.maskedTextBoxPickPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(896, 687);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonCrateTrackedVehicle
            // 
            this.buttonCrateTrackedVehicle.Location = new System.Drawing.Point(904, 15);
            this.buttonCrateTrackedVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCrateTrackedVehicle.Name = "buttonCrateTrackedVehicle";
            this.buttonCrateTrackedVehicle.Size = new System.Drawing.Size(147, 60);
            this.buttonCrateTrackedVehicle.TabIndex = 1;
            this.buttonCrateTrackedVehicle.Text = "Припарковать гусеничную машину";
            this.buttonCrateTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonCrateTrackedVehicle.Click += new System.EventHandler(this.buttonSetTrackedVehicle_Click);
            // 
            // buttonCreateCrane
            // 
            this.buttonCreateCrane.Location = new System.Drawing.Point(904, 82);
            this.buttonCreateCrane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateCrane.Name = "buttonCreateCrane";
            this.buttonCreateCrane.Size = new System.Drawing.Size(147, 60);
            this.buttonCreateCrane.TabIndex = 2;
            this.buttonCreateCrane.Text = "Припарковать кран";
            this.buttonCreateCrane.UseVisualStyleBackColor = true;
            this.buttonCreateCrane.Click += new System.EventHandler(this.buttonSetCrane_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonTakeVehicle);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxPickPlace);
            this.groupBoxParking.Controls.Add(this.labelPlace);
            this.groupBoxParking.Location = new System.Drawing.Point(904, 150);
            this.groupBoxParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxParking.Size = new System.Drawing.Size(159, 123);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать транспорт";
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(13, 71);
            this.buttonTakeVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTakeVehicle.Name = "buttonTakeVehicle";
            this.buttonTakeVehicle.Size = new System.Drawing.Size(113, 28);
            this.buttonTakeVehicle.TabIndex = 2;
            this.buttonTakeVehicle.Text = "Забрать";
            this.buttonTakeVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeVehicle.Click += new System.EventHandler(this.buttonTakeVehicle_Click);
            // 
            // maskedTextBoxPickPlace
            // 
            this.maskedTextBoxPickPlace.Location = new System.Drawing.Point(73, 21);
            this.maskedTextBoxPickPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxPickPlace.Name = "maskedTextBoxPickPlace";
            this.maskedTextBoxPickPlace.Size = new System.Drawing.Size(52, 22);
            this.maskedTextBoxPickPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(9, 25);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 687);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonCreateCrane);
            this.Controls.Add(this.buttonCrateTrackedVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonCrateTrackedVehicle;
        private System.Windows.Forms.Button buttonCreateCrane;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPickPlace;
        private System.Windows.Forms.Label labelPlace;
    }
}