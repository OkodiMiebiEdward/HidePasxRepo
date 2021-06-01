namespace HidePassUI
{
    partial class HidePasx
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HidePasx));
            this.panel1 = new System.Windows.Forms.Panel();
            this.createDecryptionPasswordButton = new System.Windows.Forms.Button();
            this.savePasswordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.encryptPasswordButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.encryptedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.DecryptionPasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.decryptionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.createDecryptionPasswordButton);
            this.panel1.Controls.Add(this.savePasswordButton);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 469);
            this.panel1.TabIndex = 0;
            // 
            // createDecryptionPasswordButton
            // 
            this.createDecryptionPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createDecryptionPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDecryptionPasswordButton.ForeColor = System.Drawing.Color.Black;
            this.createDecryptionPasswordButton.Location = new System.Drawing.Point(21, 34);
            this.createDecryptionPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createDecryptionPasswordButton.Name = "createDecryptionPasswordButton";
            this.createDecryptionPasswordButton.Size = new System.Drawing.Size(148, 36);
            this.createDecryptionPasswordButton.TabIndex = 0;
            this.createDecryptionPasswordButton.Text = "CREATE DECRYPTION PASSWORD";
            this.createDecryptionPasswordButton.UseVisualStyleBackColor = true;
            this.createDecryptionPasswordButton.Click += new System.EventHandler(this.createDecryptionPasswordButton_Click);
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePasswordButton.Location = new System.Drawing.Point(21, 112);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(148, 45);
            this.savePasswordButton.TabIndex = 3;
            this.savePasswordButton.Text = "Save Encrypted Password";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            this.savePasswordButton.Click += new System.EventHandler(this.savePasswordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = " Enter Password :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(560, 31);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(177, 22);
            this.passwordTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.passwordTextBox, "Enter password to be encrypted here");
            // 
            // encryptPasswordButton
            // 
            this.encryptPasswordButton.Location = new System.Drawing.Point(339, 99);
            this.encryptPasswordButton.Name = "encryptPasswordButton";
            this.encryptPasswordButton.Size = new System.Drawing.Size(156, 36);
            this.encryptPasswordButton.TabIndex = 3;
            this.encryptPasswordButton.Text = "Encrypt Password";
            this.encryptPasswordButton.UseVisualStyleBackColor = true;
            this.encryptPasswordButton.Click += new System.EventHandler(this.encryptPasswordButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(560, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 2;
            // 
            // encryptedPasswordTextBox
            // 
            this.encryptedPasswordTextBox.Location = new System.Drawing.Point(560, 113);
            this.encryptedPasswordTextBox.Name = "encryptedPasswordTextBox";
            this.encryptedPasswordTextBox.Size = new System.Drawing.Size(177, 22);
            this.encryptedPasswordTextBox.TabIndex = 2;
            // 
            // DecryptionPasswordButton
            // 
            this.DecryptionPasswordButton.Location = new System.Drawing.Point(338, 202);
            this.DecryptionPasswordButton.Name = "DecryptionPasswordButton";
            this.DecryptionPasswordButton.Size = new System.Drawing.Size(156, 45);
            this.DecryptionPasswordButton.TabIndex = 3;
            this.DecryptionPasswordButton.Text = " Decrypt Password";
            this.DecryptionPasswordButton.UseVisualStyleBackColor = true;
            this.DecryptionPasswordButton.Click += new System.EventHandler(this.DecryptionPasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = " Enter Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = " Decrypted  Password :";
            // 
            // decryptedPasswordTextBox
            // 
            this.decryptedPasswordTextBox.Location = new System.Drawing.Point(560, 298);
            this.decryptedPasswordTextBox.Name = "decryptedPasswordTextBox";
            this.decryptedPasswordTextBox.Size = new System.Drawing.Size(177, 22);
            this.decryptedPasswordTextBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // decryptionPasswordTextBox
            // 
            this.decryptionPasswordTextBox.Location = new System.Drawing.Point(560, 213);
            this.decryptionPasswordTextBox.Name = "decryptionPasswordTextBox";
            this.decryptionPasswordTextBox.Size = new System.Drawing.Size(177, 22);
            this.decryptionPasswordTextBox.TabIndex = 4;
            this.decryptionPasswordTextBox.TextChanged += new System.EventHandler(this.decryptionPasswordTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(339, 374);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // HidePasx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(753, 469);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decryptionPasswordTextBox);
            this.Controls.Add(this.DecryptionPasswordButton);
            this.Controls.Add(this.decryptedPasswordTextBox);
            this.Controls.Add(this.encryptedPasswordTextBox);
            this.Controls.Add(this.encryptPasswordButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HidePasx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                HIDE PASx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createDecryptionPasswordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button encryptPasswordButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button savePasswordButton;
        private System.Windows.Forms.TextBox encryptedPasswordTextBox;
        private System.Windows.Forms.Button DecryptionPasswordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptedPasswordTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox decryptionPasswordTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}

