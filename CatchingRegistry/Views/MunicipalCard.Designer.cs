namespace CatchingRegistry.Views
{
    partial class MunicipalCard
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
            this.municipalGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mpOrganizationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mpGovermentBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.mpNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mpDeleteBtn = new System.Windows.Forms.Button();
            this.mpEditBtn = new System.Windows.Forms.Button();
            this.mpAddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mpNumBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.municipalGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // municipalGrid
            // 
            this.municipalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.municipalGrid.Location = new System.Drawing.Point(12, 12);
            this.municipalGrid.Name = "municipalGrid";
            this.municipalGrid.RowHeadersWidth = 51;
            this.municipalGrid.RowTemplate.Height = 29;
            this.municipalGrid.Size = new System.Drawing.Size(776, 292);
            this.municipalGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mpNumBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mpOrganizationBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mpGovermentBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mpDatePicker);
            this.groupBox1.Controls.Add(this.mpNameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о муниципальном контракте";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Исполнитель МК";
            // 
            // mpOrganizationBox
            // 
            this.mpOrganizationBox.Location = new System.Drawing.Point(6, 258);
            this.mpOrganizationBox.Name = "mpOrganizationBox";
            this.mpOrganizationBox.Size = new System.Drawing.Size(478, 27);
            this.mpOrganizationBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ОМСУ";
            // 
            // mpGovermentBox
            // 
            this.mpGovermentBox.Location = new System.Drawing.Point(6, 204);
            this.mpGovermentBox.Name = "mpGovermentBox";
            this.mpGovermentBox.Size = new System.Drawing.Size(478, 27);
            this.mpGovermentBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Муниципальное образование";
            // 
            // mpDatePicker
            // 
            this.mpDatePicker.Location = new System.Drawing.Point(6, 95);
            this.mpDatePicker.Name = "mpDatePicker";
            this.mpDatePicker.Size = new System.Drawing.Size(478, 27);
            this.mpDatePicker.TabIndex = 2;
            // 
            // mpNameBox
            // 
            this.mpNameBox.Location = new System.Drawing.Point(6, 148);
            this.mpNameBox.Name = "mpNameBox";
            this.mpNameBox.Size = new System.Drawing.Size(478, 27);
            this.mpNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заключения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mpDeleteBtn);
            this.groupBox2.Controls.Add(this.mpEditBtn);
            this.groupBox2.Controls.Add(this.mpAddBtn);
            this.groupBox2.Location = new System.Drawing.Point(513, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // mpDeleteBtn
            // 
            this.mpDeleteBtn.Location = new System.Drawing.Point(6, 118);
            this.mpDeleteBtn.Name = "mpDeleteBtn";
            this.mpDeleteBtn.Size = new System.Drawing.Size(263, 40);
            this.mpDeleteBtn.TabIndex = 2;
            this.mpDeleteBtn.Text = "Удалить";
            this.mpDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // mpEditBtn
            // 
            this.mpEditBtn.Location = new System.Drawing.Point(6, 72);
            this.mpEditBtn.Name = "mpEditBtn";
            this.mpEditBtn.Size = new System.Drawing.Size(263, 40);
            this.mpEditBtn.TabIndex = 1;
            this.mpEditBtn.Text = "Изменить";
            this.mpEditBtn.UseVisualStyleBackColor = true;
            // 
            // mpAddBtn
            // 
            this.mpAddBtn.Location = new System.Drawing.Point(6, 26);
            this.mpAddBtn.Name = "mpAddBtn";
            this.mpAddBtn.Size = new System.Drawing.Size(263, 40);
            this.mpAddBtn.TabIndex = 0;
            this.mpAddBtn.Text = "Создать";
            this.mpAddBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер МК";
            // 
            // mpNumBox
            // 
            this.mpNumBox.Location = new System.Drawing.Point(6, 46);
            this.mpNumBox.Name = "mpNumBox";
            this.mpNumBox.Size = new System.Drawing.Size(478, 27);
            this.mpNumBox.TabIndex = 8;
            // 
            // MunicipalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.municipalGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MunicipalCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Муниципальные контракты";
            ((System.ComponentModel.ISupportInitialize)(this.municipalGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView municipalGrid;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox mpOrganizationBox;
        private Label label3;
        private TextBox mpGovermentBox;
        private Label label2;
        private DateTimePicker mpDatePicker;
        private TextBox mpNameBox;
        private Label label1;
        private GroupBox groupBox2;
        private Button mpDeleteBtn;
        private Button mpEditBtn;
        private Button mpAddBtn;
        private Label label5;
        private TextBox mpNumBox;
    }
}