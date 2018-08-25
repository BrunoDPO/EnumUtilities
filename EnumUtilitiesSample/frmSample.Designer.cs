namespace EnumUtilitiesSample
{
    partial class frmSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEnum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToString = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCastByte = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items populated:";
            // 
            // cbxEnum
            // 
            this.cbxEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnum.FormattingEnabled = true;
            this.cbxEnum.Location = new System.Drawing.Point(126, 12);
            this.cbxEnum.Name = "cbxEnum";
            this.cbxEnum.Size = new System.Drawing.Size(121, 21);
            this.cbxEnum.TabIndex = 1;
            this.cbxEnum.SelectedIndexChanged += new System.EventHandler(this.cbxEnum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SelectedItem.Key:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(132, 23);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(96, 13);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "[SelectedItem.Key]";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(132, 57);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(105, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "[SelectedItem.Value]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SelectedItem.Value:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(132, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "[Description()]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description():";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SelectedItem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCastByte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblToString);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "enum Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ToString():";
            // 
            // lblToString
            // 
            this.lblToString.AutoSize = true;
            this.lblToString.Location = new System.Drawing.Point(132, 56);
            this.lblToString.Name = "lblToString";
            this.lblToString.Size = new System.Drawing.Size(59, 13);
            this.lblToString.TabIndex = 9;
            this.lblToString.Text = "[ToString()]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cast to byte:";
            // 
            // lblCastByte
            // 
            this.lblCastByte.AutoSize = true;
            this.lblCastByte.Location = new System.Drawing.Point(132, 87);
            this.lblCastByte.Name = "lblCastByte";
            this.lblCastByte.Size = new System.Drawing.Size(69, 13);
            this.lblCastByte.TabIndex = 11;
            this.lblCastByte.Text = "[Cast to byte]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxEnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EnumUtilities Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCastByte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToString;
    }
}

