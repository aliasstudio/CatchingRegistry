﻿namespace CatchingRegistry.Views
{
    partial class Filter
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
            this.components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.filterBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.filterApplyBtn = new MaterialSkin.Controls.MaterialButton();
            this.filterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.filterResetBtn = new MaterialSkin.Controls.MaterialButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(259, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(26, 26);
            this.siticoneControlBox1.TabIndex = 3;
            // 
            // filterBox
            // 
            this.filterBox.DefaultText = "";
            this.filterBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filterBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filterBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterBox.Location = new System.Drawing.Point(22, 54);
            this.filterBox.Name = "filterBox";
            this.filterBox.PasswordChar = '\0';
            this.filterBox.PlaceholderText = "";
            this.filterBox.SelectedText = "";
            this.filterBox.Size = new System.Drawing.Size(239, 38);
            this.filterBox.TabIndex = 4;
            // 
            // filterApplyBtn
            // 
            this.filterApplyBtn.AutoSize = false;
            this.filterApplyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterApplyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.filterApplyBtn.Depth = 0;
            this.filterApplyBtn.HighEmphasis = true;
            this.filterApplyBtn.Icon = null;
            this.filterApplyBtn.Location = new System.Drawing.Point(22, 99);
            this.filterApplyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.filterApplyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterApplyBtn.Name = "filterApplyBtn";
            this.filterApplyBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.filterApplyBtn.Size = new System.Drawing.Size(117, 38);
            this.filterApplyBtn.TabIndex = 5;
            this.filterApplyBtn.Text = "Применить";
            this.filterApplyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.filterApplyBtn.UseAccentColor = false;
            this.filterApplyBtn.UseVisualStyleBackColor = true;
            this.filterApplyBtn.Click += new System.EventHandler(this.filterApplyBtn_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Depth = 0;
            this.filterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.filterLabel.Location = new System.Drawing.Point(22, 32);
            this.filterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(107, 19);
            this.filterLabel.TabIndex = 6;
            this.filterLabel.Text = "materialLabel1";
            // 
            // filterResetBtn
            // 
            this.filterResetBtn.AutoSize = false;
            this.filterResetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterResetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.filterResetBtn.Depth = 0;
            this.filterResetBtn.HighEmphasis = true;
            this.filterResetBtn.Icon = null;
            this.filterResetBtn.Location = new System.Drawing.Point(144, 99);
            this.filterResetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.filterResetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterResetBtn.Name = "filterResetBtn";
            this.filterResetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.filterResetBtn.Size = new System.Drawing.Size(117, 38);
            this.filterResetBtn.TabIndex = 7;
            this.filterResetBtn.Text = "Сброс";
            this.filterResetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.filterResetBtn.UseAccentColor = false;
            this.filterResetBtn.UseVisualStyleBackColor = true;
            this.filterResetBtn.Click += new System.EventHandler(this.filterResetBtn_Click);
            // 
            // siticoneSeparator1
            // 
            siticoneSeparator1.BackColor = System.Drawing.Color.Transparent;
            siticoneSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            siticoneSeparator1.FillThickness = 26;
            siticoneSeparator1.Location = new System.Drawing.Point(-2, 0);
            siticoneSeparator1.Name = "siticoneSeparator1";
            siticoneSeparator1.Size = new System.Drawing.Size(261, 26);
            siticoneSeparator1.TabIndex = 8;
            siticoneSeparator1.UseTransparentBackground = true;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(12, 3);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(57, 20);
            this.siticoneHtmlLabel1.TabIndex = 9;
            this.siticoneHtmlLabel1.Text = "Фильтр";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 156);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(siticoneSeparator1);
            this.Controls.Add(this.filterResetBtn);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterApplyBtn);
            this.Controls.Add(this.filterBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private MaterialSkin.Controls.MaterialButton filterApplyBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox filterBox;
        private MaterialSkin.Controls.MaterialButton filterResetBtn;
        private MaterialSkin.Controls.MaterialLabel filterLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
    }
}