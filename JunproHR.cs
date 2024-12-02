using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JunproRama_492727
{
    public partial class JunproHR : Form
    {
        private int departement_id;
        public JunproHR()
        {
            InitializeComponent();
            InitGroupbox();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=hr_junpro492727";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void InitGroupbox()
        {
            gb_iddept.Text = "ID Departemen: \n";
            gb_iddept.Text += "HR : HR\n";
            gb_iddept.Text += "ENG : Engineer\n";
            gb_iddept.Text += "DEV : Developer\n";
            gb_iddept.Text += "PM : Product Manager\n";
            gb_iddept.Text += "FIN : Finance\n";
        }

        private void JunproHR_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = @"select * from tb_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        //ENKAPSULASI
        private int getId(string dep)
        {
            switch (dep)
            {
                case "HR":
                    return 1;
                case "ENG":
                    return 2;
                case "DEV":
                    return 3;
                case "PM":
                    return 4;
                case "FIN":
                    return 5;
                default:
                    return 0;
            }
        }

        private int getId2(string dep)
        {
            switch (dep)
            {
                case "HR":
                    return 1;
                case "Engineer":
                    return 2;
                case "Developer":
                    return 3;
                case "Product Manager":
                    return 4;
                case "Finance":
                    return 5;
                default:
                    return 0;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from tb_insert(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);

                int dep_id = getId(cb_departemen.Text);
                if(dep_id == 0)
                {
                    MessageBox.Show("Departemen tidak ditemukan", "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

                cmd.Parameters.AddWithValue("_id_karyawan", tb_idkaryawan.Text);
                cmd.Parameters.AddWithValue("_nama", tb_karyawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", dep_id);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_load.PerformClick();
                    tb_karyawan.Text = tb_idkaryawan.Text = cb_departemen.Text = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tb_idkaryawan.Text = r.Cells["id_karyawan"].Value.ToString();
                tb_karyawan.Text = r.Cells["nama"].Value.ToString();
                cb_departemen.Text = r.Cells["nama_departemen"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from karyawan_update(:_id, :_name, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);

                int dep_id = getId(cb_departemen.Text);
                if (dep_id == 0)
                {
                    MessageBox.Show("Departemen tidak ditemukan", "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

                cmd.Parameters.AddWithValue("_id", r.Cells["id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", tb_karyawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", dep_id);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_load.PerformClick();
                    tb_karyawan.Text = tb_idkaryawan.Text = cb_departemen.Text = null;
                    r = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["nama"].Value.ToString() + " ?", "Konfirmasi Hapus Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from karyawan_delete(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btn_load.PerformClick();
                        tb_karyawan.Text = tb_idkaryawan.Text = cb_departemen.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
