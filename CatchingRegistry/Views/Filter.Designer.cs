namespace CatchingRegistry.Views
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
            this.catchingNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterApplyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchingNumberTextBox
            // 
            this.catchingNumberTextBox.Location = new System.Drawing.Point(33, 33);
            this.catchingNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catchingNumberTextBox.Name = "catchingNumberTextBox";
            this.catchingNumberTextBox.Size = new System.Drawing.Size(180, 23);
            this.catchingNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ акта отлова";
            // 
            // filterApplyBtn
            // 
            this.filterApplyBtn.Location = new System.Drawing.Point(34, 82);
            this.filterApplyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterApplyBtn.Name = "filterApplyBtn";
            this.filterApplyBtn.Size = new System.Drawing.Size(179, 26);
            this.filterApplyBtn.TabIndex = 2;
            this.filterApplyBtn.Text = "Применить";
            this.filterApplyBtn.UseVisualStyleBackColor = true;
            this.filterApplyBtn.Click += new System.EventHandler(this.filterApplyBtn_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 141);
            this.Controls.Add(this.filterApplyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catchingNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox catchingNumberTextBox;
        private Label label1;
        private Button filterApplyBtn;
    }
}