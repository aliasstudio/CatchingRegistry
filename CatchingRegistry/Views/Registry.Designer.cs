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
            this.registryGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registryAddBtn = new System.Windows.Forms.Button();
            this.registryDeleteBtn = new System.Windows.Forms.Button();
            this.registryOpenBtn = new System.Windows.Forms.Button();
            this.registryExportBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.recordsCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.previousPageBtn = new System.Windows.Forms.Button();
            this.municipalListOpenBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.registryGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // registryGrid
            // 
            this.registryGrid.AllowUserToAddRows = false;
            this.registryGrid.AllowUserToDeleteRows = false;
            this.registryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registryGrid.Location = new System.Drawing.Point(3, 23);
            this.registryGrid.Name = "registryGrid";
            this.registryGrid.ReadOnly = true;
            this.registryGrid.RowHeadersVisible = false;
            this.registryGrid.RowHeadersWidth = 51;
            this.registryGrid.RowTemplate.Height = 29;
            this.registryGrid.Size = new System.Drawing.Size(845, 508);
            this.registryGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registryGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Реестр отлова";
            // 
            // registryAddBtn
            // 
            this.registryAddBtn.Location = new System.Drawing.Point(6, 72);
            this.registryAddBtn.Name = "registryAddBtn";
            this.registryAddBtn.Size = new System.Drawing.Size(255, 40);
            this.registryAddBtn.TabIndex = 2;
            this.registryAddBtn.Text = "Создать";
            this.registryAddBtn.UseVisualStyleBackColor = true;
            this.registryAddBtn.Click += new System.EventHandler(this.registryAddBtn_Click);
            // 
            // registryDeleteBtn
            // 
            this.registryDeleteBtn.Location = new System.Drawing.Point(6, 118);
            this.registryDeleteBtn.Name = "registryDeleteBtn";
            this.registryDeleteBtn.Size = new System.Drawing.Size(255, 40);
            this.registryDeleteBtn.TabIndex = 3;
            this.registryDeleteBtn.Text = "Удалить";
            this.registryDeleteBtn.UseVisualStyleBackColor = true;
            this.registryDeleteBtn.Click += new System.EventHandler(this.registryDeleteBtn_Click);
            // 
            // registryOpenBtn
            // 
            this.registryOpenBtn.Location = new System.Drawing.Point(6, 26);
            this.registryOpenBtn.Name = "registryOpenBtn";
            this.registryOpenBtn.Size = new System.Drawing.Size(255, 40);
            this.registryOpenBtn.TabIndex = 4;
            this.registryOpenBtn.Text = "Открыть";
            this.registryOpenBtn.UseVisualStyleBackColor = true;
            // 
            // registryExportBtn
            // 
            this.registryExportBtn.Location = new System.Drawing.Point(6, 164);
            this.registryExportBtn.Name = "registryExportBtn";
            this.registryExportBtn.Size = new System.Drawing.Size(255, 40);
            this.registryExportBtn.TabIndex = 6;
            this.registryExportBtn.Text = "Экспорт в Excel";
            this.registryExportBtn.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(6, 205);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(46, 20);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "name";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Location = new System.Drawing.Point(6, 185);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(35, 20);
            this.userRoleLabel.TabIndex = 8;
            this.userRoleLabel.Text = "role";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.registryOpenBtn);
            this.groupBox2.Controls.Add(this.registryAddBtn);
            this.groupBox2.Controls.Add(this.registryDeleteBtn);
            this.groupBox2.Controls.Add(this.registryExportBtn);
            this.groupBox2.Location = new System.Drawing.Point(869, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentPageLabel);
            this.groupBox3.Controls.Add(this.recordsCountBox);
            this.groupBox3.Controls.Add(this.userNameLabel);
            this.groupBox3.Controls.Add(this.userRoleLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.nextPageBtn);
            this.groupBox3.Controls.Add(this.previousPageBtn);
            this.groupBox3.Location = new System.Drawing.Point(869, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 228);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Навигация";
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(112, 89);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(39, 20);
            this.currentPageLabel.TabIndex = 4;
            this.currentPageLabel.Text = "3/10";
            // 
            // recordsCountBox
            // 
            this.recordsCountBox.Location = new System.Drawing.Point(7, 46);
            this.recordsCountBox.Name = "recordsCountBox";
            this.recordsCountBox.Size = new System.Drawing.Size(254, 27);
            this.recordsCountBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество записей на странице";
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Location = new System.Drawing.Point(181, 79);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(80, 40);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Location = new System.Drawing.Point(6, 79);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(80, 40);
            this.previousPageBtn.TabIndex = 0;
            this.previousPageBtn.Text = "<";
            this.previousPageBtn.UseVisualStyleBackColor = true;
            // 
            // municipalListOpenBtn
            // 
            this.municipalListOpenBtn.Location = new System.Drawing.Point(6, 26);
            this.municipalListOpenBtn.Name = "municipalListOpenBtn";
            this.municipalListOpenBtn.Size = new System.Drawing.Size(255, 40);
            this.municipalListOpenBtn.TabIndex = 7;
            this.municipalListOpenBtn.Text = "Муниципальные контракты";
            this.municipalListOpenBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.municipalListOpenBtn);
            this.groupBox4.Location = new System.Drawing.Point(869, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 79);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Таблицы";
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 556);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Registry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр отлова";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registry_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.registryGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView registryGrid;
        private GroupBox groupBox1;
        private Button registryAddBtn;
        private Button registryDeleteBtn;
        private Button registryOpenBtn;
        private Button registryExportBtn;
        private Label userNameLabel;
        private Label userRoleLabel;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label currentPageLabel;
        private TextBox recordsCountBox;
        private Label label1;
        private Button nextPageBtn;
        private Button previousPageBtn;
        private Button municipalListOpenBtn;
        private GroupBox groupBox4;
    }
}