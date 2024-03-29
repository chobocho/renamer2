﻿namespace renamer
{
    partial class Renamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renamer));
            ReplaceGroup = new GroupBox();
            clearButton = new Button();
            replaceButton = new Button();
            replaceText = new TextBox();
            searchText = new TextBox();
            toLabel = new Label();
            fromLabel = new Label();
            groupBox5 = new GroupBox();
            folderName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            filenameText = new RichTextBox();
            newFilenameText = new RichTextBox();
            groupBox6 = new GroupBox();
            AllClear = new Button();
            revertButton = new Button();
            applyButton = new Button();
            resetButton = new Button();
            ReplaceGroup.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // ReplaceGroup
            // 
            ReplaceGroup.Controls.Add(clearButton);
            ReplaceGroup.Controls.Add(replaceButton);
            ReplaceGroup.Controls.Add(replaceText);
            ReplaceGroup.Controls.Add(searchText);
            ReplaceGroup.Controls.Add(toLabel);
            ReplaceGroup.Controls.Add(fromLabel);
            ReplaceGroup.Location = new Point(10, 10);
            ReplaceGroup.Name = "ReplaceGroup";
            ReplaceGroup.Size = new Size(400, 110);
            ReplaceGroup.TabIndex = 0;
            ReplaceGroup.TabStop = false;
            ReplaceGroup.Text = "바꾸기";
            ReplaceGroup.Enter += groupBox1_Enter;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(220, 80);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(60, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "지우기";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(70, 80);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(140, 23);
            replaceButton.TabIndex = 4;
            replaceButton.Text = "미리보기에 적용하기";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_Click;
            // 
            // replaceText
            // 
            replaceText.Location = new Point(70, 52);
            replaceText.Name = "replaceText";
            replaceText.Size = new Size(325, 23);
            replaceText.TabIndex = 3;
            replaceText.TextChanged += replaceText_TextChanged;
            replaceText.KeyDown += replaceText_KeyDown;
            // 
            // searchText
            // 
            searchText.Location = new Point(70, 22);
            searchText.Name = "searchText";
            searchText.Size = new Size(325, 23);
            searchText.TabIndex = 2;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(5, 55);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(59, 15);
            toLabel.TabIndex = 1;
            toLabel.Text = "바꿀 문자";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(5, 25);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(59, 15);
            fromLabel.TabIndex = 0;
            fromLabel.Text = "찾을 문자";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(folderName);
            groupBox5.Location = new Point(5, 126);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1105, 47);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "폴더 경로";
            // 
            // folderName
            // 
            folderName.Enabled = false;
            folderName.Location = new Point(10, 19);
            folderName.Name = "folderName";
            folderName.Size = new Size(1090, 23);
            folderName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 190);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "원래 이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 190);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "바꿀 이름";
            // 
            // filenameText
            // 
            filenameText.AllowDrop = true;
            filenameText.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filenameText.Location = new Point(5, 214);
            filenameText.Name = "filenameText";
            filenameText.Size = new Size(555, 345);
            filenameText.TabIndex = 6;
            filenameText.Text = "";
            filenameText.DragDrop += filenameText_DragDrop;
            filenameText.DragEnter += filenameText_DragEnter;
            // 
            // newFilenameText
            // 
            newFilenameText.BackColor = SystemColors.Window;
            newFilenameText.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newFilenameText.Location = new Point(560, 214);
            newFilenameText.Name = "newFilenameText";
            newFilenameText.Size = new Size(555, 345);
            newFilenameText.TabIndex = 7;
            newFilenameText.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(AllClear);
            groupBox6.Controls.Add(revertButton);
            groupBox6.Controls.Add(applyButton);
            groupBox6.Location = new Point(420, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(120, 110);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "실행하기";
            // 
            // AllClear
            // 
            AllClear.Location = new Point(6, 78);
            AllClear.Name = "AllClear";
            AllClear.Size = new Size(80, 23);
            AllClear.TabIndex = 2;
            AllClear.Text = "모두 지우기";
            AllClear.UseVisualStyleBackColor = true;
            AllClear.Click += AllClear_Click;
            // 
            // revertButton
            // 
            revertButton.Enabled = false;
            revertButton.Location = new Point(6, 50);
            revertButton.Name = "revertButton";
            revertButton.Size = new Size(80, 23);
            revertButton.TabIndex = 1;
            revertButton.Text = "되돌리기";
            revertButton.UseVisualStyleBackColor = true;
            revertButton.Click += revertButton_Click;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.FromArgb(192, 255, 255);
            applyButton.Location = new Point(6, 22);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(80, 23);
            applyButton.TabIndex = 0;
            applyButton.Text = "적용하기";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(1036, 190);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(76, 23);
            resetButton.TabIndex = 10;
            resetButton.Text = "초기화";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Renamer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 560);
            Controls.Add(groupBox6);
            Controls.Add(newFilenameText);
            Controls.Add(filenameText);
            Controls.Add(resetButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox5);
            Controls.Add(ReplaceGroup);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Renamer";
            Text = "Renamer V0.1";
            ReplaceGroup.ResumeLayout(false);
            ReplaceGroup.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ReplaceGroup;
        private GroupBox groupBox5;
        private TextBox folderName;
        private Label label1;
        private Label label2;
        private RichTextBox filenameText;
        private RichTextBox newFilenameText;
        private GroupBox groupBox6;
        private Button clearButton;
        private Button replaceButton;
        private TextBox replaceText;
        private TextBox searchText;
        private Label toLabel;
        private Label fromLabel;
        private Button AllClear;
        private Button revertButton;
        private Button applyButton;
        private Button resetButton;
    }
}
