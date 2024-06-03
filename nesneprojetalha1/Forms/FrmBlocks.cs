using nesneprojetalha1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace nesneprojetalha1.Forms
{
    public partial class FrmBlocks : Form
    {
        public FrmBlocks()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmBlocks_Load(object sender, EventArgs e)
        {
            GetBlocksList();
            dgCarPark.Visible = false;
            dgDoorman.Visible = false;
            GetCarParkList();
            GetDoormanList();
            lbCar.Visible = false;
            lbDoor.Visible = false;
        }
        void GetBlocksList()
        {
            var Blocks = db.Blockies.ToList();
            dgBlockies.Rows.Clear();
            foreach (var Block in Blocks)
            {
                dgBlockies.Rows.Add(Block.Id, Block.Name, Block.Type, Block.Created, Block.Updated);
            }
        }
        void Calculate()
        {
            double amount = 0;
            for (int i = 0; i < dgCarPark.Rows.Count; i++)
            {
                amount += Convert.ToDouble(dgCarPark.Rows[i].Cells[2].Value.ToString());
            }
            lbCar.Text = amount.ToString("Boş");

            double price = 0;
            for (int i = 0; i < dgDoorman.Rows.Count; i++)
            {
                price += Convert.ToDouble(dgDoorman.Rows[i].Cells[2].Value.ToString());
            }
            lbDoor.Text = price.ToString("Boş");

            double diff = amount - price;
            lbDiff.Text = diff.ToString("Boş");
            if (diff < 0)
            {
                lbDiff.ForeColor = Color.Red;
            }
            else
            {
                lbDiff.ForeColor = Color.Green;
            }
        }
        void GetCarParkList()
        {
            dgCarPark.Rows.Clear();
            var carparks = db.CarParks.ToList();
            foreach (var carpark in carparks)
            {
                dgCarPark.Rows.Add(carpark.Id, carpark.Date, carpark.Amount, carpark.SuitNo, carpark.Type);
            }
            Calculate();
            //dgCarPark.Rows.Clear();
            //var CarParks = db.CarParks.ToList();
            //foreach (var CarPark in CarParks)
            //{
            //    dgCarPark.Rows.Add(dgCarPark.Id, dgCarPark.Date, dgCarPark.Amount, dgCarPark.Description, dgCarPark.Type);
            //}
            //Calculate();
        }
        void GetDoormanList()
        {
            dgDoorman.Rows.Clear();
            var Doormans = db.Doormans.ToList();
            foreach (var Doorman in Doormans)
            {
                dgDoorman.Rows.Add(Doorman.Id, Doorman.Date, Doorman.Amount, Doorman.Description, Doorman.Type);
            }
            Calculate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cbType.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Blocks = new Blocks();

            Blocks.Name = txtName.Text;
            Blocks.Type = cbType.Text;
            Blocks.Created = DateTime.Now;
            Blocks.Updated = DateTime.Now;


            db.Blockies.Add(Blocks);
            db.SaveChanges();


            MessageBox.Show("Başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetBlocksList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || cbType.Text == "")
            {
                MessageBox.Show("Lütfen Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);


            var Blocks = db.Blockies.Where(s => s.Id == id).SingleOrDefault();
            if (Blocks == null)
            {
                MessageBox.Show("Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Blocks.Name = txtName.Text;
            Blocks.Type = cbType.Text;
            Blocks.Updated = DateTime.Now;
            db.Blockies.Update(Blocks);
            db.SaveChanges();


            MessageBox.Show("Başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetBlocksList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);


            var Blocks = db.Blockies.Where(s => s.Id == id).SingleOrDefault();
            if (Blocks == null)
            {
                MessageBox.Show("Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Blockies.Remove(Blocks);
            db.SaveChanges();


            MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetBlocksList();
        }

        //private void dgBlockss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
            //txtId.Text = dgBlocks.CurrentRow.Cells[0].Value.ToString();
            //txtName.Text = dgBlocks.CurrentRow.Cells[1].Value.ToString();
            //cbType.Text = dgBlocks.CurrentRow.Cells[2].Value.ToString();
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgCarPark.Visible = true;
            dgBlockies.Visible = true;
            dgDoorman.Visible = true;
            lbCar.Visible = true;
            lbDoor.Visible = true;
        }

        private void dgDoorman_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIncomeId.Text = dgDoorman.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgDoorman.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgDoorman.CurrentRow.Cells[3].Value.ToString();

            dgCarPark.Visible = true;
            dgBlockies.Visible = true;
            dgDoorman.Visible = true;
        }

        private void dgCarPark_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExpenseId.Text = dgCarPark.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgCarPark.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgCarPark.CurrentRow.Cells[3].Value.ToString();

            dgCarPark.Visible = true;
            dgBlockies.Visible = true;
            dgDoorman.Visible = true;
        }

        private void dgBlocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgBlockies.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgBlockies.CurrentRow.Cells[1].Value.ToString();
            cbType.Text = dgBlockies.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
