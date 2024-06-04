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
            this.naviDelayLabel = new System.Windows.Forms.Label();
            this.speedIntervalLabel = new System.Windows.Forms.Label();
            this.speedIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.naviDelayUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.speedIntervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviDelayUpDown)).BeginInit();
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
            // naviDelayLabel
            // 
            this.naviDelayLabel.AutoSize = true;
            this.naviDelayLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.naviDelayLabel.Location = new System.Drawing.Point(12, 92);
            this.naviDelayLabel.Name = "naviDelayLabel";
            this.naviDelayLabel.Size = new System.Drawing.Size(129, 21);
            this.naviDelayLabel.TabIndex = 3;
            this.naviDelayLabel.Text = "効果音→ナビ遅延";
            // 
            // speedIntervalLabel
            // 
            this.speedIntervalLabel.AutoSize = true;
            this.speedIntervalLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.speedIntervalLabel.Location = new System.Drawing.Point(12, 46);
            this.speedIntervalLabel.Name = "speedIntervalLabel";
            this.speedIntervalLabel.Size = new System.Drawing.Size(106, 21);
            this.speedIntervalLabel.TabIndex = 7;
            this.speedIntervalLabel.Text = "速度警告間隔";
            // 
            // speedIntervalUpDown
            // 
            this.speedIntervalUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.speedIntervalUpDown.Location = new System.Drawing.Point(150, 43);
            this.speedIntervalUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.speedIntervalUpDown.Name = "speedIntervalUpDown";
            this.speedIntervalUpDown.Size = new System.Drawing.Size(60, 29);
            this.speedIntervalUpDown.TabIndex = 8;
            this.speedIntervalUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // naviDelayUpDown
            // 
            this.naviDelayUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.naviDelayUpDown.Location = new System.Drawing.Point(150, 89);
            this.naviDelayUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.naviDelayUpDown.Name = "naviDelayUpDown";
            this.naviDelayUpDown.Size = new System.Drawing.Size(60, 29);
            this.naviDelayUpDown.TabIndex = 9;
            this.naviDelayUpDown.Value = new decimal(new int[] {
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
            this.Controls.Add(this.naviDelayUpDown);
            this.Controls.Add(this.speedIntervalUpDown);
            this.Controls.Add(this.speedIntervalLabel);
            this.Controls.Add(this.naviDelayLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.speedIntervalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviDelayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label naviDelayLabel;
        private System.Windows.Forms.Label speedIntervalLabel;
        private System.Windows.Forms.NumericUpDown speedIntervalUpDown;
        private System.Windows.Forms.NumericUpDown naviDelayUpDown;
    }
}