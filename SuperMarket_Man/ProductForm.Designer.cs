namespace SuperMarket_Man
{
    partial class ProductForm
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
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.ProdDeleteBTN = new System.Windows.Forms.Button();
            this.ProdEditBTN = new System.Windows.Forms.Button();
            this.ProAddBTN = new System.Windows.Forms.Button();
            this.ProCatCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdPricTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdQuaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdIdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProCatBTN = new System.Windows.Forms.Button();
            this.ProductFormExit = new System.Windows.Forms.Button();
            this.PrologoutLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.ProdDeleteBTN);
            this.panel1.Controls.Add(this.ProdEditBTN);
            this.panel1.Controls.Add(this.ProAddBTN);
            this.panel1.Controls.Add(this.ProCatCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdPricTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdQuaTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdNameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProdIdTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(133, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 609);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(642, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 41);
            this.button8.TabIndex = 18;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.comboBox2.Location = new System.Drawing.Point(465, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 27);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ProdDGV
            // 
            this.ProdDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(465, 158);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 51;
            this.ProdDGV.RowTemplate.Height = 24;
            this.ProdDGV.Size = new System.Drawing.Size(642, 426);
            this.ProdDGV.TabIndex = 16;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // ProdDeleteBTN
            // 
            this.ProdDeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProdDeleteBTN.FlatAppearance.BorderSize = 0;
            this.ProdDeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdDeleteBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDeleteBTN.ForeColor = System.Drawing.Color.White;
            this.ProdDeleteBTN.Location = new System.Drawing.Point(294, 432);
            this.ProdDeleteBTN.Name = "ProdDeleteBTN";
            this.ProdDeleteBTN.Size = new System.Drawing.Size(106, 41);
            this.ProdDeleteBTN.TabIndex = 15;
            this.ProdDeleteBTN.Text = "DELETE";
            this.ProdDeleteBTN.UseVisualStyleBackColor = false;
            this.ProdDeleteBTN.Click += new System.EventHandler(this.ProdDeleteBTN_Click);
            // 
            // ProdEditBTN
            // 
            this.ProdEditBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProdEditBTN.FlatAppearance.BorderSize = 0;
            this.ProdEditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdEditBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdEditBTN.ForeColor = System.Drawing.Color.White;
            this.ProdEditBTN.Location = new System.Drawing.Point(166, 432);
            this.ProdEditBTN.Name = "ProdEditBTN";
            this.ProdEditBTN.Size = new System.Drawing.Size(106, 41);
            this.ProdEditBTN.TabIndex = 14;
            this.ProdEditBTN.Text = "EDIT";
            this.ProdEditBTN.UseVisualStyleBackColor = false;
            this.ProdEditBTN.Click += new System.EventHandler(this.ProdEditBTN_Click);
            // 
            // ProAddBTN
            // 
            this.ProAddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProAddBTN.FlatAppearance.BorderSize = 0;
            this.ProAddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProAddBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProAddBTN.ForeColor = System.Drawing.Color.White;
            this.ProAddBTN.Location = new System.Drawing.Point(54, 432);
            this.ProAddBTN.Name = "ProAddBTN";
            this.ProAddBTN.Size = new System.Drawing.Size(106, 41);
            this.ProAddBTN.TabIndex = 4;
            this.ProAddBTN.Text = "ADD";
            this.ProAddBTN.UseVisualStyleBackColor = false;
            this.ProAddBTN.Click += new System.EventHandler(this.ProAddBTN_Click);
            // 
            // ProCatCB
            // 
            this.ProCatCB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProCatCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProCatCB.FormattingEnabled = true;
            this.ProCatCB.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.ProCatCB.Location = new System.Drawing.Point(196, 337);
            this.ProCatCB.Name = "ProCatCB";
            this.ProCatCB.Size = new System.Drawing.Size(171, 27);
            this.ProCatCB.TabIndex = 13;
            this.ProCatCB.Text = "Select Category";
            this.ProCatCB.SelectedIndexChanged += new System.EventHandler(this.ProCatCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "CATEGORY";
            // 
            // ProdPricTxt
            // 
            this.ProdPricTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPricTxt.Location = new System.Drawing.Point(196, 278);
            this.ProdPricTxt.Name = "ProdPricTxt";
            this.ProdPricTxt.Size = new System.Drawing.Size(153, 26);
            this.ProdPricTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "PRICE";
            // 
            // ProdQuaTxt
            // 
            this.ProdQuaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQuaTxt.Location = new System.Drawing.Point(196, 225);
            this.ProdQuaTxt.Name = "ProdQuaTxt";
            this.ProdQuaTxt.Size = new System.Drawing.Size(153, 26);
            this.ProdQuaTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUANTITY";
            // 
            // ProdNameTxt
            // 
            this.ProdNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTxt.Location = new System.Drawing.Point(196, 179);
            this.ProdNameTxt.Name = "ProdNameTxt";
            this.ProdNameTxt.Size = new System.Drawing.Size(153, 26);
            this.ProdNameTxt.TabIndex = 7;
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
            // ProdIdTXT
            // 
            this.ProdIdTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdTXT.Location = new System.Drawing.Point(196, 126);
            this.ProdIdTXT.Name = "ProdIdTXT";
            this.ProdIdTXT.Size = new System.Drawing.Size(153, 26);
            this.ProdIdTXT.TabIndex = 5;
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
            this.button4.Text = "MANAGE PRODUCTS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProCatBTN
            // 
            this.ProCatBTN.FlatAppearance.BorderSize = 0;
            this.ProCatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProCatBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProCatBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProCatBTN.Location = new System.Drawing.Point(-1, 104);
            this.ProCatBTN.Name = "ProCatBTN";
            this.ProCatBTN.Size = new System.Drawing.Size(128, 49);
            this.ProCatBTN.TabIndex = 1;
            this.ProCatBTN.Text = "Cateorie";
            this.ProCatBTN.UseVisualStyleBackColor = true;
            this.ProCatBTN.Click += new System.EventHandler(this.ProCatBTN_Click);
            // 
            // ProductFormExit
            // 
            this.ProductFormExit.FlatAppearance.BorderSize = 0;
            this.ProductFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductFormExit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductFormExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductFormExit.Location = new System.Drawing.Point(1228, 0);
            this.ProductFormExit.Name = "ProductFormExit";
            this.ProductFormExit.Size = new System.Drawing.Size(47, 35);
            this.ProductFormExit.TabIndex = 3;
            this.ProductFormExit.Text = "x";
            this.ProductFormExit.UseVisualStyleBackColor = true;
            this.ProductFormExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // PrologoutLbl
            // 
            this.PrologoutLbl.AutoSize = true;
            this.PrologoutLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrologoutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PrologoutLbl.Location = new System.Drawing.Point(34, 603);
            this.PrologoutLbl.Name = "PrologoutLbl";
            this.PrologoutLbl.Size = new System.Drawing.Size(84, 25);
            this.PrologoutLbl.TabIndex = 31;
            this.PrologoutLbl.Text = "Logout";
            this.PrologoutLbl.Click += new System.EventHandler(this.PrologoutLbl_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 656);
            this.Controls.Add(this.PrologoutLbl);
            this.Controls.Add(this.ProductFormExit);
            this.Controls.Add(this.ProCatBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProCatBTN;
        private System.Windows.Forms.Button ProductFormExit;
        private System.Windows.Forms.TextBox ProdIdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdQuaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdPricTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.Button ProdDeleteBTN;
        private System.Windows.Forms.Button ProdEditBTN;
        private System.Windows.Forms.Button ProAddBTN;
        private System.Windows.Forms.ComboBox ProCatCB;
        private System.Windows.Forms.Label PrologoutLbl;
    }
}