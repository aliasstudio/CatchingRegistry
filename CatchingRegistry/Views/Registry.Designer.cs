namespace CatchingRegistry.Views
{
    partial class Registry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.registryOpenBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.registryAddBtn = new MaterialSkin.Controls.MaterialButton();
            this.registryDeleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.registryExportBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.previousPageBtn = new MaterialSkin.Controls.MaterialButton();
            this.nextPageBtn = new MaterialSkin.Controls.MaterialButton();
            this.userRoleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pPageSizeApplyBtn = new MaterialSkin.Controls.MaterialButton();
            this.currentPageBox = new MaterialSkin.Controls.MaterialLabel();
            this.registryPageSizeBox = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pageSliderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.registryGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.registryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // registryOpenBtn
            // 
            this.registryOpenBtn.AutoSize = false;
            this.registryOpenBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registryOpenBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registryOpenBtn.Depth = 0;
            this.registryOpenBtn.HighEmphasis = true;
            this.registryOpenBtn.Icon = null;
            this.registryOpenBtn.Location = new System.Drawing.Point(905, 107);
            this.registryOpenBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registryOpenBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registryOpenBtn.Name = "registryOpenBtn";
            this.registryOpenBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registryOpenBtn.Size = new System.Drawing.Size(269, 36);
            this.registryOpenBtn.TabIndex = 11;
            this.registryOpenBtn.Text = "Открыть";
            this.registryOpenBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registryOpenBtn.UseAccentColor = false;
            this.registryOpenBtn.UseVisualStyleBackColor = true;
            this.registryOpenBtn.Click += new System.EventHandler(this.registryOpenBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(902, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Управление";
            // 
            // registryAddBtn
            // 
            this.registryAddBtn.AutoSize = false;
            this.registryAddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registryAddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registryAddBtn.Depth = 0;
            this.registryAddBtn.HighEmphasis = true;
            this.registryAddBtn.Icon = null;
            this.registryAddBtn.Location = new System.Drawing.Point(905, 155);
            this.registryAddBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registryAddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registryAddBtn.Name = "registryAddBtn";
            this.registryAddBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registryAddBtn.Size = new System.Drawing.Size(269, 36);
            this.registryAddBtn.TabIndex = 13;
            this.registryAddBtn.Text = "Создать";
            this.registryAddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registryAddBtn.UseAccentColor = false;
            this.registryAddBtn.UseVisualStyleBackColor = true;
            this.registryAddBtn.Click += new System.EventHandler(this.registryAddBtn_Click);
            // 
            // registryDeleteBtn
            // 
            this.registryDeleteBtn.AutoSize = false;
            this.registryDeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registryDeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registryDeleteBtn.Depth = 0;
            this.registryDeleteBtn.HighEmphasis = true;
            this.registryDeleteBtn.Icon = null;
            this.registryDeleteBtn.Location = new System.Drawing.Point(905, 203);
            this.registryDeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registryDeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registryDeleteBtn.Name = "registryDeleteBtn";
            this.registryDeleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registryDeleteBtn.Size = new System.Drawing.Size(269, 36);
            this.registryDeleteBtn.TabIndex = 14;
            this.registryDeleteBtn.Text = "Удалить";
            this.registryDeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registryDeleteBtn.UseAccentColor = false;
            this.registryDeleteBtn.UseVisualStyleBackColor = true;
            this.registryDeleteBtn.Click += new System.EventHandler(this.registryDeleteBtn_Click);
            // 
            // registryExportBtn
            // 
            this.registryExportBtn.AutoSize = false;
            this.registryExportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registryExportBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registryExportBtn.Depth = 0;
            this.registryExportBtn.HighEmphasis = true;
            this.registryExportBtn.Icon = null;
            this.registryExportBtn.Location = new System.Drawing.Point(905, 251);
            this.registryExportBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registryExportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registryExportBtn.Name = "registryExportBtn";
            this.registryExportBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registryExportBtn.Size = new System.Drawing.Size(269, 36);
            this.registryExportBtn.TabIndex = 15;
            this.registryExportBtn.Text = "Экспорт в Excel";
            this.registryExportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registryExportBtn.UseAccentColor = false;
            this.registryExportBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(902, 318);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 24);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Навигация";
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.AutoSize = false;
            this.previousPageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousPageBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousPageBtn.Depth = 0;
            this.previousPageBtn.HighEmphasis = true;
            this.previousPageBtn.Icon = null;
            this.previousPageBtn.Location = new System.Drawing.Point(905, 459);
            this.previousPageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.previousPageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.previousPageBtn.Size = new System.Drawing.Size(80, 40);
            this.previousPageBtn.TabIndex = 18;
            this.previousPageBtn.Text = "<";
            this.previousPageBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousPageBtn.UseAccentColor = false;
            this.previousPageBtn.UseVisualStyleBackColor = true;
            this.previousPageBtn.Click += new System.EventHandler(this.previousPageBtn_Click);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.AutoSize = false;
            this.nextPageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextPageBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextPageBtn.Depth = 0;
            this.nextPageBtn.HighEmphasis = true;
            this.nextPageBtn.Icon = null;
            this.nextPageBtn.Location = new System.Drawing.Point(1094, 459);
            this.nextPageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextPageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextPageBtn.Size = new System.Drawing.Size(80, 40);
            this.nextPageBtn.TabIndex = 19;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextPageBtn.UseAccentColor = false;
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Depth = 0;
            this.userRoleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userRoleLabel.Location = new System.Drawing.Point(905, 566);
            this.userRoleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(32, 19);
            this.userRoleLabel.TabIndex = 21;
            this.userRoleLabel.Text = "Role";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Depth = 0;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameLabel.Location = new System.Drawing.Point(905, 585);
            this.userNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(43, 19);
            this.userNameLabel.TabIndex = 22;
            this.userNameLabel.Text = "Name";
            // 
            // pPageSizeApplyBtn
            // 
            this.pPageSizeApplyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pPageSizeApplyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pPageSizeApplyBtn.Depth = 0;
            this.pPageSizeApplyBtn.HighEmphasis = true;
            this.pPageSizeApplyBtn.Icon = null;
            this.pPageSizeApplyBtn.Location = new System.Drawing.Point(902, 391);
            this.pPageSizeApplyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pPageSizeApplyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pPageSizeApplyBtn.Name = "pPageSizeApplyBtn";
            this.pPageSizeApplyBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pPageSizeApplyBtn.Size = new System.Drawing.Size(112, 36);
            this.pPageSizeApplyBtn.TabIndex = 25;
            this.pPageSizeApplyBtn.Text = "Применить";
            this.pPageSizeApplyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pPageSizeApplyBtn.UseAccentColor = false;
            this.pPageSizeApplyBtn.UseVisualStyleBackColor = true;
            this.pPageSizeApplyBtn.Click += new System.EventHandler(this.pageSizeApplyBtn_Click);
            // 
            // currentPageBox
            // 
            this.currentPageBox.Depth = 0;
            this.currentPageBox.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.currentPageBox.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.currentPageBox.Location = new System.Drawing.Point(992, 459);
            this.currentPageBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentPageBox.Name = "currentPageBox";
            this.currentPageBox.Size = new System.Drawing.Size(95, 40);
            this.currentPageBox.TabIndex = 27;
            this.currentPageBox.Text = "3/10";
            this.currentPageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registryPageSizeBox
            // 
            this.registryPageSizeBox.FillColor = System.Drawing.SystemColors.ControlDark;
            this.registryPageSizeBox.Location = new System.Drawing.Point(1026, 350);
            this.registryPageSizeBox.Maximum = 50;
            this.registryPageSizeBox.Minimum = 10;
            this.registryPageSizeBox.Name = "registryPageSizeBox";
            this.registryPageSizeBox.Size = new System.Drawing.Size(118, 29);
            this.registryPageSizeBox.TabIndex = 28;
            this.registryPageSizeBox.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.registryPageSizeBox.Value = 20;
            this.registryPageSizeBox.ValueChanged += new System.EventHandler(this.registryPageSizeBox_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(902, 354);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Кол-во записей";
            // 
            // pageSliderLabel
            // 
            this.pageSliderLabel.Depth = 0;
            this.pageSliderLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pageSliderLabel.Location = new System.Drawing.Point(1150, 354);
            this.pageSliderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pageSliderLabel.Name = "pageSliderLabel";
            this.pageSliderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pageSliderLabel.Size = new System.Drawing.Size(24, 19);
            this.pageSliderLabel.TabIndex = 30;
            this.pageSliderLabel.Text = "5";
            this.pageSliderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registryGrid
            // 
            this.registryGrid.AllowUserToAddRows = false;
            this.registryGrid.AllowUserToDeleteRows = false;
            this.registryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.registryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.registryGrid.ColumnHeadersHeight = 40;
            this.registryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.registryGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.registryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.registryGrid.Location = new System.Drawing.Point(0, 64);
            this.registryGrid.Margin = new System.Windows.Forms.Padding(0);
            this.registryGrid.Name = "registryGrid";
            this.registryGrid.ReadOnly = true;
            this.registryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.registryGrid.RowHeadersVisible = false;
            this.registryGrid.RowHeadersWidth = 51;
            this.registryGrid.RowTemplate.Height = 30;
            this.registryGrid.Size = new System.Drawing.Size(886, 546);
            this.registryGrid.TabIndex = 31;
            this.registryGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.registryGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.registryGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.registryGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.registryGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.registryGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.registryGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.registryGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.registryGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.registryGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registryGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.registryGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.registryGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.registryGrid.ThemeStyle.ReadOnly = true;
            this.registryGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.registryGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.registryGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registryGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.registryGrid.ThemeStyle.RowsStyle.Height = 30;
            this.registryGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.registryGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.registryGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.registryGrid_CellMouseDoubleClick);
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 610);
            this.Controls.Add(this.registryGrid);
            this.Controls.Add(this.pageSliderLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.registryPageSizeBox);
            this.Controls.Add(this.currentPageBox);
            this.Controls.Add(this.pPageSizeApplyBtn);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.registryExportBtn);
            this.Controls.Add(this.registryDeleteBtn);
            this.Controls.Add(this.registryAddBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.registryOpenBtn);
            this.DrawerWidth = 0;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Registry";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр отлова";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registry_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.registryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton registryOpenBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton registryAddBtn;
        private MaterialSkin.Controls.MaterialButton registryDeleteBtn;
        private MaterialSkin.Controls.MaterialButton registryExportBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton previousPageBtn;
        private MaterialSkin.Controls.MaterialButton nextPageBtn;
        private MaterialSkin.Controls.MaterialLabel userRoleLabel;
        private MaterialSkin.Controls.MaterialLabel userNameLabel;
        private MaterialSkin.Controls.MaterialButton pPageSizeApplyBtn;
        private MaterialSkin.Controls.MaterialLabel currentPageBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar registryPageSizeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel pageSliderLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView registryGrid;
    }
}