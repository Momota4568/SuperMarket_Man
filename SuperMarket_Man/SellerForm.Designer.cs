namespace SuperMarket_Man
{
    partial class SellerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellerPass = new System.Windows.Forms.TextBox();
            this.SellerDGV = new System.Windows.Forms.DataGridView();
            this.sellerDeleteBTN = new System.Windows.Forms.Button();
            this.SellerEditBTN = new System.Windows.Forms.Button();
            this.SellerAddBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sellerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellerAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ProductFormExit = new System.Windows.Forms.Button();
            this.CatBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MSlogoutLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.sellerPass);
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.sellerDeleteBTN);
            this.panel1.Controls.Add(this.SellerEditBTN);
            this.panel1.Controls.Add(this.SellerAddBTN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sellerPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sellerAge);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sellerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sellerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(142, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 609);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sellerPass
            // 
            this.sellerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerPass.Location = new System.Drawing.Point(188, 335);
            this.sellerPass.Name = "sellerPass";
            this.sellerPass.Size = new System.Drawing.Size(161, 26);
            this.sellerPass.TabIndex = 19;
            // 
            // SellerDGV
            // 
            this.SellerDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerDGV.Location = new System.Drawing.Point(562, 165);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersWidth = 51;
            this.SellerDGV.RowTemplate.Height = 24;
            this.SellerDGV.Size = new System.Drawing.Size(537, 426);
            this.SellerDGV.TabIndex = 16;
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // sellerDeleteBTN
            // 
            this.sellerDeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sellerDeleteBTN.FlatAppearance.BorderSize = 0;
            this.sellerDeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellerDeleteBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerDeleteBTN.ForeColor = System.Drawing.Color.White;
            this.sellerDeleteBTN.Location = new System.Drawing.Point(294, 432);
            this.sellerDeleteBTN.Name = "sellerDeleteBTN";
            this.sellerDeleteBTN.Size = new System.Drawing.Size(106, 41);
            this.sellerDeleteBTN.TabIndex = 15;
            this.sellerDeleteBTN.Text = "DELETE";
            this.sellerDeleteBTN.UseVisualStyleBackColor = false;
            this.sellerDeleteBTN.Click += new System.EventHandler(this.sellerDeleteBTN_Click);
            // 
            // SellerEditBTN
            // 
            this.SellerEditBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellerEditBTN.FlatAppearance.BorderSize = 0;
            this.SellerEditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerEditBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerEditBTN.ForeColor = System.Drawing.Color.White;
            this.SellerEditBTN.Location = new System.Drawing.Point(166, 432);
            this.SellerEditBTN.Name = "SellerEditBTN";
            this.SellerEditBTN.Size = new System.Drawing.Size(106, 41);
            this.SellerEditBTN.TabIndex = 14;
            this.SellerEditBTN.Text = "EDIT";
            this.SellerEditBTN.UseVisualStyleBackColor = false;
            this.SellerEditBTN.Click += new System.EventHandler(this.SellerEditBTN_Click);
            // 
            // SellerAddBTN
            // 
            this.SellerAddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SellerAddBTN.FlatAppearance.BorderSize = 0;
            this.SellerAddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerAddBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAddBTN.ForeColor = System.Drawing.Color.White;
            this.SellerAddBTN.Location = new System.Drawing.Point(54, 432);
            this.SellerAddBTN.Name = "SellerAddBTN";
            this.SellerAddBTN.Size = new System.Drawing.Size(106, 41);
            this.SellerAddBTN.TabIndex = 4;
            this.SellerAddBTN.Text = "ADD";
            this.SellerAddBTN.UseVisualStyleBackColor = false;
            this.SellerAddBTN.Click += new System.EventHandler(this.SellerAddBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "PASSWORD";
            // 
            // sellerPhone
            // 
            this.sellerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerPhone.Location = new System.Drawing.Point(196, 278);
            this.sellerPhone.Name = "sellerPhone";
            this.sellerPhone.Size = new System.Drawing.Size(153, 26);
            this.sellerPhone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "PHONE";
            // 
            // sellerAge
            // 
            this.sellerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerAge.Location = new System.Drawing.Point(196, 225);
            this.sellerAge.Name = "sellerAge";
            this.sellerAge.Size = new System.Drawing.Size(153, 26);
            this.sellerAge.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "AGE";
            // 
            // sellerName
            // 
            this.sellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerName.Location = new System.Drawing.Point(196, 179);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(153, 26);
            this.sellerName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAME";
            // 
            // sellerId
            // 
            this.sellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerId.Location = new System.Drawing.Point(196, 126);
            this.sellerId.Name = "sellerId";
            this.sellerId.Size = new System.Drawing.Size(153, 26);
            this.sellerId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(340, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(388, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "MANAGE SELLERS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ProductFormExit
            // 
            this.ProductFormExit.FlatAppearance.BorderSize = 0;
            this.ProductFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductFormExit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductFormExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductFormExit.Location = new System.Drawing.Point(1212, 0);
            this.ProductFormExit.Name = "ProductFormExit";
            this.ProductFormExit.Size = new System.Drawing.Size(47, 50);
            this.ProductFormExit.TabIndex = 19;
            this.ProductFormExit.Text = "x";
            this.ProductFormExit.UseVisualStyleBackColor = true;
            this.ProductFormExit.Click += new System.EventHandler(this.ProductFormExit_Click);
            // 
            // CatBTN
            // 
            this.CatBTN.FlatAppearance.BorderSize = 0;
            this.CatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatBTN.Location = new System.Drawing.Point(17, 90);
            this.CatBTN.Name = "CatBTN";
            this.CatBTN.Size = new System.Drawing.Size(128, 49);
            this.CatBTN.TabIndex = 21;
            this.CatBTN.Text = "Cateories";
            this.CatBTN.UseVisualStyleBackColor = true;
            this.CatBTN.Click += new System.EventHandler(this.CatBTN_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(30, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MSlogoutLbl
            // 
            this.MSlogoutLbl.AutoSize = true;
            this.MSlogoutLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSlogoutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MSlogoutLbl.Location = new System.Drawing.Point(39, 612);
            this.MSlogoutLbl.Name = "MSlogoutLbl";
            this.MSlogoutLbl.Size = new System.Drawing.Size(84, 25);
            this.MSlogoutLbl.TabIndex = 33;
            this.MSlogoutLbl.Text = "Logout";
            this.MSlogoutLbl.Click += new System.EventHandler(this.MSlogoutLbl_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 658);
            this.Controls.Add(this.MSlogoutLbl);
            this.Controls.Add(this.CatBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductFormExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SellerDGV;
        private System.Windows.Forms.Button sellerDeleteBTN;
        private System.Windows.Forms.Button SellerEditBTN;
        private System.Windows.Forms.Button SellerAddBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sellerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sellerAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sellerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ProductFormExit;
        private System.Windows.Forms.Button CatBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sellerPass;
        private System.Windows.Forms.Label MSlogoutLbl;
    }
}