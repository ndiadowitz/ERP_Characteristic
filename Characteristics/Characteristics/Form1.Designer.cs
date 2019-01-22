namespace Characteristics
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.charBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.charGetList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CharNameBox = new System.Windows.Forms.TextBox();
            this.DeleteCharButton = new System.Windows.Forms.Button();
            this.CreateCharButton = new System.Windows.Forms.Button();
            this.removeLongText = new System.Windows.Forms.Button();
            this.setLongText = new System.Windows.Forms.Button();
            this.setLongTextString = new System.Windows.Forms.TextBox();
            this.getLongTextString = new System.Windows.Forms.TextBox();
            this.getLongText = new System.Windows.Forms.Button();
            this.charDetail = new System.Windows.Forms.TextBox();
            this.charGetDetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classDetail = new System.Windows.Forms.TextBox();
            this.classGetDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ListBox();
            this.classGetList = new System.Windows.Forms.Button();
            this.transactionStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateClassButton = new System.Windows.Forms.Button();
            this.ChangeClassButton = new System.Windows.Forms.Button();
            this.DeleteClassButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.changeClassString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // charBox
            // 
            this.charBox.FormattingEnabled = true;
            this.charBox.Location = new System.Drawing.Point(134, 32);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(245, 199);
            this.charBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Characteristic elemente";
            // 
            // charGetList
            // 
            this.charGetList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.charGetList.Location = new System.Drawing.Point(6, 19);
            this.charGetList.Name = "charGetList";
            this.charGetList.Size = new System.Drawing.Size(122, 23);
            this.charGetList.TabIndex = 2;
            this.charGetList.Text = "List elements";
            this.charGetList.UseVisualStyleBackColor = true;
            this.charGetList.Click += new System.EventHandler(this.CharGetList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CharNameBox);
            this.groupBox1.Controls.Add(this.DeleteCharButton);
            this.groupBox1.Controls.Add(this.CreateCharButton);
            this.groupBox1.Controls.Add(this.removeLongText);
            this.groupBox1.Controls.Add(this.setLongText);
            this.groupBox1.Controls.Add(this.setLongTextString);
            this.groupBox1.Controls.Add(this.getLongTextString);
            this.groupBox1.Controls.Add(this.getLongText);
            this.groupBox1.Controls.Add(this.charDetail);
            this.groupBox1.Controls.Add(this.charGetDetail);
            this.groupBox1.Controls.Add(this.charGetList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.charBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 419);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characteristic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            // 
            // CharNameBox
            // 
            this.CharNameBox.Location = new System.Drawing.Point(47, 357);
            this.CharNameBox.Name = "CharNameBox";
            this.CharNameBox.Size = new System.Drawing.Size(204, 20);
            this.CharNameBox.TabIndex = 14;
            // 
            // DeleteCharButton
            // 
            this.DeleteCharButton.Location = new System.Drawing.Point(6, 323);
            this.DeleteCharButton.Name = "DeleteCharButton";
            this.DeleteCharButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCharButton.TabIndex = 13;
            this.DeleteCharButton.Text = "Delete";
            this.DeleteCharButton.UseVisualStyleBackColor = true;
            this.DeleteCharButton.Click += new System.EventHandler(this.DeleteCharButton_Click);
            // 
            // CreateCharButton
            // 
            this.CreateCharButton.Location = new System.Drawing.Point(257, 357);
            this.CreateCharButton.Name = "CreateCharButton";
            this.CreateCharButton.Size = new System.Drawing.Size(122, 23);
            this.CreateCharButton.TabIndex = 12;
            this.CreateCharButton.Text = "Create";
            this.CreateCharButton.UseVisualStyleBackColor = true;
            this.CreateCharButton.Click += new System.EventHandler(this.CreateCharButton_Click);
            // 
            // removeLongText
            // 
            this.removeLongText.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeLongText.Location = new System.Drawing.Point(6, 294);
            this.removeLongText.Name = "removeLongText";
            this.removeLongText.Size = new System.Drawing.Size(373, 23);
            this.removeLongText.TabIndex = 9;
            this.removeLongText.Text = "Remove Longtext";
            this.removeLongText.UseVisualStyleBackColor = true;
            this.removeLongText.Click += new System.EventHandler(this.removeLongText_Click);
            // 
            // setLongText
            // 
            this.setLongText.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.setLongText.Location = new System.Drawing.Point(257, 266);
            this.setLongText.Name = "setLongText";
            this.setLongText.Size = new System.Drawing.Size(122, 23);
            this.setLongText.TabIndex = 8;
            this.setLongText.Text = "Set Longtext";
            this.setLongText.UseVisualStyleBackColor = true;
            this.setLongText.Click += new System.EventHandler(this.setLongText_Click);
            // 
            // setLongTextString
            // 
            this.setLongTextString.Location = new System.Drawing.Point(6, 268);
            this.setLongTextString.Name = "setLongTextString";
            this.setLongTextString.Size = new System.Drawing.Size(245, 20);
            this.setLongTextString.TabIndex = 7;
            // 
            // getLongTextString
            // 
            this.getLongTextString.Location = new System.Drawing.Point(134, 239);
            this.getLongTextString.Name = "getLongTextString";
            this.getLongTextString.Size = new System.Drawing.Size(245, 20);
            this.getLongTextString.TabIndex = 6;
            // 
            // getLongText
            // 
            this.getLongText.Location = new System.Drawing.Point(6, 237);
            this.getLongText.Name = "getLongText";
            this.getLongText.Size = new System.Drawing.Size(122, 23);
            this.getLongText.TabIndex = 5;
            this.getLongText.Text = "Get Longtext";
            this.getLongText.UseVisualStyleBackColor = true;
            this.getLongText.Click += new System.EventHandler(this.getLongText_Click);
            // 
            // charDetail
            // 
            this.charDetail.Location = new System.Drawing.Point(6, 81);
            this.charDetail.Multiline = true;
            this.charDetail.Name = "charDetail";
            this.charDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.charDetail.Size = new System.Drawing.Size(122, 150);
            this.charDetail.TabIndex = 4;
            this.charDetail.WordWrap = false;
            // 
            // charGetDetail
            // 
            this.charGetDetail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.charGetDetail.Location = new System.Drawing.Point(6, 52);
            this.charGetDetail.Name = "charGetDetail";
            this.charGetDetail.Size = new System.Drawing.Size(122, 23);
            this.charGetDetail.TabIndex = 3;
            this.charGetDetail.Text = "Get Detail ";
            this.charGetDetail.UseVisualStyleBackColor = true;
            this.charGetDetail.Click += new System.EventHandler(this.charGetDetail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.changeClassString);
            this.groupBox2.Controls.Add(this.ClassNameTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DeleteClassButton);
            this.groupBox2.Controls.Add(this.ChangeClassButton);
            this.groupBox2.Controls.Add(this.CreateClassButton);
            this.groupBox2.Controls.Add(this.classDetail);
            this.groupBox2.Controls.Add(this.classGetDetail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.classBox);
            this.groupBox2.Controls.Add(this.classGetList);
            this.groupBox2.Location = new System.Drawing.Point(403, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 327);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class";
            // 
            // classDetail
            // 
            this.classDetail.Location = new System.Drawing.Point(6, 81);
            this.classDetail.Multiline = true;
            this.classDetail.Name = "classDetail";
            this.classDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.classDetail.Size = new System.Drawing.Size(137, 150);
            this.classDetail.TabIndex = 4;
            this.classDetail.WordWrap = false;
            // 
            // classGetDetail
            // 
            this.classGetDetail.Location = new System.Drawing.Point(6, 52);
            this.classGetDetail.Name = "classGetDetail";
            this.classGetDetail.Size = new System.Drawing.Size(137, 23);
            this.classGetDetail.TabIndex = 3;
            this.classGetDetail.Text = "Get Detail";
            this.classGetDetail.UseVisualStyleBackColor = true;
            this.classGetDetail.Click += new System.EventHandler(this.classGetDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class elemente";
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(149, 32);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(230, 199);
            this.classBox.TabIndex = 1;
            // 
            // classGetList
            // 
            this.classGetList.Location = new System.Drawing.Point(6, 16);
            this.classGetList.Name = "classGetList";
            this.classGetList.Size = new System.Drawing.Size(137, 23);
            this.classGetList.TabIndex = 0;
            this.classGetList.Text = "List elements";
            this.classGetList.UseVisualStyleBackColor = true;
            this.classGetList.Click += new System.EventHandler(this.classGetList_Click);
            // 
            // transactionStatus
            // 
            this.transactionStatus.Location = new System.Drawing.Point(12, 476);
            this.transactionStatus.Multiline = true;
            this.transactionStatus.Name = "transactionStatus";
            this.transactionStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.transactionStatus.Size = new System.Drawing.Size(776, 76);
            this.transactionStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Transanction status";
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.Location = new System.Drawing.Point(257, 271);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(122, 23);
            this.CreateClassButton.TabIndex = 5;
            this.CreateClassButton.Text = "Create";
            this.CreateClassButton.UseVisualStyleBackColor = true;
            this.CreateClassButton.Click += new System.EventHandler(this.CreateClassButton_Click);
            // 
            // ChangeClassButton
            // 
            this.ChangeClassButton.Location = new System.Drawing.Point(257, 300);
            this.ChangeClassButton.Name = "ChangeClassButton";
            this.ChangeClassButton.Size = new System.Drawing.Size(122, 23);
            this.ChangeClassButton.TabIndex = 6;
            this.ChangeClassButton.Text = "Change";
            this.ChangeClassButton.UseVisualStyleBackColor = true;
            this.ChangeClassButton.Click += new System.EventHandler(this.ChangeClassButton_Click);
            // 
            // DeleteClassButton
            // 
            this.DeleteClassButton.Location = new System.Drawing.Point(6, 236);
            this.DeleteClassButton.Name = "DeleteClassButton";
            this.DeleteClassButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteClassButton.TabIndex = 7;
            this.DeleteClassButton.Text = "Delete";
            this.DeleteClassButton.UseVisualStyleBackColor = true;
            this.DeleteClassButton.Click += new System.EventHandler(this.DeleteClassButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(72, 273);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.ClassNameTextBox.TabIndex = 9;
            // 
            // changeClassString
            // 
            this.changeClassString.Location = new System.Drawing.Point(72, 299);
            this.changeClassString.Name = "changeClassString";
            this.changeClassString.Size = new System.Drawing.Size(179, 20);
            this.changeClassString.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.transactionStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox charBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button charGetList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox charDetail;
        private System.Windows.Forms.Button charGetDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classDetail;
        private System.Windows.Forms.Button classGetDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox classBox;
        private System.Windows.Forms.Button classGetList;
        private System.Windows.Forms.Button getLongText;
        private System.Windows.Forms.Button setLongText;
        private System.Windows.Forms.TextBox setLongTextString;
        private System.Windows.Forms.TextBox getLongTextString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transactionStatus;
        private System.Windows.Forms.Button removeLongText;
        private System.Windows.Forms.Button DeleteCharButton;
        private System.Windows.Forms.Button CreateCharButton;
        private System.Windows.Forms.TextBox CharNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClassNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteClassButton;
        private System.Windows.Forms.Button ChangeClassButton;
        private System.Windows.Forms.Button CreateClassButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox changeClassString;
    }
}

