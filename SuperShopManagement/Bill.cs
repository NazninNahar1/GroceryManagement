using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SuperShopManagement
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            ItemTableShow();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SAIKAT-PC\SQLEXPRESS;Initial Catalog=SuperShopDB;Integrated Security=True");
        private void ItemTableShow()
        {
            con.Open();
            String query = "SELECT * From ItemTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int stock = 0;
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            blItemNameTb.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            BlPriceTb.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (blItemNameTb.Text == "")
            {
                stock = 0;
                key = 0;
            }
            else
            {
                stock = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[2].Value.ToString());
                key = Convert.ToInt32(ItemDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        int n=0,allTotal=0,key=0;
        private void reset()
        {
            blItemNameTb.Text = "";
            BlPriceTb.Text = "";
            BlqtyTb.Text = "";
            ClintNameTb.Text = "";
        } 
        private void UpdateQty()
        {
            if (key == 0)
            {
                MessageBox.Show("Select Item to be Updated");
            }
            else
            {
                try
                {
                    int newQty = stock - Convert.ToInt32( BlqtyTb.Text);
                    con.Open();
                    string query = "Update ItemTable set ItemQuantity=" + newQty + " where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Quantity Updeted Successfully");

                    con.Close();
                    ItemTableShow();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string EmName = Login.EmployeeName;
        
        private void button1_Click(object sender, EventArgs e)
        {

            if ( ClintNameTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTable values ('" + EmName + "','" + ClintNameTb.Text + "', '" + allTotal +  "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Information Saved Successfully");

                    con.Close();
                    ItemTableShow();
                    
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            userTb.Text = Login.EmployeeName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Hide();
        }
        int productId, productQty, ProductPrice, total;
        string productName,EmployeeName, clintName;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Super Shop Meena Bazar", new Font("Arial",20,FontStyle.Bold),Brushes.Black,new System.Drawing.Point(200,10));
            e.Graphics.DrawString("Sale Receipt", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(260, 40));
            e.Graphics.DrawString("-------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(20, 60));


            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                productId = Convert.ToInt32(row.Cells["Column1"].Value);
                 //   EmployeeName = "" + row.Cells["Collumn2"].Value;
                // clintName = "" + row.Cells["Collumn3"].Value;
                total = Convert.ToInt32(row.Cells["Column4"].Value);
                e.Graphics.DrawString("Id:" + productId, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(200, 80));
             e.Graphics.DrawString("Clint Name" + clintName, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(200, 100));
                e.Graphics.DrawString("Total" + total, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(200, 120));

            }




            e.Graphics.DrawString("*********************End********************", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(60, 500));
            e.Graphics.DrawString("**Thank you**", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(260, 540));
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void AddTobillBtn_Click(object sender, EventArgs e)
        {
            if (BlqtyTb.Text == "")
            {
                MessageBox.Show("Eter Quantity");
            }else if (Convert.ToInt32(BlqtyTb.Text) > stock)
            {
                MessageBox.Show("Out of Stock Limit");

            }
            else
            {
                int total = Convert.ToInt32(BlPriceTb.Text) * Convert.ToInt32(BlqtyTb.Text);
                DataGridViewRow nwRow =new DataGridViewRow();
                nwRow.CreateCells(BillDGV);
                nwRow.Cells[0].Value = n + 1;
                nwRow.Cells[1].Value = blItemNameTb.Text;
                nwRow.Cells[2].Value = BlPriceTb.Text;
                nwRow.Cells[3].Value = BlqtyTb.Text;
                nwRow.Cells[4].Value = total;
                BillDGV.Rows.Add(nwRow);
                allTotal = allTotal + total;
                totallbl.Text =""+ allTotal+" BDT";
                n++;
                UpdateQty();
                reset();
                
                
            }
        }
    }
}
