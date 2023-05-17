namespace SuperMarket_Man
{
    partial class CATEGORYFORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.CatDeleteBTN = new System.Windows.Forms.Button();
            this.CatEditBTN = new System.Windows.Forms.Button();
            this.CatAdd = new System.Windows.Forms.Button();
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CatidTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.CatProBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CatlogoutLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.CatDeleteBTN);
            this.panel1.Controls.Add(this.CatEditBTN);
            this.panel1.Controls.Add(this.CatAdd);
            this.panel1.Controls.Add(this.CatDescTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CatNameTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CatidTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(140, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 609);
            this.panel1.TabIndex = 2;
            // 
            // CatDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CatDGV.BackgroundColor = System.Drawing.Color.White;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.GridColor = System.Drawing.Color.Khaki;
            this.CatDGV.Location = new System.Drawing.Point(477, 148);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.RowTemplate.Height = 24;
            this.CatDGV.Size = new System.Drawing.Size(609, 444);
            this.CatDGV.TabIndex = 16;
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // CatDeleteBTN
            // 
            this.CatDeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatDeleteBTN.FlatAppearance.BorderSize = 0;
            this.CatDeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatDeleteBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDeleteBTN.ForeColor = System.Drawing.Color.White;
            this.CatDeleteBTN.Location = new System.Drawing.Point(277, 297);
            this.CatDeleteBTN.Name = "CatDeleteBTN";
            this.CatDeleteBTN.Size = new System.Drawing.Size(106, 41);
            this.CatDeleteBTN.TabIndex = 15;
            this.CatDeleteBTN.Text = "DELETE";
            this.CatDeleteBTN.UseVisualStyleBackColor = false;
            this.CatDeleteBTN.Click += new System.EventHandler(this.CatDeleteBTN_Click);
            // 
            // CatEditBTN
            // 
            this.CatEditBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatEditBTN.FlatAppearance.BorderSize = 0;
            this.CatEditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatEditBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatEditBTN.ForeColor = System.Drawing.Color.White;
            this.CatEditBTN.Location = new System.Drawing.Point(149, 297);
            this.CatEditBTN.Name = "CatEditBTN";
            this.CatEditBTN.Size = new System.Drawing.Size(106, 41);
            this.CatEditBTN.TabIndex = 14;
            this.CatEditBTN.Text = "EDIT";
            this.CatEditBTN.UseVisualStyleBackColor = false;
            this.CatEditBTN.Click += new System.EventHandler(this.CatEditBTN_Click);
            // 
            // CatAdd
            // 
            this.CatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatAdd.FlatAppearance.BorderSize = 0;
            this.CatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatAdd.ForeColor = System.Drawing.Color.White;
            this.CatAdd.Location = new System.Drawing.Point(37, 297);
            this.CatAdd.Name = "CatAdd";
            this.CatAdd.Size = new System.Drawing.Size(106, 41);
            this.CatAdd.TabIndex = 4;
            this.CatAdd.Text = "ADD";
            this.CatAdd.UseVisualStyleBackColor = false;
            this.CatAdd.Click += new System.EventHandler(this.CatAdd_Click);
            // 
            // CatDescTb
            // 
            this.CatDescTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTb.Location = new System.Drawing.Point(219, 225);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(153, 30);
            this.CatDescTb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPTION";
            // 
            // CatNameTb
            // 
            this.CatNameTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.Location = new System.Drawing.Point(219, 179);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(153, 30);
            this.CatNameTb.TabIndex = 7;
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
            // CatidTb
            // 
            this.CatidTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatidTb.Location = new System.Drawing.Point(219, 126);
            this.CatidTb.Name = "CatidTb";
            this.CatidTb.Size = new System.Drawing.Size(153, 30);
            this.CatidTb.TabIndex = 5;
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
            this.button4.Text = "MANAGE CATEGORY";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CatProBtn
            // 
            this.CatProBtn.FlatAppearance.BorderSize = 0;
            this.CatProBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatProBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatProBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatProBtn.Location = new System.Drawing.Point(-1, 144);
            this.CatProBtn.Name = "CatProBtn";
            this.CatProBtn.Size = new System.Drawing.Size(128, 49);
            this.CatProBtn.TabIndex = 18;
            this.CatProBtn.Text = "Products";
            this.CatProBtn.UseVisualStyleBackColor = true;
            this.CatProBtn.Click += new System.EventHandler(this.CatProBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatlogoutLbl
            // 
            this.CatlogoutLbl.AutoSize = true;
            this.CatlogoutLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatlogoutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatlogoutLbl.Location = new System.Drawing.Point(25, 595);
            this.CatlogoutLbl.Name = "CatlogoutLbl";
            this.CatlogoutLbl.Size = new System.Drawing.Size(84, 25);
            this.CatlogoutLbl.TabIndex = 32;
            this.CatlogoutLbl.Text = "Logout";
            this.CatlogoutLbl.Click += new System.EventHandler(this.CatlogoutLbl_Click);
            // 
            // CATEGORYFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 671);
            this.Controls.Add(this.CatlogoutLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CatProBtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CATEGORYFORM";
            this.Text = "CATEGORYFORM";
            this.Load += new System.EventHandler(this.CATEGORYFORM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Button CatDeleteBTN;
        private System.Windows.Forms.Button CatEditBTN;
        private System.Windows.Forms.Button CatAdd;
        private System.Windows.Forms.TextBox CatDescTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CatNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CatidTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CatProBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CatlogoutLbl;
    }
}