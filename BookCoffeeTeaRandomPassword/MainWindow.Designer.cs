namespace BookCoffeeTeaRandomPassword
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblNowDate = new System.Windows.Forms.Label();
            this.btnModifyRouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPassword.BackColor = System.Drawing.Color.Silver;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.Maroon;
            this.tbxPassword.Location = new System.Drawing.Point(29, 42);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(391, 79);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.Text = "PASSWORD";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNowDate
            // 
            this.lblNowDate.AutoSize = true;
            this.lblNowDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowDate.ForeColor = System.Drawing.Color.Olive;
            this.lblNowDate.Location = new System.Drawing.Point(12, 9);
            this.lblNowDate.Name = "lblNowDate";
            this.lblNowDate.Size = new System.Drawing.Size(35, 15);
            this.lblNowDate.TabIndex = 2;
            this.lblNowDate.Text = "Date:";
            // 
            // btnModifyRouter
            // 
            this.btnModifyRouter.Location = new System.Drawing.Point(130, 5);
            this.btnModifyRouter.Name = "btnModifyRouter";
            this.btnModifyRouter.Size = new System.Drawing.Size(75, 23);
            this.btnModifyRouter.TabIndex = 3;
            this.btnModifyRouter.Text = "Go";
            this.btnModifyRouter.UseVisualStyleBackColor = true;
            this.btnModifyRouter.Click += new System.EventHandler(this.btnModifyRouter_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(449, 133);
            this.Controls.Add(this.btnModifyRouter);
            this.Controls.Add(this.lblNowDate);
            this.Controls.Add(this.tbxPassword);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Random Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblNowDate;
        private System.Windows.Forms.Button btnModifyRouter;
    }
}

