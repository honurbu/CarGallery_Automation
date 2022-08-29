namespace CarGallery
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddCar = new System.Windows.Forms.Button();
            this.CarList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnInquire = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gBoxCarOperations = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblPurschase = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CarList.SuspendLayout();
            this.gBoxCarOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(388, 166);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(148, 41);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Araç Ekle ";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // CarList
            // 
            this.CarList.Controls.Add(this.label1);
            this.CarList.Controls.Add(this.radioButton3);
            this.CarList.Controls.Add(this.radioButton2);
            this.CarList.Controls.Add(this.btnInquire);
            this.CarList.Controls.Add(this.radioButton1);
            this.CarList.Location = new System.Drawing.Point(12, 347);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(547, 357);
            this.CarList.TabIndex = 2;
            this.CarList.TabStop = false;
            this.CarList.Text = "Araç Listeleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "_____________";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 149);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(178, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Elde Edilen Ortalama Kâr";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(197, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "En Yüksek Kâr\'a Göre Sırala";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnInquire
            // 
            this.btnInquire.Location = new System.Drawing.Point(304, 262);
            this.btnInquire.Name = "btnInquire";
            this.btnInquire.Size = new System.Drawing.Size(217, 71);
            this.btnInquire.TabIndex = 3;
            this.btnInquire.Text = "Sorgula";
            this.btnInquire.UseVisualStyleBackColor = true;
            this.btnInquire.Click += new System.EventHandler(this.btnInquire_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(142, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tüm Araçları Sırala";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gBoxCarOperations
            // 
            this.gBoxCarOperations.Controls.Add(this.btnDelete);
            this.gBoxCarOperations.Controls.Add(this.btnUpdate);
            this.gBoxCarOperations.Controls.Add(this.txtPlate);
            this.gBoxCarOperations.Controls.Add(this.txtColor);
            this.gBoxCarOperations.Controls.Add(this.btnAddCar);
            this.gBoxCarOperations.Controls.Add(this.txtSell);
            this.gBoxCarOperations.Controls.Add(this.txtPurchase);
            this.gBoxCarOperations.Controls.Add(this.txtYear);
            this.gBoxCarOperations.Controls.Add(this.txtModel);
            this.gBoxCarOperations.Controls.Add(this.txtBrand);
            this.gBoxCarOperations.Controls.Add(this.lblPlate);
            this.gBoxCarOperations.Controls.Add(this.lblColor);
            this.gBoxCarOperations.Controls.Add(this.lblSell);
            this.gBoxCarOperations.Controls.Add(this.lblPurschase);
            this.gBoxCarOperations.Controls.Add(this.lblYear);
            this.gBoxCarOperations.Controls.Add(this.lblModel);
            this.gBoxCarOperations.Controls.Add(this.lblBrand);
            this.gBoxCarOperations.Location = new System.Drawing.Point(609, 347);
            this.gBoxCarOperations.Name = "gBoxCarOperations";
            this.gBoxCarOperations.Size = new System.Drawing.Size(565, 357);
            this.gBoxCarOperations.TabIndex = 7;
            this.gBoxCarOperations.TabStop = false;
            this.gBoxCarOperations.Text = "Araç İşlemleri";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Seçili Aracı Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(388, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Araç Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(173, 311);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(100, 22);
            this.txtPlate.TabIndex = 42;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(173, 266);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 22);
            this.txtColor.TabIndex = 41;
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(173, 221);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(100, 22);
            this.txtSell.TabIndex = 40;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(173, 177);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(100, 22);
            this.txtPurchase.TabIndex = 39;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(173, 132);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 38;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(173, 84);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 37;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(176, 38);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 36;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(12, 311);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(92, 16);
            this.lblPlate.TabIndex = 35;
            this.lblPlate.Text = "Araç Plakası : ";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(15, 266);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(83, 16);
            this.lblColor.TabIndex = 34;
            this.lblColor.Text = "Araç Rengi : ";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Location = new System.Drawing.Point(12, 227);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(112, 16);
            this.lblSell.TabIndex = 33;
            this.lblSell.Text = "Araç Satış Fiyatı : ";
            // 
            // lblPurschase
            // 
            this.lblPurschase.AutoSize = true;
            this.lblPurschase.Location = new System.Drawing.Point(12, 183);
            this.lblPurschase.Name = "lblPurschase";
            this.lblPurschase.Size = new System.Drawing.Size(105, 16);
            this.lblPurschase.TabIndex = 32;
            this.lblPurschase.Text = "Araç Alım Fiyatı :";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 135);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(65, 16);
            this.lblYear.TabIndex = 31;
            this.lblYear.Text = "Araç Yılı : ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(88, 16);
            this.lblModel.TabIndex = 30;
            this.lblModel.Text = "Araç Modeli : ";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 38);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(95, 16);
            this.lblBrand.TabIndex = 29;
            this.lblBrand.Text = "Araç Markası : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 340);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 716);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gBoxCarOperations);
            this.Controls.Add(this.CarList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Galeri Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CarList.ResumeLayout(false);
            this.CarList.PerformLayout();
            this.gBoxCarOperations.ResumeLayout(false);
            this.gBoxCarOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.GroupBox CarList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnInquire;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox gBoxCarOperations;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblPurschase;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

