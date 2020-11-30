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

            this.LeftEye = new Picture(LeftEyeLocation);
            this.RightEye = new Picture(RightEyeLocation);
            this.Nose = new Picture(NoseLocation);
            this.Mouse = new Picture(MouseLocation);


            ((System.ComponentModel.ISupportInitialize)(this.baseFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEye)).BeginInit();
            this.SuspendLayout();
            // 
            // CursorLocation
            // 
            this.CursorLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.CursorLocation.Location = new System.Drawing.Point(12, 12);
            this.CursorLocation.Name = "CursorLocation";
            this.CursorLocation.ReadOnly = true;
            this.CursorLocation.Size = new System.Drawing.Size(310, 47);
            this.CursorLocation.TabIndex = 7;
            // 
            // LeftEyeLocation
            // 
            this.LeftEyeLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.LeftEyeLocation.Location = new System.Drawing.Point(12, 65);
            this.LeftEyeLocation.Name = "LeftEyeLocation";
            this.LeftEyeLocation.ReadOnly = true;
            this.LeftEyeLocation.Size = new System.Drawing.Size(310, 47);
            this.LeftEyeLocation.TabIndex = 8;
            this.LeftEyeLocation.TextChanged += new System.EventHandler(this.YLocation_TextChanged);
            // 
            // RightEyeLocation
            // 
            this.RightEyeLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.RightEyeLocation.Location = new System.Drawing.Point(12, 118);
            this.RightEyeLocation.Name = "RightEyeLocation";
            this.RightEyeLocation.ReadOnly = true;
            this.RightEyeLocation.Size = new System.Drawing.Size(310, 47);
            this.RightEyeLocation.TabIndex = 13;
            // 
            // NoseLocation
            // 
            this.NoseLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.NoseLocation.Location = new System.Drawing.Point(12, 171);
            this.NoseLocation.Name = "NoseLocation";
            this.NoseLocation.ReadOnly = true;
            this.NoseLocation.Size = new System.Drawing.Size(310, 47);
            this.NoseLocation.TabIndex = 14;
            // 
            // MouseLocation
            // 
            this.MouseLocation.Font = new System.Drawing.Font("メイリオ", 10F);
            this.MouseLocation.Location = new System.Drawing.Point(12, 224);
            this.MouseLocation.Name = "MouseLocation";
            this.MouseLocation.ReadOnly = true;
            this.MouseLocation.Size = new System.Drawing.Size(310, 47);
            this.MouseLocation.TabIndex = 15;
            // 
            // baseFace
            // 
            this.baseFace.Image = global::FortuneLaugh.Properties.Resources.kao;
            this.baseFace.Location = new System.Drawing.Point(566, 12);
            this.baseFace.Name = "baseFace";
            this.baseFace.Size = new System.Drawing.Size(644, 653);
            this.baseFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baseFace.TabIndex = 12;
            this.baseFace.TabStop = false;
            // 
            // Nose
            // 
            this.Nose.Image = global::FortuneLaugh.Properties.Resources.nose;
            this.Nose.Location = new System.Drawing.Point(398, 158);
            this.Nose.Name = "Nose";
            this.Nose.Size = new System.Drawing.Size(25, 50);
            this.Nose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nose.TabIndex = 11;
            this.Nose.TabStop = false;
            // 
            // Mouse
            // 
            this.Mouse.Image = global::FortuneLaugh.Properties.Resources.mouse1;
            this.Mouse.Location = new System.Drawing.Point(328, 224);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(200, 50);
            this.Mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mouse.TabIndex = 10;
            this.Mouse.TabStop = false;
            // 
            // RightEye
            // 
            this.RightEye.Image = global::FortuneLaugh.Properties.Resources.right;
            this.RightEye.Location = new System.Drawing.Point(363, 102);
            this.RightEye.Name = "RightEye";
            this.RightEye.Size = new System.Drawing.Size(100, 50);
            this.RightEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightEye.TabIndex = 9;
            this.RightEye.TabStop = false;
            this.RightEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMouseDown);
            this.RightEye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsMouseMove);
            this.RightEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsMouseUp);
            // 
            // LeftEye
            // 
            this.LeftEye.Image = global::FortuneLaugh.Properties.Resources.left1;
            this.LeftEye.Location = new System.Drawing.Point(363, 28);
            this.LeftEye.Name = "LeftEye";
            this.LeftEye.Size = new System.Drawing.Size(100, 50);
            this.LeftEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftEye.TabIndex = 6;
            this.LeftEye.TabStop = false;
            this.LeftEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMouseDown);
            this.LeftEye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartsMouseMove);
            this.LeftEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartsMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 926);
            this.Controls.Add(this.MouseLocation);
            this.Controls.Add(this.NoseLocation);
            this.Controls.Add(this.RightEyeLocation);
            this.Controls.Add(this.Mouse);
            this.Controls.Add(this.Nose);
            this.Controls.Add(this.RightEye);
            this.Controls.Add(this.LeftEye);
            this.Controls.Add(this.LeftEyeLocation);
            this.Controls.Add(this.CursorLocation);
            this.Controls.Add(this.baseFace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveOnForm);
            ((System.ComponentModel.ISupportInitialize)(this.baseFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEye)).EndInit();
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
    }
}

