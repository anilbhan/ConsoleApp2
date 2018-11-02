namespace ReflectionExample
{
    partial class Form1
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
            this.txtsysteminfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MethodlistBox = new System.Windows.Forms.ListBox();
            this.ProportieslistBox = new System.Windows.Forms.ListBox();
            this.ConstructorlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtsysteminfo
            // 
            this.txtsysteminfo.AutoSize = true;
            this.txtsysteminfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsysteminfo.Location = new System.Drawing.Point(12, 9);
            this.txtsysteminfo.Name = "txtsysteminfo";
            this.txtsysteminfo.Size = new System.Drawing.Size(234, 24);
            this.txtsysteminfo.TabIndex = 0;
            this.txtsysteminfo.Text = "Input the system Type Infor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Methods List";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(252, 9);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(234, 32);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(509, 9);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(140, 42);
            this.infoButton.TabIndex = 3;
            this.infoButton.Text = "Get The Type Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proporties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Consutrctor";
            // 
            // MethodlistBox
            // 
            this.MethodlistBox.FormattingEnabled = true;
            this.MethodlistBox.Location = new System.Drawing.Point(16, 106);
            this.MethodlistBox.Name = "MethodlistBox";
            this.MethodlistBox.Size = new System.Drawing.Size(141, 303);
            this.MethodlistBox.TabIndex = 4;
            // 
            // ProportieslistBox
            // 
            this.ProportieslistBox.FormattingEnabled = true;
            this.ProportieslistBox.Location = new System.Drawing.Point(281, 106);
            this.ProportieslistBox.Name = "ProportieslistBox";
            this.ProportieslistBox.Size = new System.Drawing.Size(141, 303);
            this.ProportieslistBox.TabIndex = 4;
            // 
            // ConstructorlistBox
            // 
            this.ConstructorlistBox.FormattingEnabled = true;
            this.ConstructorlistBox.Location = new System.Drawing.Point(584, 106);
            this.ConstructorlistBox.Name = "ConstructorlistBox";
            this.ConstructorlistBox.Size = new System.Drawing.Size(141, 303);
            this.ConstructorlistBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 462);
            this.Controls.Add(this.ConstructorlistBox);
            this.Controls.Add(this.ProportieslistBox);
            this.Controls.Add(this.MethodlistBox);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsysteminfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtsysteminfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox MethodlistBox;
        private System.Windows.Forms.ListBox ProportieslistBox;
        private System.Windows.Forms.ListBox ConstructorlistBox;
    }
}

