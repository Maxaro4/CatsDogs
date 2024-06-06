using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CatsDogs
{
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CatsDogs.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Table_ClientId";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateIbl.Text = DateTime.Now.ToLongDateString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            DateIbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_ClientId values("+clientidtbl.Text+",'"+clientnametbl.Text+"','"+clientpetnametbl.Text+"','"+clientphonetbl.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void ClientGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientidtbl.Text = ClientGridview.SelectedRows[0].Cells[0].Value.ToString();
            clientnametbl.Text = ClientGridview.SelectedRows[0].Cells[1].Value.ToString();
            clientpetnametbl.Text = ClientGridview.SelectedRows[0].Cells[2].Value.ToString();
            clientphonetbl.Text = ClientGridview.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Table_ClientId where ClientId = "+clientidtbl.Text+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client deleted");
            Con.Close();
            populate();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Table_ClientId set ClientName = '" + clientnametbl.Text + "', ClientsPetName = '" + clientpetnametbl.Text + "', ClientPhone = '" + clientphonetbl.Text + "' where ClientId = "+clientidtbl.Text+";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client edited");
            Con.Close();
            populate();
        }

        private void clientidtbl_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void clientnametbl_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void clientpetnametbl_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
