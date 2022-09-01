
namespace SuperShopManagement
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.blItemNameTb = new System.Windows.Forms.TextBox();
            this.BlPriceTb = new System.Windows.Forms.TextBox();
            this.BlqtyTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddTobillBtn = new System.Windows.Forms.Button();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totallbl = new System.Windows.Forms.Label();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClintNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userTb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Location = new System.Drawing.Point(380, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 6);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(222, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(18, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Price";
            // 
            // blItemNameTb
            // 
            this.blItemNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blItemNameTb.Location = new System.Drawing.Point(13, 104);
            this.blItemNameTb.Name = "blItemNameTb";
            this.blItemNameTb.Size = new System.Drawing.Size(178, 31);
            this.blItemNameTb.TabIndex = 17;
            // 
            // BlPriceTb
            // 
            this.BlPriceTb.Enabled = false;
            this.BlPriceTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlPriceTb.Location = new System.Drawing.Point(13, 177);
            this.BlPriceTb.Name = "BlPriceTb";
            this.BlPriceTb.Size = new System.Drawing.Size(178, 31);
            this.BlPriceTb.TabIndex = 18;
            // 
            // BlqtyTb
            // 
            this.BlqtyTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlqtyTb.Location = new System.Drawing.Point(222, 104);
            this.BlqtyTb.Name = "BlqtyTb";
            this.BlqtyTb.Size = new System.Drawing.Size(178, 31);
            this.BlqtyTb.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(222, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Clint Name";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Orchid;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(222, 224);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(89, 31);
            this.ResetBtn.TabIndex = 24;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddTobillBtn
            // 
            this.AddTobillBtn.BackColor = System.Drawing.Color.Orchid;
            this.AddTobillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTobillBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTobillBtn.ForeColor = System.Drawing.Color.White;
            this.AddTobillBtn.Location = new System.Drawing.Point(102, 224);
            this.AddTobillBtn.Name = "AddTobillBtn";
            this.AddTobillBtn.Size = new System.Drawing.Size(89, 31);
            this.AddTobillBtn.TabIndex = 25;
            this.AddTobillBtn.Text = "Add to Bill";
            this.AddTobillBtn.UseVisualStyleBackColor = false;
            this.AddTobillBtn.Click += new System.EventHandler(this.AddTobillBtn_Click);
            // 
            // BillDGV
            // 
            this.BillDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillDGV.Location = new System.Drawing.Point(406, 87);
            this.BillDGV.Name = "BillDGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BillDGV.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.BillDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.BillDGV.RowTemplate.Height = 25;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(524, 208);
            this.BillDGV.TabIndex = 26;
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.totallbl);
            this.panel1.Controls.Add(this.ItemDGV);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ClintNameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BillDGV);
            this.panel1.Controls.Add(this.AddTobillBtn);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BlqtyTb);
            this.panel1.Controls.Add(this.BlPriceTb);
            this.panel1.Controls.Add(this.blItemNameTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 491);
            this.panel1.TabIndex = 9;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totallbl.ForeColor = System.Drawing.Color.Crimson;
            this.totallbl.Location = new System.Drawing.Point(689, 362);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(21, 23);
            this.totallbl.TabIndex = 36;
            this.totallbl.Text = "0";
            // 
            // ItemDGV
            // 
            this.ItemDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.Location = new System.Drawing.Point(9, 301);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowTemplate.Height = 25;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(491, 182);
            this.ItemDGV.TabIndex = 35;
            this.ItemDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(619, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(619, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(184, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Item List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(627, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bill ";
            // 
            // ClintNameTb
            // 
            this.ClintNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClintNameTb.Location = new System.Drawing.Point(222, 177);
            this.ClintNameTb.Name = "ClintNameTb";
            this.ClintNameTb.Size = new System.Drawing.Size(178, 31);
            this.ClintNameTb.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(380, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "SUPER SHOP";
            // 
            // userTb
            // 
            this.userTb.AutoSize = true;
            this.userTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userTb.ForeColor = System.Drawing.Color.White;
            this.userTb.Location = new System.Drawing.Point(837, 4);
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(67, 23);
            this.userTb.TabIndex = 17;
            this.userTb.Text = "Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(831, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 37;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(935, 525);
            this.Controls.Add(this.userTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox blItemNameTb;
        private System.Windows.Forms.TextBox BlPriceTb;
        private System.Windows.Forms.TextBox BlqtyTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button AddTobillBtn;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClintNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label userTb;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}