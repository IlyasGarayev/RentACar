namespace RentACar.UserControls.LoginSignUp
{
    partial class ResetPasswordUC
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
            this.lblPass1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoginPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPass1
            // 
            this.lblPass1.AutoSize = true;
            this.lblPass1.Location = new System.Drawing.Point(57, 61);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(104, 16);
            this.lblPass1.TabIndex = 0;
            this.lblPass1.Text = "Şifrəni daxil edin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifrəni yenidən daxil edin";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(60, 165);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(215, 22);
            this.txtPass2.TabIndex = 2;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(60, 90);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(215, 22);
            this.txtPass1.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(116, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Təsdiqlə";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnLoginPage
            // 
            this.btnLoginPage.Location = new System.Drawing.Point(91, 246);
            this.btnLoginPage.Name = "btnLoginPage";
            this.btnLoginPage.Size = new System.Drawing.Size(136, 31);
            this.btnLoginPage.TabIndex = 5;
            this.btnLoginPage.Text = "Hesaba gitiş et";
            this.btnLoginPage.UseVisualStyleBackColor = true;
            this.btnLoginPage.Click += new System.EventHandler(this.btnLoginPage_Click);
            // 
            // ResetPasswordUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoginPage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPass1);
            this.Name = "ResetPasswordUC";
            this.Size = new System.Drawing.Size(348, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoginPage;
    }
}
