namespace WindowsFormsApp2
{
    partial class AdminÜrünİşlemleri
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
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.tboxProductPrice = new System.Windows.Forms.TextBox();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(180, 32);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(561, 169);
            this.dgProduct.TabIndex = 0;
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxProductBarcode);
            this.groupBox1.Controls.Add(this.tboxProductPrice);
            this.groupBox1.Controls.Add(this.tboxProductName);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(3, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 325);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(12, 61);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxCategory.TabIndex = 0;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(12, 117);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(100, 22);
            this.tboxProductName.TabIndex = 1;
            // 
            // tboxProductPrice
            // 
            this.tboxProductPrice.Location = new System.Drawing.Point(12, 186);
            this.tboxProductPrice.Name = "tboxProductPrice";
            this.tboxProductPrice.Size = new System.Drawing.Size(100, 22);
            this.tboxProductPrice.TabIndex = 2;
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Location = new System.Drawing.Point(12, 243);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(100, 22);
            this.tboxProductBarcode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "KATEGORİ SEÇİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADINI GİRİNİZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "FİYATINI GİRİNİZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "BARKOD GİRİNİZ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "EKLE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSelectedID);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(325, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 325);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Silme";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(54, 40);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedID.TabIndex = 2;
            // 
            // cmbKamera
            // 
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Location = new System.Drawing.Point(866, 52);
            this.cmbKamera.Name = "cmbKamera";
            this.cmbKamera.Size = new System.Drawing.Size(310, 24);
            this.cmbKamera.TabIndex = 4;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(866, 82);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(571, 333);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(866, 444);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(866, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(1101, 444);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // AdminÜrünİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 567);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cmbKamera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgProduct);
            this.Name = "AdminÜrünİşlemleri";
            this.Text = "AdminÜrünİşlemleri";
            this.Load += new System.EventHandler(this.AdminÜrünİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.TextBox tboxProductPrice;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKapat;
    }
}