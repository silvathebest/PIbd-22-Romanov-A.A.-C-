namespace WindowsFormsCrane
{
    partial class FormVehicleConfig
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
            this.groupBoxVehicleType = new System.Windows.Forms.GroupBox();
            this.labelCrane = new System.Windows.Forms.Label();
            this.labelTrackedVehicle = new System.Windows.Forms.Label();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxPipe = new System.Windows.Forms.CheckBox();
            this.checkBoxHook = new System.Windows.Forms.CheckBox();
            this.checkBoxCrane = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxVehicle = new System.Windows.Forms.PictureBox();
            this.panelVehicle = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxVehicleType.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).BeginInit();
            this.panelVehicle.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVehicleType
            // 
            this.groupBoxVehicleType.Controls.Add(this.labelCrane);
            this.groupBoxVehicleType.Controls.Add(this.labelTrackedVehicle);
            this.groupBoxVehicleType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVehicleType.Name = "groupBoxVehicleType";
            this.groupBoxVehicleType.Size = new System.Drawing.Size(140, 143);
            this.groupBoxVehicleType.TabIndex = 0;
            this.groupBoxVehicleType.TabStop = false;
            this.groupBoxVehicleType.Text = "Тип транспорта";
            // 
            // labelCrane
            // 
            this.labelCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCrane.Location = new System.Drawing.Point(6, 92);
            this.labelCrane.Name = "labelCrane";
            this.labelCrane.Size = new System.Drawing.Size(121, 34);
            this.labelCrane.TabIndex = 1;
            this.labelCrane.Text = "Кран";
            this.labelCrane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCrane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCrane_MouseDown);
            // 
            // labelTrackedVehicle
            // 
            this.labelTrackedVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrackedVehicle.Location = new System.Drawing.Point(6, 27);
            this.labelTrackedVehicle.Name = "labelTrackedVehicle";
            this.labelTrackedVehicle.Size = new System.Drawing.Size(121, 42);
            this.labelTrackedVehicle.TabIndex = 0;
            this.labelTrackedVehicle.Text = "Гусеничная машина";
            this.labelTrackedVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrackedVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrackedVehicle_MouseDown);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.checkBoxPipe);
            this.groupBoxConfig.Controls.Add(this.checkBoxHook);
            this.groupBoxConfig.Controls.Add(this.checkBoxCrane);
            this.groupBoxConfig.Controls.Add(this.numericUpDownWeight);
            this.groupBoxConfig.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxConfig.Controls.Add(this.labelWeight);
            this.groupBoxConfig.Controls.Add(this.labelMaxSpeed);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 161);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(345, 121);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Параметры";
            // 
            // checkBoxPipe
            // 
            this.checkBoxPipe.AutoSize = true;
            this.checkBoxPipe.Location = new System.Drawing.Point(221, 79);
            this.checkBoxPipe.Name = "checkBoxPipe";
            this.checkBoxPipe.Size = new System.Drawing.Size(121, 21);
            this.checkBoxPipe.TabIndex = 7;
            this.checkBoxPipe.Text = "Задняя труба";
            this.checkBoxPipe.UseVisualStyleBackColor = true;
            // 
            // checkBoxHook
            // 
            this.checkBoxHook.AutoSize = true;
            this.checkBoxHook.Location = new System.Drawing.Point(221, 52);
            this.checkBoxHook.Name = "checkBoxHook";
            this.checkBoxHook.Size = new System.Drawing.Size(64, 21);
            this.checkBoxHook.TabIndex = 6;
            this.checkBoxHook.Text = "Крюк";
            this.checkBoxHook.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrane
            // 
            this.checkBoxCrane.AutoSize = true;
            this.checkBoxCrane.Location = new System.Drawing.Point(221, 24);
            this.checkBoxCrane.Name = "checkBoxCrane";
            this.checkBoxCrane.Size = new System.Drawing.Size(63, 21);
            this.checkBoxCrane.TabIndex = 5;
            this.checkBoxCrane.Text = "Кран";
            this.checkBoxCrane.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(67, 92);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownWeight.TabIndex = 4;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(67, 47);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownMaxSpeed.TabIndex = 3;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(15, 72);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(94, 17);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Вес машины:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(15, 28);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(112, 17);
            this.labelMaxSpeed.TabIndex = 1;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxVehicle
            // 
            this.pictureBoxVehicle.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxVehicle.Name = "pictureBoxVehicle";
            this.pictureBoxVehicle.Size = new System.Drawing.Size(181, 140);
            this.pictureBoxVehicle.TabIndex = 1;
            this.pictureBoxVehicle.TabStop = false;
            // 
            // panelVehicle
            // 
            this.panelVehicle.AllowDrop = true;
            this.panelVehicle.Controls.Add(this.pictureBoxVehicle);
            this.panelVehicle.Location = new System.Drawing.Point(158, 12);
            this.panelVehicle.Name = "panelVehicle";
            this.panelVehicle.Size = new System.Drawing.Size(196, 143);
            this.panelVehicle.TabIndex = 2;
            this.panelVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelVehicle_DragDrop);
            this.panelVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelVehicle_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Location = new System.Drawing.Point(396, 15);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(266, 168);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(219, 120);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(41, 35);
            this.panelBlue.TabIndex = 9;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(158, 120);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(41, 35);
            this.panelGreen.TabIndex = 8;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(92, 120);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(41, 35);
            this.panelOrange.TabIndex = 7;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(26, 120);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(41, 35);
            this.panelGray.TabIndex = 6;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(219, 79);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(41, 35);
            this.panelWhite.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(158, 79);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(41, 35);
            this.panelBlack.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(92, 79);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(41, 35);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(26, 79);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(41, 35);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(141, 24);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(115, 42);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(7, 24);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(115, 42);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(554, 189);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(554, 240);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormVehicleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 295);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelVehicle);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.groupBoxVehicleType);
            this.Name = "FormVehicleConfig";
            this.Text = "FormVehicleConfig";
            this.groupBoxVehicleType.ResumeLayout(false);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).EndInit();
            this.panelVehicle.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehicleType;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.CheckBox checkBoxCrane;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelCrane;
        private System.Windows.Forms.Label labelTrackedVehicle;
        private System.Windows.Forms.CheckBox checkBoxPipe;
        private System.Windows.Forms.CheckBox checkBoxHook;
        private System.Windows.Forms.PictureBox pictureBoxVehicle;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}