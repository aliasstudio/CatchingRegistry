namespace CatchingRegistry.Views
{
    partial class Auth
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userPasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.userNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authBtn = new MaterialSkin.Controls.MaterialButton();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(24, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Имя";
            // 
            // userPasswordBox
            // 
            this.userPasswordBox.AnimateReadOnly = false;
            this.userPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPasswordBox.Depth = 0;
            this.userPasswordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userPasswordBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.userPasswordBox.LeadingIcon = null;
            this.userPasswordBox.Location = new System.Drawing.Point(24, 111);
            this.userPasswordBox.MaxLength = 50;
            this.userPasswordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userPasswordBox.Multiline = false;
            this.userPasswordBox.Name = "userPasswordBox";
            this.userPasswordBox.Size = new System.Drawing.Size(352, 50);
            this.userPasswordBox.TabIndex = 6;
            this.userPasswordBox.Text = "";
            this.userPasswordBox.TrailingIcon = null;
            this.userPasswordBox.UseAccent = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(24, 164);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 24);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Пароль";
            // 
            // userNameBox
            // 
            this.userNameBox.AnimateReadOnly = false;
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameBox.Depth = 0;
            this.userNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameBox.LeadingIcon = null;
            this.userNameBox.Location = new System.Drawing.Point(24, 191);
            this.userNameBox.MaxLength = 50;
            this.userNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userNameBox.Multiline = false;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Password = true;
            this.userNameBox.Size = new System.Drawing.Size(352, 50);
            this.userNameBox.TabIndex = 8;
            this.userNameBox.Text = "";
            this.userNameBox.TrailingIcon = null;
            this.userNameBox.UseAccent = false;
            // 
            // authBtn
            // 
            this.authBtn.AutoSize = false;
            this.authBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.authBtn.Depth = 0;
            this.authBtn.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authBtn.HighEmphasis = true;
            this.authBtn.Icon = null;
            this.authBtn.Location = new System.Drawing.Point(24, 260);
            this.authBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.authBtn.Name = "authBtn";
            this.authBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.authBtn.Size = new System.Drawing.Size(352, 45);
            this.authBtn.TabIndex = 9;
            this.authBtn.Text = "Войти";
            this.authBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.authBtn.UseAccentColor = false;
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(368, -2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(32, 26);
            this.siticoneControlBox1.TabIndex = 10;
            // 
            // Auth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 333);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.userPasswordBox);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox userPasswordBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox userNameBox;
        private MaterialSkin.Controls.MaterialButton authBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}