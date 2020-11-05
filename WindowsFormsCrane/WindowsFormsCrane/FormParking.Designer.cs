namespace WindowsFormsCrane
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
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonTakeVehicle = new System.Windows.Forms.Button();
            this.maskedTextBoxPickPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelNameParking = new System.Windows.Forms.Label();
            this.maskedTextBoxNameParking = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(896, 687);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonTakeVehicle);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxPickPlace);
            this.groupBoxParking.Controls.Add(this.labelPlace);
            this.groupBoxParking.Location = new System.Drawing.Point(904, 503);
            this.groupBoxParking.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParking.Size = new System.Drawing.Size(159, 123);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать транспорт";
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(13, 71);
            this.buttonTakeVehicle.Margin = new System.Windows.Forms.Padding(4);
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
            this.maskedTextBoxPickPlace.Margin = new System.Windows.Forms.Padding(4);
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
            // labelNameParking
            // 
            this.labelNameParking.AutoSize = true;
            this.labelNameParking.Location = new System.Drawing.Point(942, 9);
            this.labelNameParking.Name = "labelNameParking";
            this.labelNameParking.Size = new System.Drawing.Size(75, 17);
            this.labelNameParking.TabIndex = 4;
            this.labelNameParking.Text = "Парковки:";
            // 
            // maskedTextBoxNameParking
            // 
            this.maskedTextBoxNameParking.Location = new System.Drawing.Point(904, 29);
            this.maskedTextBoxNameParking.Name = "maskedTextBoxNameParking";
            this.maskedTextBoxNameParking.Size = new System.Drawing.Size(151, 22);
            this.maskedTextBoxNameParking.TabIndex = 5;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(904, 58);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(151, 29);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить паркову";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.ItemHeight = 16;
            this.listBoxParking.Location = new System.Drawing.Point(904, 93);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(151, 164);
            this.listBoxParking.TabIndex = 7;
            this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(904, 264);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(151, 25);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Location = new System.Drawing.Point(904, 442);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(151, 54);
            this.buttonAddVehicle.TabIndex = 9;
            this.buttonAddVehicle.Text = "Добавить транспорт";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 687);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.maskedTextBoxNameParking);
            this.Controls.Add(this.labelNameParking);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPickPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelNameParking;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNameParking;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxParking;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Button buttonAddVehicle;
    }
}