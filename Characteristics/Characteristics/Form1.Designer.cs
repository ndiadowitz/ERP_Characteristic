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
            this.charDetail = new System.Windows.Forms.TextBox();
            this.charGetDetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classDetail = new System.Windows.Forms.TextBox();
            this.classGetDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ListBox();
            this.classGetList = new System.Windows.Forms.Button();
            this.getLongText = new System.Windows.Forms.Button();
            this.getLongTextString = new System.Windows.Forms.TextBox();
            this.setLongTextString = new System.Windows.Forms.TextBox();
            this.setLongText = new System.Windows.Forms.Button();
            this.removeLongText = new System.Windows.Forms.Button();
            this.transactionStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.charGetList.Location = new System.Drawing.Point(6, 19);
            this.charGetList.Name = "charGetList";
            this.charGetList.Size = new System.Drawing.Size(122, 23);
            this.charGetList.TabIndex = 2;
            this.charGetList.Text = "List elements";
            this.charGetList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(385, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characteristic";
            // 
            // charDetail
            // 
            this.charDetail.Location = new System.Drawing.Point(6, 81);
            this.charDetail.Multiline = true;
            this.charDetail.Name = "charDetail";
            this.charDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.charDetail.Size = new System.Drawing.Size(122, 150);
            this.charDetail.TabIndex = 4;
            // 
            // charGetDetail
            // 
            this.charGetDetail.Location = new System.Drawing.Point(6, 52);
            this.charGetDetail.Name = "charGetDetail";
            this.charGetDetail.Size = new System.Drawing.Size(122, 23);
            this.charGetDetail.TabIndex = 3;
            this.charGetDetail.Text = "Get Detail ";
            this.charGetDetail.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            // 
            // classGetDetail
            // 
            this.classGetDetail.Location = new System.Drawing.Point(6, 52);
            this.classGetDetail.Name = "classGetDetail";
            this.classGetDetail.Size = new System.Drawing.Size(137, 23);
            this.classGetDetail.TabIndex = 3;
            this.classGetDetail.Text = "Get Detail";
            this.classGetDetail.UseVisualStyleBackColor = true;
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
            // 
            // getLongText
            // 
            this.getLongText.Location = new System.Drawing.Point(6, 237);
            this.getLongText.Name = "getLongText";
            this.getLongText.Size = new System.Drawing.Size(122, 23);
            this.getLongText.TabIndex = 5;
            this.getLongText.Text = "Get Longtext";
            this.getLongText.UseVisualStyleBackColor = true;
            // 
            // getLongTextString
            // 
            this.getLongTextString.Location = new System.Drawing.Point(134, 239);
            this.getLongTextString.Name = "getLongTextString";
            this.getLongTextString.Size = new System.Drawing.Size(245, 20);
            this.getLongTextString.TabIndex = 6;
            // 
            // setLongTextString
            // 
            this.setLongTextString.Location = new System.Drawing.Point(6, 268);
            this.setLongTextString.Name = "setLongTextString";
            this.setLongTextString.Size = new System.Drawing.Size(245, 20);
            this.setLongTextString.TabIndex = 7;
            // 
            // setLongText
            // 
            this.setLongText.Location = new System.Drawing.Point(257, 266);
            this.setLongText.Name = "setLongText";
            this.setLongText.Size = new System.Drawing.Size(122, 23);
            this.setLongText.TabIndex = 8;
            this.setLongText.Text = "Set Longtext";
            this.setLongText.UseVisualStyleBackColor = true;
            // 
            // removeLongText
            // 
            this.removeLongText.Location = new System.Drawing.Point(6, 294);
            this.removeLongText.Name = "removeLongText";
            this.removeLongText.Size = new System.Drawing.Size(373, 23);
            this.removeLongText.TabIndex = 9;
            this.removeLongText.Text = "Remove Longtext";
            this.removeLongText.UseVisualStyleBackColor = true;
            // 
            // transactionStatus
            // 
            this.transactionStatus.Location = new System.Drawing.Point(12, 362);
            this.transactionStatus.Multiline = true;
            this.transactionStatus.Name = "transactionStatus";
            this.transactionStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.transactionStatus.Size = new System.Drawing.Size(776, 76);
            this.transactionStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Transanction status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

