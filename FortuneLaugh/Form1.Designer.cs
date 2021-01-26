namespace FortuneLaugh
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
            this.CursorLocation = new System.Windows.Forms.TextBox();
            this.LeftEyeLocation = new System.Windows.Forms.TextBox();
            this.RightEyeLocation = new System.Windows.Forms.TextBox();
            this.NoseLocation = new System.Windows.Forms.TextBox();
            this.MouseLocation = new System.Windows.Forms.TextBox();
            this.baseFace = new System.Windows.Forms.PictureBox();
            this.scoring = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.RightEye = new FortuneLaugh.Picture();
            this.LeftEye = new FortuneLaugh.Picture();
            this.Nose = new FortuneLaugh.Picture();
            this.Mouse = new FortuneLaugh.Picture();
            this.absolute = new System.Windows.Forms.RadioButton();
            this.relative = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.baseFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mouse)).BeginInit();
            this.SuspendLayout();
            // 
            // CursorLocation
            // 
            this.CursorLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.CursorLocation.Location = new System.Drawing.Point(13, 12);
            this.CursorLocation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CursorLocation.Name = "CursorLocation";
            this.CursorLocation.ReadOnly = true;
            this.CursorLocation.Size = new System.Drawing.Size(396, 47);
            this.CursorLocation.TabIndex = 7;
            // 
            // LeftEyeLocation
            // 
            this.LeftEyeLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.LeftEyeLocation.Location = new System.Drawing.Point(13, 64);
            this.LeftEyeLocation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LeftEyeLocation.Name = "LeftEyeLocation";
            this.LeftEyeLocation.ReadOnly = true;
            this.LeftEyeLocation.Size = new System.Drawing.Size(396, 47);
            this.LeftEyeLocation.TabIndex = 8;
            // 
            // RightEyeLocation
            // 
            this.RightEyeLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.RightEyeLocation.Location = new System.Drawing.Point(13, 118);
            this.RightEyeLocation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RightEyeLocation.Name = "RightEyeLocation";
            this.RightEyeLocation.ReadOnly = true;
            this.RightEyeLocation.Size = new System.Drawing.Size(396, 47);
            this.RightEyeLocation.TabIndex = 13;
            // 
            // NoseLocation
            // 
            this.NoseLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.NoseLocation.Location = new System.Drawing.Point(13, 172);
            this.NoseLocation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.NoseLocation.Name = "NoseLocation";
            this.NoseLocation.ReadOnly = true;
            this.NoseLocation.Size = new System.Drawing.Size(396, 47);
            this.NoseLocation.TabIndex = 14;
            // 
            // MouseLocation
            // 
            this.MouseLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.MouseLocation.Location = new System.Drawing.Point(13, 224);
            this.MouseLocation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MouseLocation.Name = "MouseLocation";
            this.MouseLocation.ReadOnly = true;
            this.MouseLocation.Size = new System.Drawing.Size(396, 47);
            this.MouseLocation.TabIndex = 15;
            // 
            // baseFace
            // 
            this.baseFace.Image = global::FortuneLaugh.Properties.Resources.kao;
            this.baseFace.Location = new System.Drawing.Point(566, 12);
            this.baseFace.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseFace.Name = "baseFace";
            this.baseFace.Size = new System.Drawing.Size(644, 652);
            this.baseFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baseFace.TabIndex = 12;
            this.baseFace.TabStop = false;
            this.baseFace.MouseEnter += new System.EventHandler(this.BaseFaceMouseEnter);
            this.baseFace.MouseLeave += new System.EventHandler(this.BaseFaceMouseLeave);
            // 
            // scoring
            // 
            this.scoring.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.scoring.Location = new System.Drawing.Point(1092, 680);
            this.scoring.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.scoring.Name = "scoring";
            this.scoring.Size = new System.Drawing.Size(119, 60);
            this.scoring.TabIndex = 16;
            this.scoring.Text = "採点";
            this.scoring.UseVisualStyleBackColor = true;
            this.scoring.Click += new System.EventHandler(this.ScoringClicked);
            // 
            // scoreBox
            // 
            this.scoreBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.scoreBox.Location = new System.Drawing.Point(858, 748);
            this.scoreBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(353, 61);
            this.scoreBox.TabIndex = 17;
            // 
            // RightEye
            // 
            this.RightEye.BackColor = System.Drawing.Color.Transparent;
            this.RightEye.Image = global::FortuneLaugh.Properties.Resources.right;
            this.RightEye.Location = new System.Drawing.Point(247, 330);
            this.RightEye.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RightEye.Name = "RightEye";
            this.RightEye.Size = new System.Drawing.Size(100, 50);
            this.RightEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightEye.TabIndex = 9;
            this.RightEye.TabStop = false;
            this.RightEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMouseDown);
            this.RightEye.MouseEnter += new System.EventHandler(this.PartsMouseEnter);
            this.RightEye.MouseLeave += new System.EventHandler(this.PartsMouseLeave);
            this.RightEye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsMouseMove);
            this.RightEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsMouseUp);
            // 
            // LeftEye
            // 
            this.LeftEye.BackColor = System.Drawing.Color.Transparent;
            this.LeftEye.Image = global::FortuneLaugh.Properties.Resources.left1;
            this.LeftEye.Location = new System.Drawing.Point(28, 330);
            this.LeftEye.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LeftEye.Name = "LeftEye";
            this.LeftEye.Size = new System.Drawing.Size(100, 50);
            this.LeftEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftEye.TabIndex = 6;
            this.LeftEye.TabStop = false;
            this.LeftEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMouseDown);
            this.LeftEye.MouseEnter += new System.EventHandler(this.PartsMouseEnter);
            this.LeftEye.MouseLeave += new System.EventHandler(this.PartsMouseLeave);
            this.LeftEye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsMouseMove);
            this.LeftEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsMouseUp);
            // 
            // Nose
            // 
            this.Nose.BackColor = System.Drawing.Color.Transparent;
            this.Nose.Image = global::FortuneLaugh.Properties.Resources.nose;
            this.Nose.Location = new System.Drawing.Point(182, 440);
            this.Nose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Nose.Name = "Nose";
            this.Nose.Size = new System.Drawing.Size(26, 50);
            this.Nose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nose.TabIndex = 11;
            this.Nose.TabStop = false;
            this.Nose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMouseDown);
            this.Nose.MouseEnter += new System.EventHandler(this.PartsMouseEnter);
            this.Nose.MouseLeave += new System.EventHandler(this.PartsMouseLeave);
            this.Nose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsMouseMove);
            this.Nose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsMouseUp);
            // 
            // Mouse
            // 
            this.Mouse.BackColor = System.Drawing.Color.Transparent;
            this.Mouse.Image = global::FortuneLaugh.Properties.Resources.mouse1;
            this.Mouse.Location = new System.Drawing.Point(76, 565);
            this.Mouse.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(199, 50);
            this.Mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mouse.TabIndex = 10;
            this.Mouse.TabStop = false;
            this.Mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMouseDown);
            this.Mouse.MouseEnter += new System.EventHandler(this.PartsMouseEnter);
            this.Mouse.MouseLeave += new System.EventHandler(this.PartsMouseLeave);
            this.Mouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsMouseMove);
            this.Mouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsMouseUp);
            // 
            // absolute
            // 
            this.absolute.AutoSize = true;
            this.absolute.Checked = true;
            this.absolute.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.absolute.Location = new System.Drawing.Point(585, 680);
            this.absolute.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.absolute.Name = "absolute";
            this.absolute.Size = new System.Drawing.Size(174, 37);
            this.absolute.TabIndex = 18;
            this.absolute.TabStop = true;
            this.absolute.Text = "絶対評価";
            this.absolute.UseVisualStyleBackColor = true;
            this.absolute.CheckedChanged += new System.EventHandler(this.AbsoluteCheckedChanged);
            // 
            // relative
            // 
            this.relative.AutoSize = true;
            this.relative.BackColor = System.Drawing.Color.Transparent;
            this.relative.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.relative.Location = new System.Drawing.Point(858, 680);
            this.relative.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.relative.Name = "relative";
            this.relative.Size = new System.Drawing.Size(174, 37);
            this.relative.TabIndex = 19;
            this.relative.Text = "相対評価";
            this.relative.UseVisualStyleBackColor = false;
            this.relative.CheckedChanged += new System.EventHandler(this.RelativeCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 826);
            this.Controls.Add(this.relative);
            this.Controls.Add(this.absolute);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoring);
            this.Controls.Add(this.MouseLocation);
            this.Controls.Add(this.NoseLocation);
            this.Controls.Add(this.RightEyeLocation);
            this.Controls.Add(this.LeftEyeLocation);
            this.Controls.Add(this.CursorLocation);
            this.Controls.Add(this.baseFace);
            this.Controls.Add(this.LeftEye);
            this.Controls.Add(this.RightEye);
            this.Controls.Add(this.Nose);
            this.Controls.Add(this.Mouse);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "(笑)";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveOnForm);
            ((System.ComponentModel.ISupportInitialize)(this.baseFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CursorLocation;
        private System.Windows.Forms.TextBox LeftEyeLocation;
        private System.Windows.Forms.PictureBox baseFace;
        private System.Windows.Forms.TextBox RightEyeLocation;
        private System.Windows.Forms.TextBox NoseLocation;
        private System.Windows.Forms.TextBox MouseLocation;
        private Picture LeftEye;
        private Picture RightEye;
        private Picture Mouse;
        private Picture Nose;
        private System.Windows.Forms.Button scoring;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.RadioButton absolute;
        private System.Windows.Forms.RadioButton relative;
    }
}

