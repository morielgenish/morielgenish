namespace Burger_shop
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.GrpPayment = new System.Windows.Forms.GroupBox();
            this.BtnFinalOrder = new System.Windows.Forms.Button();
            this.CmbCardType = new System.Windows.Forms.ComboBox();
            this.TxtCardNumber = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.LblCardNumber = new System.Windows.Forms.Label();
            this.LblCardType = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblFName = new System.Windows.Forms.Label();
            this.GrpDisplayOrder = new System.Windows.Forms.GroupBox();
            this.BtnBackToChange = new System.Windows.Forms.Button();
            this.LstDisplayPrice = new System.Windows.Forms.ListBox();
            this.LstDisplayOrder = new System.Windows.Forms.ListBox();
            this.BtnGoPay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GrpPayment.SuspendLayout();
            this.GrpDisplayOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpPayment
            // 
            this.GrpPayment.BackColor = System.Drawing.Color.Transparent;
            this.GrpPayment.Controls.Add(this.BtnFinalOrder);
            this.GrpPayment.Controls.Add(this.CmbCardType);
            this.GrpPayment.Controls.Add(this.TxtCardNumber);
            this.GrpPayment.Controls.Add(this.TxtID);
            this.GrpPayment.Controls.Add(this.TxtAddress);
            this.GrpPayment.Controls.Add(this.TxtLName);
            this.GrpPayment.Controls.Add(this.TxtFName);
            this.GrpPayment.Controls.Add(this.LblCardNumber);
            this.GrpPayment.Controls.Add(this.LblCardType);
            this.GrpPayment.Controls.Add(this.LblID);
            this.GrpPayment.Controls.Add(this.LblAddress);
            this.GrpPayment.Controls.Add(this.LblLName);
            this.GrpPayment.Controls.Add(this.LblFName);
            this.GrpPayment.Location = new System.Drawing.Point(641, 26);
            this.GrpPayment.Name = "GrpPayment";
            this.GrpPayment.Size = new System.Drawing.Size(477, 561);
            this.GrpPayment.TabIndex = 0;
            this.GrpPayment.TabStop = false;
            // 
            // BtnFinalOrder
            // 
            this.BtnFinalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.BtnFinalOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinalOrder.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalOrder.ForeColor = System.Drawing.Color.White;
            this.BtnFinalOrder.Location = new System.Drawing.Point(303, 475);
            this.BtnFinalOrder.Name = "BtnFinalOrder";
            this.BtnFinalOrder.Size = new System.Drawing.Size(153, 50);
            this.BtnFinalOrder.TabIndex = 12;
            this.BtnFinalOrder.Text = "Order";
            this.BtnFinalOrder.UseVisualStyleBackColor = false;
            this.BtnFinalOrder.Click += new System.EventHandler(this.BtnFinalOrder_Click);
            // 
            // CmbCardType
            // 
            this.CmbCardType.FormattingEnabled = true;
            this.CmbCardType.Items.AddRange(new object[] {
            "Visa",
            "Master Card",
            "American Express"});
            this.CmbCardType.Location = new System.Drawing.Point(306, 300);
            this.CmbCardType.Name = "CmbCardType";
            this.CmbCardType.Size = new System.Drawing.Size(150, 28);
            this.CmbCardType.TabIndex = 11;
            // 
            // TxtCardNumber
            // 
            this.TxtCardNumber.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCardNumber.Location = new System.Drawing.Point(303, 366);
            this.TxtCardNumber.Multiline = true;
            this.TxtCardNumber.Name = "TxtCardNumber";
            this.TxtCardNumber.Size = new System.Drawing.Size(150, 30);
            this.TxtCardNumber.TabIndex = 10;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(306, 230);
            this.TxtID.Multiline = true;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(150, 30);
            this.TxtID.TabIndex = 9;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(306, 163);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(150, 30);
            this.TxtAddress.TabIndex = 8;
            // 
            // TxtLName
            // 
            this.TxtLName.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLName.Location = new System.Drawing.Point(306, 95);
            this.TxtLName.Multiline = true;
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(150, 30);
            this.TxtLName.TabIndex = 7;
            // 
            // TxtFName
            // 
            this.TxtFName.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFName.Location = new System.Drawing.Point(306, 26);
            this.TxtFName.Multiline = true;
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(150, 30);
            this.TxtFName.TabIndex = 6;
            // 
            // LblCardNumber
            // 
            this.LblCardNumber.AutoSize = true;
            this.LblCardNumber.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardNumber.ForeColor = System.Drawing.Color.White;
            this.LblCardNumber.Location = new System.Drawing.Point(20, 368);
            this.LblCardNumber.Name = "LblCardNumber";
            this.LblCardNumber.Size = new System.Drawing.Size(258, 21);
            this.LblCardNumber.TabIndex = 5;
            this.LblCardNumber.Text = "Enter Credit Card Number:";
            // 
            // LblCardType
            // 
            this.LblCardType.AutoSize = true;
            this.LblCardType.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardType.ForeColor = System.Drawing.Color.White;
            this.LblCardType.Location = new System.Drawing.Point(20, 300);
            this.LblCardType.Name = "LblCardType";
            this.LblCardType.Size = new System.Drawing.Size(232, 21);
            this.LblCardType.TabIndex = 4;
            this.LblCardType.Text = "Choose Your Card Type:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(20, 239);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(95, 21);
            this.LblID.TabIndex = 3;
            this.LblID.Text = "Enter ID:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.ForeColor = System.Drawing.Color.White;
            this.LblAddress.Location = new System.Drawing.Point(20, 163);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(147, 21);
            this.LblAddress.TabIndex = 2;
            this.LblAddress.Text = "Enter Address:";
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLName.ForeColor = System.Drawing.Color.White;
            this.LblLName.Location = new System.Drawing.Point(20, 95);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(170, 21);
            this.LblLName.TabIndex = 1;
            this.LblLName.Text = "Enter Last Name:";
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFName.ForeColor = System.Drawing.Color.White;
            this.LblFName.Location = new System.Drawing.Point(20, 28);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(174, 21);
            this.LblFName.TabIndex = 0;
            this.LblFName.Text = "Enter First Name:";
            // 
            // GrpDisplayOrder
            // 
            this.GrpDisplayOrder.BackColor = System.Drawing.Color.Transparent;
            this.GrpDisplayOrder.Controls.Add(this.BtnBackToChange);
            this.GrpDisplayOrder.Controls.Add(this.LstDisplayPrice);
            this.GrpDisplayOrder.Controls.Add(this.LstDisplayOrder);
            this.GrpDisplayOrder.Controls.Add(this.BtnGoPay);
            this.GrpDisplayOrder.Location = new System.Drawing.Point(33, 26);
            this.GrpDisplayOrder.Name = "GrpDisplayOrder";
            this.GrpDisplayOrder.Size = new System.Drawing.Size(545, 561);
            this.GrpDisplayOrder.TabIndex = 1;
            this.GrpDisplayOrder.TabStop = false;
            // 
            // BtnBackToChange
            // 
            this.BtnBackToChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnBackToChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackToChange.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackToChange.ForeColor = System.Drawing.Color.White;
            this.BtnBackToChange.Location = new System.Drawing.Point(30, 490);
            this.BtnBackToChange.Name = "BtnBackToChange";
            this.BtnBackToChange.Size = new System.Drawing.Size(275, 48);
            this.BtnBackToChange.TabIndex = 3;
            this.BtnBackToChange.Text = "Back To Make Changes";
            this.BtnBackToChange.UseVisualStyleBackColor = false;
            this.BtnBackToChange.Click += new System.EventHandler(this.BtnBackToChange_Click);
            // 
            // LstDisplayPrice
            // 
            this.LstDisplayPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.LstDisplayPrice.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDisplayPrice.ForeColor = System.Drawing.Color.White;
            this.LstDisplayPrice.FormattingEnabled = true;
            this.LstDisplayPrice.ItemHeight = 24;
            this.LstDisplayPrice.Location = new System.Drawing.Point(6, 330);
            this.LstDisplayPrice.Name = "LstDisplayPrice";
            this.LstDisplayPrice.Size = new System.Drawing.Size(533, 124);
            this.LstDisplayPrice.TabIndex = 2;
            // 
            // LstDisplayOrder
            // 
            this.LstDisplayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.LstDisplayOrder.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDisplayOrder.ForeColor = System.Drawing.Color.White;
            this.LstDisplayOrder.FormattingEnabled = true;
            this.LstDisplayOrder.ItemHeight = 21;
            this.LstDisplayOrder.Location = new System.Drawing.Point(6, 11);
            this.LstDisplayOrder.Name = "LstDisplayOrder";
            this.LstDisplayOrder.Size = new System.Drawing.Size(533, 298);
            this.LstDisplayOrder.TabIndex = 1;
            // 
            // BtnGoPay
            // 
            this.BtnGoPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnGoPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoPay.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoPay.ForeColor = System.Drawing.Color.White;
            this.BtnGoPay.Location = new System.Drawing.Point(349, 490);
            this.BtnGoPay.Name = "BtnGoPay";
            this.BtnGoPay.Size = new System.Drawing.Size(170, 48);
            this.BtnGoPay.TabIndex = 0;
            this.BtnGoPay.Text = "Payment";
            this.BtnGoPay.UseVisualStyleBackColor = false;
            this.BtnGoPay.Click += new System.EventHandler(this.BtnGoPay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1166, 624);
            this.Controls.Add(this.GrpDisplayOrder);
            this.Controls.Add(this.GrpPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPayment";
            this.Text = "Payment";
            this.GrpPayment.ResumeLayout(false);
            this.GrpPayment.PerformLayout();
            this.GrpDisplayOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPayment;
        private System.Windows.Forms.GroupBox GrpDisplayOrder;
        private System.Windows.Forms.Button BtnGoPay;
        private System.Windows.Forms.ListBox LstDisplayOrder;
        private System.Windows.Forms.Label LblCardNumber;
        private System.Windows.Forms.Label LblCardType;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.ComboBox CmbCardType;
        private System.Windows.Forms.TextBox TxtCardNumber;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.ListBox LstDisplayPrice;
        private System.Windows.Forms.Button BtnBackToChange;
        private System.Windows.Forms.Button BtnFinalOrder;
        private System.Windows.Forms.Timer timer1;
    }
}