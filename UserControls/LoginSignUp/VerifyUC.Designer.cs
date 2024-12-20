namespace RentACar.UserControls.LoginSignUp
{
    partial class VerifyUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnResentCode = new System.Windows.Forms.Button();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.Location = new System.Drawing.Point(81, 54);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(98, 16);
            this.lblVerificationCode.TabIndex = 0;
            this.lblVerificationCode.Text = "Kodu daxil edin";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(84, 140);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(166, 35);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Təsdiq edin";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(84, 221);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(166, 30);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Geri";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnResentCode
            // 
            this.btnResentCode.Location = new System.Drawing.Point(84, 181);
            this.btnResentCode.Name = "btnResentCode";
            this.btnResentCode.Size = new System.Drawing.Size(166, 34);
            this.btnResentCode.TabIndex = 4;
            this.btnResentCode.Text = "Kodu yenidən göndərin";
            this.btnResentCode.UseVisualStyleBackColor = true;
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Location = new System.Drawing.Point(84, 93);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(100, 22);
            this.txtVerificationCode.TabIndex = 5;
            // 
            // VerifyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.btnResentCode);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblVerificationCode);
            this.Name = "VerifyUC";
            this.Size = new System.Drawing.Size(375, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerificationCode;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnResentCode;
        private System.Windows.Forms.TextBox txtVerificationCode;
    }
}
