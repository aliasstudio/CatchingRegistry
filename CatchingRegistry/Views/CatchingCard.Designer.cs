namespace CatchingRegistry.Views
{
    partial class CatchingCard
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
            this.catchCardExportBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.catchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.catchPurposeBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.catchAnimalCountLabel = new System.Windows.Forms.Label();
            this.catchAnimalsGrid = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchCardSaveBtn = new System.Windows.Forms.Button();
            this.animalCategoryCombo = new System.Windows.Forms.ComboBox();
            this.municipalNumCombo = new System.Windows.Forms.ComboBox();
            this.animalGenderCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.animalSizeBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.animalCheapNumBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.animalFeaturesBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catchAddressBox = new System.Windows.Forms.TextBox();
            this.municipalAddBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.catchAnimalAddBtn = new System.Windows.Forms.Button();
            this.catchAnimalDeleteBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.catchCardFileOpenBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.catchCardFileList = new System.Windows.Forms.ListBox();
            this.catchCardFileDeleteBtn = new System.Windows.Forms.Button();
            this.catchCardFileUploadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catchAnimalsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // catchCardExportBtn
            // 
            this.catchCardExportBtn.Location = new System.Drawing.Point(6, 75);
            this.catchCardExportBtn.Name = "catchCardExportBtn";
            this.catchCardExportBtn.Size = new System.Drawing.Size(301, 40);
            this.catchCardExportBtn.TabIndex = 0;
            this.catchCardExportBtn.Text = "Экспорт в Word";
            this.catchCardExportBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Муниципальный контракт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Адрес отлова";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Дата отлова";
            // 
            // catchDatePicker
            // 
            this.catchDatePicker.Location = new System.Drawing.Point(6, 112);
            this.catchDatePicker.Name = "catchDatePicker";
            this.catchDatePicker.Size = new System.Drawing.Size(371, 27);
            this.catchDatePicker.TabIndex = 19;
            // 
            // catchPurposeBox
            // 
            this.catchPurposeBox.Location = new System.Drawing.Point(6, 228);
            this.catchPurposeBox.Name = "catchPurposeBox";
            this.catchPurposeBox.Size = new System.Drawing.Size(371, 120);
            this.catchPurposeBox.TabIndex = 28;
            this.catchPurposeBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Количество отловленных животных:";
            // 
            // catchAnimalCountLabel
            // 
            this.catchAnimalCountLabel.AutoSize = true;
            this.catchAnimalCountLabel.Location = new System.Drawing.Point(268, 121);
            this.catchAnimalCountLabel.Name = "catchAnimalCountLabel";
            this.catchAnimalCountLabel.Size = new System.Drawing.Size(17, 20);
            this.catchAnimalCountLabel.TabIndex = 30;
            this.catchAnimalCountLabel.Text = "0";
            // 
            // catchAnimalsGrid
            // 
            this.catchAnimalsGrid.AllowUserToAddRows = false;
            this.catchAnimalsGrid.AllowUserToDeleteRows = false;
            this.catchAnimalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catchAnimalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCategory,
            this.ColumnGender,
            this.ColumnSize,
            this.ColumnFeatures});
            this.catchAnimalsGrid.Location = new System.Drawing.Point(11, 13);
            this.catchAnimalsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catchAnimalsGrid.Name = "catchAnimalsGrid";
            this.catchAnimalsGrid.ReadOnly = true;
            this.catchAnimalsGrid.RowHeadersWidth = 51;
            this.catchAnimalsGrid.RowTemplate.Height = 25;
            this.catchAnimalsGrid.Size = new System.Drawing.Size(845, 331);
            this.catchAnimalsGrid.TabIndex = 35;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Category";
            this.ColumnCategory.MinimumWidth = 6;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.Width = 125;
            // 
            // ColumnGender
            // 
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.MinimumWidth = 6;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Width = 125;
            // 
            // ColumnSize
            // 
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.MinimumWidth = 6;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            this.ColumnSize.Width = 125;
            // 
            // ColumnFeatures
            // 
            this.ColumnFeatures.HeaderText = "Features";
            this.ColumnFeatures.MinimumWidth = 6;
            this.ColumnFeatures.Name = "ColumnFeatures";
            this.ColumnFeatures.ReadOnly = true;
            this.ColumnFeatures.Width = 125;
            // 
            // catchCardSaveBtn
            // 
            this.catchCardSaveBtn.Location = new System.Drawing.Point(6, 28);
            this.catchCardSaveBtn.Name = "catchCardSaveBtn";
            this.catchCardSaveBtn.Size = new System.Drawing.Size(301, 40);
            this.catchCardSaveBtn.TabIndex = 36;
            this.catchCardSaveBtn.Text = "Сохранить";
            this.catchCardSaveBtn.UseVisualStyleBackColor = true;
            // 
            // animalCategoryCombo
            // 
            this.animalCategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalCategoryCombo.FormattingEnabled = true;
            this.animalCategoryCombo.Items.AddRange(new object[] {
            "собака",
            "щенок",
            "кошка",
            "котенок"});
            this.animalCategoryCombo.Location = new System.Drawing.Point(8, 113);
            this.animalCategoryCombo.Name = "animalCategoryCombo";
            this.animalCategoryCombo.Size = new System.Drawing.Size(220, 28);
            this.animalCategoryCombo.TabIndex = 37;
            // 
            // municipalNumCombo
            // 
            this.municipalNumCombo.FormattingEnabled = true;
            this.municipalNumCombo.Location = new System.Drawing.Point(6, 48);
            this.municipalNumCombo.Name = "municipalNumCombo";
            this.municipalNumCombo.Size = new System.Drawing.Size(271, 28);
            this.municipalNumCombo.TabIndex = 39;
            // 
            // animalGenderCombo
            // 
            this.animalGenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalGenderCombo.FormattingEnabled = true;
            this.animalGenderCombo.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.animalGenderCombo.Location = new System.Drawing.Point(239, 51);
            this.animalGenderCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.animalGenderCombo.Name = "animalGenderCombo";
            this.animalGenderCombo.Size = new System.Drawing.Size(211, 28);
            this.animalGenderCombo.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Категория";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Пол";
            // 
            // animalSizeBox
            // 
            this.animalSizeBox.Location = new System.Drawing.Point(239, 113);
            this.animalSizeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.animalSizeBox.Name = "animalSizeBox";
            this.animalSizeBox.Size = new System.Drawing.Size(211, 27);
            this.animalSizeBox.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Размер";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Особенности";
            // 
            // animalCheapNumBox
            // 
            this.animalCheapNumBox.Location = new System.Drawing.Point(8, 51);
            this.animalCheapNumBox.Name = "animalCheapNumBox";
            this.animalCheapNumBox.Size = new System.Drawing.Size(220, 27);
            this.animalCheapNumBox.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Номер чипа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.animalCheapNumBox);
            this.groupBox1.Controls.Add(this.animalFeaturesBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.animalCategoryCombo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.animalGenderCombo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.animalSizeBox);
            this.groupBox1.Location = new System.Drawing.Point(400, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 354);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о животном";
            // 
            // animalFeaturesBox
            // 
            this.animalFeaturesBox.Location = new System.Drawing.Point(8, 179);
            this.animalFeaturesBox.Name = "animalFeaturesBox";
            this.animalFeaturesBox.Size = new System.Drawing.Size(442, 169);
            this.animalFeaturesBox.TabIndex = 51;
            this.animalFeaturesBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.catchAddressBox);
            this.groupBox2.Controls.Add(this.municipalAddBtn);
            this.groupBox2.Controls.Add(this.municipalNumCombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.catchDatePicker);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.catchPurposeBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 354);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Акт отлова";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Цель отлова";
            // 
            // catchAddressBox
            // 
            this.catchAddressBox.Location = new System.Drawing.Point(6, 175);
            this.catchAddressBox.Name = "catchAddressBox";
            this.catchAddressBox.Size = new System.Drawing.Size(371, 27);
            this.catchAddressBox.TabIndex = 41;
            // 
            // municipalAddBtn
            // 
            this.municipalAddBtn.Location = new System.Drawing.Point(283, 46);
            this.municipalAddBtn.Name = "municipalAddBtn";
            this.municipalAddBtn.Size = new System.Drawing.Size(94, 32);
            this.municipalAddBtn.TabIndex = 40;
            this.municipalAddBtn.Text = "Создать";
            this.municipalAddBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.catchCardSaveBtn);
            this.groupBox3.Controls.Add(this.catchCardExportBtn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.catchAnimalCountLabel);
            this.groupBox3.Location = new System.Drawing.Point(862, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 151);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление карточкой";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.catchAnimalAddBtn);
            this.groupBox4.Controls.Add(this.catchAnimalDeleteBtn);
            this.groupBox4.Location = new System.Drawing.Point(862, 570);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 135);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление животными";
            // 
            // catchAnimalAddBtn
            // 
            this.catchAnimalAddBtn.Location = new System.Drawing.Point(6, 28);
            this.catchAnimalAddBtn.Name = "catchAnimalAddBtn";
            this.catchAnimalAddBtn.Size = new System.Drawing.Size(301, 40);
            this.catchAnimalAddBtn.TabIndex = 36;
            this.catchAnimalAddBtn.Text = "Добавить животное";
            this.catchAnimalAddBtn.UseVisualStyleBackColor = true;
            // 
            // catchAnimalDeleteBtn
            // 
            this.catchAnimalDeleteBtn.Location = new System.Drawing.Point(6, 75);
            this.catchAnimalDeleteBtn.Name = "catchAnimalDeleteBtn";
            this.catchAnimalDeleteBtn.Size = new System.Drawing.Size(301, 40);
            this.catchAnimalDeleteBtn.TabIndex = 0;
            this.catchAnimalDeleteBtn.Text = "Удалить животное";
            this.catchAnimalDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.catchCardFileOpenBtn);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.catchCardFileList);
            this.groupBox5.Controls.Add(this.catchCardFileDeleteBtn);
            this.groupBox5.Controls.Add(this.catchCardFileUploadBtn);
            this.groupBox5.Location = new System.Drawing.Point(862, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 405);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление файлами";
            // 
            // catchCardFileOpenBtn
            // 
            this.catchCardFileOpenBtn.Location = new System.Drawing.Point(6, 262);
            this.catchCardFileOpenBtn.Name = "catchCardFileOpenBtn";
            this.catchCardFileOpenBtn.Size = new System.Drawing.Size(301, 40);
            this.catchCardFileOpenBtn.TabIndex = 6;
            this.catchCardFileOpenBtn.Text = "Открыть файл";
            this.catchCardFileOpenBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Загруженные файлы";
            // 
            // catchCardFileList
            // 
            this.catchCardFileList.FormattingEnabled = true;
            this.catchCardFileList.ItemHeight = 20;
            this.catchCardFileList.Location = new System.Drawing.Point(6, 44);
            this.catchCardFileList.Name = "catchCardFileList";
            this.catchCardFileList.Size = new System.Drawing.Size(301, 204);
            this.catchCardFileList.TabIndex = 2;
            // 
            // catchCardFileDeleteBtn
            // 
            this.catchCardFileDeleteBtn.Location = new System.Drawing.Point(6, 354);
            this.catchCardFileDeleteBtn.Name = "catchCardFileDeleteBtn";
            this.catchCardFileDeleteBtn.Size = new System.Drawing.Size(301, 40);
            this.catchCardFileDeleteBtn.TabIndex = 1;
            this.catchCardFileDeleteBtn.Text = "Удалить файл";
            this.catchCardFileDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // catchCardFileUploadBtn
            // 
            this.catchCardFileUploadBtn.Location = new System.Drawing.Point(6, 308);
            this.catchCardFileUploadBtn.Name = "catchCardFileUploadBtn";
            this.catchCardFileUploadBtn.Size = new System.Drawing.Size(301, 40);
            this.catchCardFileUploadBtn.TabIndex = 0;
            this.catchCardFileUploadBtn.Text = "Загрузить файл";
            this.catchCardFileUploadBtn.UseVisualStyleBackColor = true;
            // 
            // CatchingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 717);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.catchAnimalsGrid);
            this.MaximizeBox = false;
            this.Name = "CatchingCard";
            this.Text = "Акт отлова";
            ((System.ComponentModel.ISupportInitialize)(this.catchAnimalsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button catchCardExportBtn;
        private Label label2;
        private Label label6;
        private Label label8;
        private DateTimePicker catchDatePicker;
        private RichTextBox catchPurposeBox;
        private Label label12;
        private Label catchAnimalCountLabel;
        private DataGridView catchAnimalsGrid;
        private Button catchCardSaveBtn;
        private ComboBox animalCategoryCombo;
        private ComboBox municipalNumCombo;
        private ComboBox animalGenderCombo;
        private Label label10;
        private Label label11;
        private TextBox animalSizeBox;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCategory;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewTextBoxColumn ColumnFeatures;
        private TextBox animalCheapNumBox;
        private Label label15;
        private GroupBox groupBox1;
        private RichTextBox animalFeaturesBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button catchAnimalAddBtn;
        private Button catchAnimalDeleteBtn;
        private GroupBox groupBox5;
        private Button catchCardFileDeleteBtn;
        private Button catchCardFileUploadBtn;
        private Button municipalAddBtn;
        private Label label3;
        private ListBox catchCardFileList;
        private Button catchCardFileOpenBtn;
        private Label label1;
        private TextBox catchAddressBox;
    }
}