namespace Burger_shop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblCopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcome.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.White;
            this.LblWelcome.Location = new System.Drawing.Point(54, 42);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(577, 52);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welcome To HaMbuRger";
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(10)))));
            this.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnter.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(106, 153);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(197, 45);
            this.BtnEnter.TabIndex = 1;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblCopyRight
            // 
            this.LblCopyRight.AutoSize = true;
            this.LblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.LblCopyRight.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCopyRight.ForeColor = System.Drawing.Color.White;
            this.LblCopyRight.Location = new System.Drawing.Point(21, 555);
            this.LblCopyRight.Name = "LblCopyRight";
            this.LblCopyRight.Size = new System.Drawing.Size(343, 23);
            this.LblCopyRight.TabIndex = 2;
            this.LblCopyRight.Text = "© Moriel Genish And Reut Tamam";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1073, 611);
            this.Controls.Add(this.LblCopyRight);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HaMbuRger Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LblCopyRight;
    }
}