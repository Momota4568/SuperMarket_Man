namespace SuperMarket_Man
{
    partial class SellingForm
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
            this.SellerNameLbl = new System.Windows.Forms.Label();
            this.AmtLbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.AddProdBTN = new System.Windows.Forms.Button();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.DateLbl = new System.Windows.Forms.Label();
            this.RegBTN = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.SProAddBTN = new System.Windows.Forms.Button();
            this.ProdQtyTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdPriceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BillTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.logoutLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.SellerNameLbl);
            this.panel1.Controls.Add(this.AmtLbl);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.ORDERDGV);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AddProdBTN);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.RegBTN);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.SProAddBTN);
            this.panel1.Controls.Add(this.ProdQtyTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdPriceTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdNameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BillTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(91, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 609);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellerNameLbl
            // 
            this.SellerNameLbl.AutoSize = true;
            this.SellerNameLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameLbl.ForeColor = System.Drawing.Color.White;
            this.SellerNameLbl.Location = new System.Drawing.Point(28, 27);
            this.SellerNameLbl.Name = "SellerNameLbl";
            this.SellerNameLbl.Size = new System.Drawing.Size(67, 25);
            this.SellerNameLbl.TabIndex = 29;
            this.SellerNameLbl.Text = "Seller";
            // 
            // AmtLbl
            // 
            this.AmtLbl.AutoSize = true;
            this.AmtLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtLbl.ForeColor = System.Drawing.Color.White;
            this.AmtLbl.Location = new System.Drawing.Point(788, 261);
            this.AmtLbl.Name = "AmtLbl";
            this.AmtLbl.Size = new System.Drawing.Size(60, 25);
            this.AmtLbl.TabIndex = 28;
            this.AmtLbl.Text = "BDT";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(589, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(287, 45);
            this.button5.TabIndex = 27;
            this.button5.Text = "SELLS LIST";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.ORDERDGV.Location = new System.Drawing.Point(376, 85);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.RowHeadersWidth = 51;
            this.ORDERDGV.RowTemplate.Height = 24;
            this.ORDERDGV.Size = new System.Drawing.Size(648, 159);
            this.ORDERDGV.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdId";
            this.Id.MinimumWidth = 4;
            this.Id.Name = "Id";
            this.Id.Width = 120;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "ProdPrice";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(557, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Amount BDT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddProdBTN
            // 
            this.AddProdBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddProdBTN.FlatAppearance.BorderSize = 0;
            this.AddProdBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProdBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdBTN.ForeColor = System.Drawing.Color.White;
            this.AddProdBTN.Location = new System.Drawing.Point(102, 227);
            this.AddProdBTN.Name = "AddProdBTN";
            this.AddProdBTN.Size = new System.Drawing.Size(207, 43);
            this.AddProdBTN.TabIndex = 23;
            this.AddProdBTN.Text = "Add Product";
            this.AddProdBTN.UseVisualStyleBackColor = false;
            this.AddProdBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(29, 319);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.RowHeadersWidth = 51;
            this.ProdDGV1.RowTemplate.Height = 24;
            this.ProdDGV1.Size = new System.Drawing.Size(338, 272);
            this.ProdDGV1.TabIndex = 21;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(933, 17);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(56, 20);
            this.DateLbl.TabIndex = 20;
            this.DateLbl.Text = "DATE";
            // 
            // RegBTN
            // 
            this.RegBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegBTN.FlatAppearance.BorderSize = 0;
            this.RegBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBTN.ForeColor = System.Drawing.Color.White;
            this.RegBTN.Location = new System.Drawing.Point(229, 276);
            this.RegBTN.Name = "RegBTN";
            this.RegBTN.Size = new System.Drawing.Size(138, 41);
            this.RegBTN.TabIndex = 18;
            this.RegBTN.Text = "Refresh";
            this.RegBTN.UseVisualStyleBackColor = false;
            this.RegBTN.Click += new System.EventHandler(this.RegBTN_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.comboBox2.Location = new System.Drawing.Point(31, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 27);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // BillsDGV
            // 
            this.BillsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(388, 382);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 51;
            this.BillsDGV.RowTemplate.Height = 24;
            this.BillsDGV.Size = new System.Drawing.Size(648, 149);
            this.BillsDGV.TabIndex = 16;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // SProAddBTN
            // 
            this.SProAddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SProAddBTN.FlatAppearance.BorderSize = 0;
            this.SProAddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SProAddBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SProAddBTN.ForeColor = System.Drawing.Color.White;
            this.SProAddBTN.Location = new System.Drawing.Point(657, 537);
            this.SProAddBTN.Name = "SProAddBTN";
            this.SProAddBTN.Size = new System.Drawing.Size(106, 43);
            this.SProAddBTN.TabIndex = 4;
            this.SProAddBTN.Text = "ADD";
            this.SProAddBTN.UseVisualStyleBackColor = false;
            this.SProAddBTN.Click += new System.EventHandler(this.SProAddBTN_Click);
            // 
            // ProdQtyTxt
            // 
            this.ProdQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTxt.Location = new System.Drawing.Point(167, 183);
            this.ProdQtyTxt.Name = "ProdQtyTxt";
            this.ProdQtyTxt.Size = new System.Drawing.Size(153, 26);
            this.ProdQtyTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            // 
            // ProdPriceTxt
            // 
            this.ProdPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceTxt.Location = new System.Drawing.Point(167, 151);
            this.ProdPriceTxt.Name = "ProdPriceTxt";
            this.ProdPriceTxt.Size = new System.Drawing.Size(153, 26);
            this.ProdPriceTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // ProdNameTxt
            // 
            this.ProdNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTxt.Location = new System.Drawing.Point(167, 116);
            this.ProdNameTxt.Name = "ProdNameTxt";
            this.ProdNameTxt.Size = new System.Drawing.Size(153, 26);
            this.ProdNameTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProdName";
            // 
            // BillTxt
            // 
            this.BillTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillTxt.Location = new System.Drawing.Point(167, 84);
            this.BillTxt.Name = "BillTxt";
            this.BillTxt.Size = new System.Drawing.Size(153, 26);
            this.BillTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BILLID";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(340, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(388, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "SELLING";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logoutLbl.Location = new System.Drawing.Point(1, 574);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(84, 25);
            this.logoutLbl.TabIndex = 30;
            this.logoutLbl.Text = "Logout";
            this.logoutLbl.Click += new System.EventHandler(this.logoutLbl_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 609);
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Button RegBTN;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.Button SProAddBTN;
        private System.Windows.Forms.TextBox ProdQtyTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdPriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BillTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView ORDERDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddProdBTN;
        private System.Windows.Forms.Label AmtLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label SellerNameLbl;
        private System.Windows.Forms.Label logoutLbl;
    }
}