using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarGallery.Entity;
using System.Data.SqlClient;
using CarGallery.Properties;


namespace CarGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        CarDbEntities db = new CarDbEntities();

        Car cars = new Car();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Cars.ToList();            
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

            Car cs = new Car();

            var profit = db.Cars.Where(x => x.CarProfit >= 0).Average(y => y.CarProfit);

            int purch = Convert.ToInt32(txtPurchase.Text);

            int selll = Convert.ToInt32(txtSell.Text);

            int diff = (selll - purch);


            cs.CarBrand = txtBrand.Text;

            cs.CarModel = txtModel.Text;

            cs.CarYear = txtYear.Text;

            cs.CarPurchasePrice = Convert.ToInt32(txtPurchase.Text);

            cs.CarColor = txtColor.Text;

            cs.CarSellPrice = Convert.ToInt32(txtSell.Text);

            cs.CarPlate = txtPlate.Text;

            cs.CarProfit = diff;

            txtBrand.Clear();

            txtModel.Clear();

            txtYear.Clear();

            txtColor.Clear();

            txtPurchase.Clear();

            txtSell.Clear();

            txtPlate.Clear();

            if(diff<0)
            {
                cs.CarProfitStatus = "Zarar ! ";
            }
            else if(diff<profit)
            {
                cs.CarProfitStatus = "Ortalamanın Üstünde Kar ! ";
            }
            else
            {
                cs.CarProfitStatus = "Ortalamanın Altında Kar ! ";

            }


            MessageBox.Show("Araç Başarıyla Eklendi !");

            db.Cars.Add(cs);

            db.SaveChanges();



        }

        private void btnInquire_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = db.Cars.ToList();
            }

            if (radioButton2.Checked == true)
            {
                dataGridView1.DataSource = db.Cars.OrderByDescending(x => x.CarProfit).ToList();
            }

            if (radioButton3.Checked == true)
            {
                var values = db.Cars.Where(x => x.CarProfit >= 0).Average(y => y.CarProfit); 
                label1.Text = values.ToString();
            }

           
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Car cars = new Car();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)     
            {
                string value1 = row.Cells[0].Value.ToString();
                var id = Convert.ToInt32(value1);
                var update = db.Cars.Find(id);
                update.CarPlate = txtPlate.Text;
                update.CarBrand = txtPlate.Text;
                update.CarPurchasePrice = Convert.ToInt32(txtPurchase.Text);
                update.CarColor = txtColor.Text;
                update.CarModel = txtModel.Text;
                update.CarSellPrice = Convert.ToInt32(txtSell.Text);
                update.CarYear = txtYear.Text;


            }

            db.SaveChanges();
            MessageBox.Show("Araç Başarıyla Güncellendi !");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)     //murat yücedağ remove videosu yorunlardan buldum. Satırı Seçerek güncelleme
            {
                string value1 = row.Cells[0].Value.ToString();
                var id = Convert.ToInt32(value1);
                var remove = db.Cars.Find(id);
                db.Cars.Remove(remove);


            }

            db.SaveChanges();

            MessageBox.Show("Araç Başarıyla Silindi !");
        }
    }
}

