
namespace Labb5Test
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.saveImgButton = new System.Windows.Forms.Button();
            this.SavedImagesLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.ItemsLoadedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URLLabel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 23);
            this.textBox1.TabIndex = 1;
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(652, 41);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(99, 23);
            this.extractButton.TabIndex = 2;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBox);
            this.groupBox1.Location = new System.Drawing.Point(88, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 452);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HtmlPage";
            this.groupBox1.Visible = false;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(6, 20);
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox.Size = new System.Drawing.Size(834, 424);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // saveImgButton
            // 
            this.saveImgButton.Location = new System.Drawing.Point(847, 573);
            this.saveImgButton.Name = "saveImgButton";
            this.saveImgButton.Size = new System.Drawing.Size(81, 23);
            this.saveImgButton.TabIndex = 1;
            this.saveImgButton.Text = "Save Images";
            this.saveImgButton.UseVisualStyleBackColor = true;
            this.saveImgButton.Click += new System.EventHandler(this.saveImgButton_Click);
            // 
            // SavedImagesLabel
            // 
            this.SavedImagesLabel.AutoSize = true;
            this.SavedImagesLabel.Location = new System.Drawing.Point(94, 576);
            this.SavedImagesLabel.Name = "SavedImagesLabel";
            this.SavedImagesLabel.Size = new System.Drawing.Size(82, 15);
            this.SavedImagesLabel.TabIndex = 4;
            this.SavedImagesLabel.Text = "Saved images:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(685, 573);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(766, 573);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(75, 23);
            this.SelectAllButton.TabIndex = 6;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // ItemsLoadedLabel
            // 
            this.ItemsLoadedLabel.AutoSize = true;
            this.ItemsLoadedLabel.Location = new System.Drawing.Point(828, 103);
            this.ItemsLoadedLabel.Name = "ItemsLoadedLabel";
            this.ItemsLoadedLabel.Size = new System.Drawing.Size(78, 15);
            this.ItemsLoadedLabel.TabIndex = 7;
            this.ItemsLoadedLabel.Text = "Items loaded:";
            this.ItemsLoadedLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 607);
            this.Controls.Add(this.ItemsLoadedLabel);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SavedImagesLabel);
            this.Controls.Add(this.saveImgButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HtmlExtractor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveImgButton;
        private System.Windows.Forms.Label SavedImagesLabel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Label ItemsLoadedLabel;
    }
}

