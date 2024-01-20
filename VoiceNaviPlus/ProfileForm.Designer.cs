namespace VoiceNaviPlus
{
    partial class ProfileForm
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
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.fuel = new System.Windows.Forms.ComboBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.ComboBox();
            this.bedLabel = new System.Windows.Forms.Label();
            this.bed = new System.Windows.Forms.ComboBox();
            this.speedInterval = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.profileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(140, 21);
            this.profileNameLabel.TabIndex = 0;
            this.profileNameLabel.Text = "プロファイル名 - 編集";
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fuelLabel.Location = new System.Drawing.Point(12, 46);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(58, 21);
            this.fuelLabel.TabIndex = 1;
            this.fuelLabel.Text = "残燃料";
            // 
            // fuel
            // 
            this.fuel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fuel.FormattingEnabled = true;
            this.fuel.Items.AddRange(new object[] {
            "高",
            "中",
            "低",
            "なし"});
            this.fuel.Location = new System.Drawing.Point(150, 43);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(60, 29);
            this.fuel.TabIndex = 2;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.distanceLabel.Location = new System.Drawing.Point(12, 92);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(106, 21);
            this.distanceLabel.TabIndex = 3;
            this.distanceLabel.Text = "航続可能距離";
            // 
            // distance
            // 
            this.distance.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.distance.FormattingEnabled = true;
            this.distance.Items.AddRange(new object[] {
            "高",
            "中",
            "低",
            "なし"});
            this.distance.Location = new System.Drawing.Point(150, 89);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(60, 29);
            this.distance.TabIndex = 4;
            // 
            // bedLabel
            // 
            this.bedLabel.AutoSize = true;
            this.bedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bedLabel.Location = new System.Drawing.Point(12, 138);
            this.bedLabel.Name = "bedLabel";
            this.bedLabel.Size = new System.Drawing.Size(42, 21);
            this.bedLabel.TabIndex = 5;
            this.bedLabel.Text = "休憩";
            // 
            // bed
            // 
            this.bed.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bed.FormattingEnabled = true;
            this.bed.Items.AddRange(new object[] {
            "高",
            "中",
            "低",
            "なし"});
            this.bed.Location = new System.Drawing.Point(150, 135);
            this.bed.Name = "bed";
            this.bed.Size = new System.Drawing.Size(60, 29);
            this.bed.TabIndex = 6;
            // 
            // speedInterval
            // 
            this.speedInterval.AutoSize = true;
            this.speedInterval.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.speedInterval.Location = new System.Drawing.Point(12, 184);
            this.speedInterval.Name = "speedInterval";
            this.speedInterval.Size = new System.Drawing.Size(106, 21);
            this.speedInterval.TabIndex = 7;
            this.speedInterval.Text = "速度警告間隔";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown1.Location = new System.Drawing.Point(150, 182);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 29);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 237);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.speedInterval);
            this.Controls.Add(this.bed);
            this.Controls.Add(this.bedLabel);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.ComboBox fuel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.ComboBox distance;
        private System.Windows.Forms.Label bedLabel;
        private System.Windows.Forms.ComboBox bed;
        private System.Windows.Forms.Label speedInterval;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}