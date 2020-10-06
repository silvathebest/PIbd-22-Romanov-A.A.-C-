namespace WindowsFormsCrane
{
    partial class CraneForm
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
            this.pictureBoxCrane = new System.Windows.Forms.PictureBox();
            this.buttonCreateTrackedVehicle = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCreateCrane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCrane
            // 
            this.pictureBoxCrane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCrane.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCrane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCrane.Name = "pictureBoxCrane";
            this.pictureBoxCrane.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxCrane.TabIndex = 0;
            this.pictureBoxCrane.TabStop = false;
            // 
            // buttonCreateTrackedVehicle
            // 
            this.buttonCreateTrackedVehicle.Location = new System.Drawing.Point(0, 404);
            this.buttonCreateTrackedVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateTrackedVehicle.Name = "buttonCreateTrackedVehicle";
            this.buttonCreateTrackedVehicle.Size = new System.Drawing.Size(238, 35);
            this.buttonCreateTrackedVehicle.TabIndex = 1;
            this.buttonCreateTrackedVehicle.Text = "Создать гусеничную машину";
            this.buttonCreateTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateTrackedVehicle.Click += new System.EventHandler(this.buttonCreateTrackedVehicle_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.uppng;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(688, 359);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(29, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(724, 396);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(29, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.downpng;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(688, 396);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(29, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.leftpng;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(652, 396);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(29, 30);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateCrane
            // 
            this.buttonCreateCrane.Location = new System.Drawing.Point(0, 377);
            this.buttonCreateCrane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateCrane.Name = "buttonCreateCrane";
            this.buttonCreateCrane.Size = new System.Drawing.Size(238, 23);
            this.buttonCreateCrane.TabIndex = 7;
            this.buttonCreateCrane.Text = "Создать кран";
            this.buttonCreateCrane.UseVisualStyleBackColor = true;
            this.buttonCreateCrane.Click += new System.EventHandler(this.buttonCreateCrane_Click);
            // 
            // CraneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateCrane);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateTrackedVehicle);
            this.Controls.Add(this.pictureBoxCrane);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CraneForm";
            this.Text = "CraneForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCrane;
        private System.Windows.Forms.Button buttonCreateTrackedVehicle;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCreateCrane;
    }
}