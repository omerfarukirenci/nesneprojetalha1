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

namespace nesneprojetalha1.Forms
{
    public partial class FrmDoorman : Form
    {
        public FrmDoorman()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        void LoadBlocks()
        {
            var Blocks = db.Blockies.ToList();
            cbCategory.DataSource = Blocks;
            cbCategory.DisplayMember = "CategoryId";
            cbCategory.ValueMember = "Id";

        }
        void Type()
        {
            var Blocks = db.Blockies.ToList();
            cbType.DataSource = Blocks;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtAmount.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Doorman = new Doorman();

            Doorman.Amount = float.Parse(txtAmount.Text);
            Doorman.Description = txtDescription.Text;
            Doorman.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
            Doorman.Type = cbType.Text;
            Doorman.Date = dtDate.Value;
            Doorman.Created = DateTime.Now;
            Doorman.Updated = DateTime.Now;


            db.Doormans.Add(Doorman);
            db.SaveChanges();

            MessageBox.Show("Başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDoormanList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAmount.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var Doorman = db.Doormans.Where(s => s.Id == id).SingleOrDefault();
            if (Doorman == null)
            {
                MessageBox.Show("Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Doorman.Amount = float.Parse(txtAmount.Text);
            Doorman.Description = txtDescription.Text;
            Doorman.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
            Doorman.Type = cbType.Text;
            Doorman.Date = dtDate.Value;
            Doorman.Created = DateTime.Now;
            Doorman.Updated = DateTime.Now;
            db.Doormans.Update(Doorman);

            db.SaveChanges();

            MessageBox.Show("Gider başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDoormanList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Gider Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var Doorman = db.Doormans.Where(s => s.Id == id).SingleOrDefault();
            if (Doorman == null)
            {
                MessageBox.Show("Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.Doormans.Remove(Doorman);
            db.SaveChanges();

            MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDoormanList();
        }
        void GetDoormanList()
        {
            dgDoorman.Rows.Clear();
            var Doormans = db.Doormans.ToList();
            foreach (var Doorman in Doormans)
            {
                dgDoorman.Rows.Add(Doorman.Id, Doorman.Date, Doorman.Amount, Doorman.Description, Doorman.Type);
            }
        }

        private void FrmDoorman_Load_1(object sender, EventArgs e)
        {
            GetDoormanList();
            Type();
            LoadBlocks();
        }

        private void dgDoorman_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgDoorman.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgDoorman.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgDoorman.CurrentRow.Cells[3].Value.ToString();
            cbType.Text = dgDoorman.CurrentRow.Cells[4].Value.ToString();
        }

      //  private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
       // {
      //      cbType.SelectedValue = cbCategory.SelectedValue;
       // }

        private void cbBlockies_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.SelectedValue = cbBlockies_SelectedIndexChanged;
        }
    }
}

