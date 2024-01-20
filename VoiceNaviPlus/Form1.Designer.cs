namespace VoiceNaviPlus
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.memTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.playingLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本体設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.インストールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pluginsLabel = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.profiles = new System.Windows.Forms.ComboBox();
            this.profilesLabel = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.notify = new System.Windows.Forms.ToolStripStatusLabel();
            this.playing = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // memTimer
            // 
            this.memTimer.Enabled = true;
            this.memTimer.Tick += new System.EventHandler(this.memTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playingLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // playingLabel
            // 
            this.playingLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.playingLabel.Name = "playingLabel";
            this.playingLabel.Size = new System.Drawing.Size(65, 21);
            this.playingLabel.Text = "再生中 :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditProfileMenuItem,
            this.本体設定ToolStripMenuItem,
            this.インストールToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // EditProfileMenuItem
            // 
            this.EditProfileMenuItem.Name = "EditProfileMenuItem";
            this.EditProfileMenuItem.Size = new System.Drawing.Size(184, 22);
            this.EditProfileMenuItem.Text = "現在のプロファイル編集";
            this.EditProfileMenuItem.Click += new System.EventHandler(this.EditProfileMenuItem_Click);
            // 
            // 本体設定ToolStripMenuItem
            // 
            this.本体設定ToolStripMenuItem.Name = "本体設定ToolStripMenuItem";
            this.本体設定ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.本体設定ToolStripMenuItem.Text = "本体設定";
            // 
            // インストールToolStripMenuItem
            // 
            this.インストールToolStripMenuItem.Name = "インストールToolStripMenuItem";
            this.インストールToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.インストールToolStripMenuItem.Text = "インストール";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "※未実装※",
            "DiscordRPC",
            "WebServer",
            "obs-websocket"});
            this.listBox1.Location = new System.Drawing.Point(7, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(156, 172);
            this.listBox1.TabIndex = 4;
            // 
            // pluginsLabel
            // 
            this.pluginsLabel.AutoSize = true;
            this.pluginsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pluginsLabel.Location = new System.Drawing.Point(12, 11);
            this.pluginsLabel.Name = "pluginsLabel";
            this.pluginsLabel.Size = new System.Drawing.Size(114, 21);
            this.pluginsLabel.TabIndex = 5;
            this.pluginsLabel.Text = "有効なプラグイン";
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.AutoSize = false;
            this.volume.Enabled = false;
            this.volume.Location = new System.Drawing.Point(233, 287);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(99, 20);
            this.volume.TabIndex = 6;
            this.volume.TickFrequency = 10;
            this.volume.Value = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.profiles);
            this.splitContainer1.Panel1.Controls.Add(this.profilesLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.pluginsLabel);
            this.splitContainer1.Size = new System.Drawing.Size(344, 229);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 7;
            // 
            // profiles
            // 
            this.profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profiles.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.profiles.FormattingEnabled = true;
            this.profiles.Location = new System.Drawing.Point(7, 35);
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(156, 29);
            this.profiles.TabIndex = 1;
            // 
            // profilesLabel
            // 
            this.profilesLabel.AutoSize = true;
            this.profilesLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.profilesLabel.Location = new System.Drawing.Point(13, 11);
            this.profilesLabel.Name = "profilesLabel";
            this.profilesLabel.Size = new System.Drawing.Size(78, 21);
            this.profilesLabel.TabIndex = 0;
            this.profilesLabel.Text = "プロファイル";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notify});
            this.statusStrip2.Location = new System.Drawing.Point(0, 259);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(344, 26);
            this.statusStrip2.TabIndex = 8;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // notify
            // 
            this.notify.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(105, 21);
            this.notify.Text = "通知用テキスト";
            // 
            // playing
            // 
            this.playing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playing.AutoSize = true;
            this.playing.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.playing.Location = new System.Drawing.Point(65, 289);
            this.playing.Name = "playing";
            this.playing.Size = new System.Drawing.Size(89, 21);
            this.playing.TabIndex = 9;
            this.playing.Text = "初期テキスト";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 311);
            this.Controls.Add(this.playing);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VoiceNaviPlus / こえナビ+ v0.1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer memTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel playingLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label pluginsLabel;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox profiles;
        private System.Windows.Forms.Label profilesLabel;
        private System.Windows.Forms.ToolStripMenuItem EditProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem インストールToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel notify;
        private System.Windows.Forms.ToolStripMenuItem 本体設定ToolStripMenuItem;
        private System.Windows.Forms.Label playing;
    }
}

