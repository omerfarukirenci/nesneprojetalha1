using nesneprojetalha1.Models;

namespace nesneprojetalha1
{
    public partial class FrmCarPark : Form
    {
        public FrmCarPark()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        //
        private void FrmCarPark_Load_1(object sender, EventArgs e)
        {
            GetCarParkList();
            LoadBlockies();
            Type();

        }
        void LoadBlockies()
        {
            var Blocks = db.Blockies.ToList();
            cbBlocksId.DataSource = Blocks;
            cbBlocksId.DisplayMember = "BlocksId"; 
            cbBlocksId.ValueMember = "Id";
        }

        //void LoadBlockies()
        //{
        //var Block = db.Blockies.ToList();
        //cbBlock.DataSource = cbBlock;
        //cbBlock.DisplayMember = "BlocksId";
        //cbBlock.ValueMember = "Id";
        //}

        void Type()
        {
            var Blockies = db.Blockies.ToList();
            cbType.DataSource = Blockies;
            cbType.DisplayMember = "Name"; 
            cbType.ValueMember = "Id";
        }

        //void Type()
        //{
        //var Blockies = db.Blockies.ToList();
        //cbType.DataSource = Blockies;
        //cbType.DisplayMember = "Name";
        //cbType.ValueMember = "Id";
        //}
        //
        void GetCarParkList()
        {
            dgCarPark.Rows.Clear();
            var CarParks = db.CarParks.ToList();
            foreach (var CarPark in CarParks)
            {
                dgCarPark.Rows.Add(CarPark.Id, CarPark.Date, CarPark.Amount, CarPark.SuitNo, CarPark.Type);
            }
        }
        //
        private void dgCarPark_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCarPark.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgCarPark.CurrentRow.Cells[2].Value.ToString();
            txtSuitNo.Text = dgCarPark.CurrentRow.Cells[3].Value.ToString();
            cbType.Text = dgCarPark.CurrentRow.Cells[4].Value.ToString();
        }
        //
        private void cbBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.SelectedValue = cbBlocksId.SelectedValue;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtSuitNo.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanlarý Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var CarPark = new CarPark();

            CarPark.Amount = float.Parse(txtAmount.Text);
            CarPark.SuitNo = txtSuitNo.Text;
            CarPark.Block = Convert.ToInt32(cbBlocksId.Text);
            CarPark.Type = cbType.Text;
            CarPark.Date = dtDate.Value;
            CarPark.Created = DateTime.Now;
            CarPark.Updated = DateTime.Now;

            db.CarParks.Add(CarPark);
            db.SaveChanges();

            MessageBox.Show("Baþarýyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCarParkList();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAmount.Text == "" || txtSuitNo.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanlarý Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var CarPark = db.CarParks.Where(s => s.Id == id).SingleOrDefault();
            if (CarPark == null)
            {
                MessageBox.Show("Bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarPark.Amount = float.Parse(txtAmount.Text);
            CarPark.SuitNo = txtSuitNo.Text;
            CarPark.Block = Convert.ToInt32(cbBlocksId.SelectedValue);
            CarPark.Type = cbType.Text;
            CarPark.Date = dtDate.Value;
            CarPark.Created = DateTime.Now;
            CarPark.Updated = DateTime.Now;
            db.CarParks.Update(CarPark);

            db.SaveChanges();

            MessageBox.Show("Baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCarParkList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var CarPark = db.CarParks.Where(s => s.Id == id).SingleOrDefault();
            if (CarPark == null)
            {
                MessageBox.Show("Gelir Bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.CarParks.Remove(CarPark);
            db.SaveChanges();

            MessageBox.Show("Gelir baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCarParkList();
        }
    }
}
