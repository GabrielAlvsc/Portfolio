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


namespace Tfinal
{
    public partial class Form1 : Form
    {
        private string stringcon = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "123321", "postgres");
        private NpgsqlConnection con;
        private string sql;
        private NpgsqlCommand com;
        private DataTable cl_data;
        private DataTable pr_data;
        private DataTable co_data;
        private int cl_ri = -1;
        private int pr_ri = -1;
        private int co_ri = -1;

        private List<Cliente> fregues = new List<Cliente>();
        private List<Produto> carrinho = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(stringcon);
            Select_Cliente();
            Select_Produto();
            Select_Compra();
            bcl_save.Enabled = false;
            bco_save.Enabled = false;
            bp_save.Enabled = false;
        }

        private void Select_Cliente()
        {
            try
            {

                con.Open();
                NpgsqlDataAdapter cl_datasel;
                sql = @"SELECT * FROM cl_select()";
                com = new NpgsqlCommand(sql, con);
                cl_data = new DataTable();
                //cl_data.Load(com.ExecuteReader());
                cl_datasel = new NpgsqlDataAdapter(com);//
                con.Close();
                cl_datasel.Fill(cl_data);//
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = cl_data;

                fregues.Clear();
                cbco_n.Items.Clear();
                foreach(DataRow dtRow in cl_data.Rows)
                {
                    Cliente cliente = new Cliente(int.Parse(dtRow["id_"].ToString()), dtRow["nome_"].ToString(), dtRow["sobrenome_"].ToString());
                    fregues.Add(cliente);
                    cbco_n.Items.Add(cliente.getN());
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Erro detectado: "+ex.Message);
            }
        }
        private void Select_Produto()
        {
            try
            {
                con.Open();
                NpgsqlDataAdapter pr_datasel;
                sql = @"SELECT * FROM pr_select()";
                com = new NpgsqlCommand(sql, con);
                pr_data = new DataTable();
                //pr_data.Load(com.ExecuteReader());
                pr_datasel = new NpgsqlDataAdapter(com);//
                con.Close();
                pr_datasel.Fill(pr_data);//
                dgvProduto.DataSource = null;
                dgvProduto.DataSource = pr_data;

                carrinho.Clear();
                cbco_p.Items.Clear();
                foreach (DataRow dtRow in pr_data.Rows)
                {
                    Produto produto = new Produto(int.Parse(dtRow["id_"].ToString()), dtRow["nome_"].ToString(), 
                        double.Parse(dtRow["preco_"].ToString()), dtRow["descricao_"].ToString());
                    carrinho.Add(produto);
                    cbco_p.Items.Add(produto.getN());
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Erro detectado: " + ex.Message);
            }
        }
        private void Select_Compra()
        {
            try
            {
                con.Open();
                NpgsqlDataAdapter co_datasel;//
                sql = @"SELECT * FROM co_select()";
                com = new NpgsqlCommand(sql, con);
                co_data = new DataTable();
                //co_data.Load(com.ExecuteReader());
                co_datasel = new NpgsqlDataAdapter(com);//
                con.Close();
                co_datasel.Fill(co_data);//
                dgvCompra.DataSource = null;
                dgvCompra.DataSource = co_data;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Erro detectado: " + ex.Message);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cl_ri = e.RowIndex;
                txtcl_n.Text = dgvCliente.Rows[e.RowIndex].Cells["nome_"].Value.ToString();
                txtcl_s.Text = dgvCliente.Rows[e.RowIndex].Cells["sobrenome_"].Value.ToString();
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pr_ri = e.RowIndex;
                txtpr_n.Text = dgvProduto.Rows[e.RowIndex].Cells["nome_"].Value.ToString();
                txtpr_p.Text = dgvProduto.Rows[e.RowIndex].Cells["preco_"].Value.ToString();
                txtpr_d.Text = dgvProduto.Rows[e.RowIndex].Cells["descricao_"].Value.ToString();
            }
        }

        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                co_ri = e.RowIndex;
                for (int i = 0; i < fregues.Count(); i++)
                {
                    if (fregues[i].getN() == (dgvCompra.Rows[co_ri].Cells["nome_"].Value.ToString()))
                    {
                        cbco_n.SelectedIndex = i;
                    }
                }
                for (int i = 0;i< carrinho.Count(); i++)
                {
                    if (carrinho[i].getN() == (dgvCompra.Rows[co_ri].Cells["produto_"].Value.ToString()))
                    {
                        cbco_p.SelectedIndex = i;
                    }
                }
                txtco_q.Text = dgvCompra.Rows[co_ri].Cells["quantidade_"].Value.ToString();
            }
        }

        private void bcl_insert_Click(object sender, EventArgs e)
        {
            cl_ri = -1;
            txtcl_n.Text = txtcl_s.Text = null;
            txtcl_n.Enabled = txtcl_s.Enabled = true;
            bcl_delete.Enabled = bcl_insert.Enabled = bcl_update.Enabled = false;
            bcl_save.Enabled = true;
            txtcl_n.Select();
        }

        private void bp_insert_Click(object sender, EventArgs e)
        {
            pr_ri = -1;
            txtpr_n.Text = txtpr_p.Text = txtpr_d.Text =  null;
            txtpr_n.Enabled = txtpr_p.Enabled = txtpr_d.Enabled = true;
            bp_delete.Enabled = bp_insert.Enabled = bp_update.Enabled = false;
            bp_save.Enabled = true;
            txtpr_n.Select();
        }

        private void bco_insert_Click(object sender, EventArgs e)
        {
            co_ri = -1;
            cbco_n.Text = cbco_p.Text = txtco_q.Text = null;
            cbco_n.Enabled = cbco_p.Enabled = txtco_q.Enabled = true;
            bco_delete.Enabled = bco_insert.Enabled = bco_update.Enabled = false;
            bco_save.Enabled = true;
            cbco_n.Select();
        }

        private void bcl_update_Click(object sender, EventArgs e)
        {
            if (cl_ri < 0)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }
            txtcl_n.Enabled = txtcl_s.Enabled = true;
            bcl_delete.Enabled = bcl_insert.Enabled = bcl_update.Enabled = false;
            bcl_save.Enabled = true;
            txtcl_n.Select();

        }

        private void bp_update_Click(object sender, EventArgs e)
        {
            if (pr_ri < 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }
            txtpr_n.Enabled = txtpr_p.Enabled = txtpr_d.Enabled = true;
            bp_delete.Enabled = bp_insert.Enabled = bp_update.Enabled = false;
            bp_save.Enabled = true;
            txtpr_n.Select();

        }

        private void bco_update_Click(object sender, EventArgs e)
        {
            if (co_ri < 0)
            {
                MessageBox.Show("Selecione uma compra");
                return;
            }
            cbco_n.Enabled = cbco_p.Enabled = txtco_q.Enabled = true;
            bco_delete.Enabled = bco_insert.Enabled = bco_update.Enabled = false;
            bco_save.Enabled = true;
            cbco_n.Select();
        }

        private void bcl_save_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (cl_ri < 0)
            {
                try
                {
                    con.Open();
                    sql = @"SELECT * FROM cl_insert (:_n,:_sn)";
                    com = new NpgsqlCommand(sql, con);
                    com.Parameters.AddWithValue("_n", txtcl_n.Text);
                    com.Parameters.AddWithValue("_sn", txtcl_s.Text);
                    r = (int)com.ExecuteScalar();
                    con.Close();
                    if (r == 1)
                    {
                        MessageBox.Show("Cliente Inserido");
                        Select_Cliente();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não Inserido");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Erro detectado: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    sql = @"SELECT * FROM cl_update (:id_,:n_,:sn_)";
                    com = new NpgsqlCommand(sql, con);
                    com.Parameters.AddWithValue("id_", int.Parse(dgvCliente.Rows[cl_ri].Cells["id_"].Value.ToString()));
                    com.Parameters.AddWithValue("n_", txtcl_n.Text);
                    com.Parameters.AddWithValue("sn_", txtcl_s.Text);
                    r = (int)com.ExecuteScalar();
                    con.Close();
                    if (r == 1)
                    {
                        MessageBox.Show("Cliente Alterado");
                        Select_Cliente();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não Inserido");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Erro detectado: " + ex.Message);
                }
            }
            cl_ri = -1;
            txtcl_n.Text = txtcl_s.Text = null;
            txtcl_n.Enabled = txtcl_s.Enabled = false;
            bcl_delete.Enabled = bcl_insert.Enabled = bcl_update.Enabled = true;
            bcl_save.Enabled = false;
        }

        private void bp_save_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (pr_ri < 0)
            {
                try
                {
                    con.Open();
                    sql = @"SELECT * FROM pr_insert(:_n,:_p,:_d)";
                    com = new NpgsqlCommand(sql, con);
                    com.Parameters.AddWithValue("_n", txtpr_n.Text);
                    com.Parameters.AddWithValue("_p", long.Parse(txtpr_p.Text));
                    com.Parameters.AddWithValue("_d", txtpr_d.Text);
                    r = (int)com.ExecuteScalar();
                    con.Close();
                    if (r == 1)
                    {
                        MessageBox.Show("Produto Inserido");
                        Select_Produto();
                    }
                    else
                    {
                        MessageBox.Show("Produto não Inserido");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Erro detectado: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    sql = @"SELECT * FROM pr_update (:id_,:n_,:p_,:d_)";
                    com = new NpgsqlCommand(sql, con);
                    com.Parameters.AddWithValue("id_", int.Parse(dgvProduto.Rows[pr_ri].Cells["id_"].Value.ToString()));
                    com.Parameters.AddWithValue("n_", txtpr_n.Text);
                    com.Parameters.AddWithValue("p_", long.Parse(txtpr_p.Text));
                    com.Parameters.AddWithValue("d_", txtpr_d.Text);

                    r = (int)com.ExecuteScalar();
                    con.Close();
                    if (r == 1)
                    {
                        MessageBox.Show("Produto Alterado");
                        Select_Produto();
                    }
                    else
                    {
                        MessageBox.Show("Produto não Inserido");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Erro detectado: " + ex.Message);
                }
            }
            pr_ri = -1;
            txtpr_n.Text = txtpr_p.Text = txtpr_d.Text = null;
            txtpr_n.Enabled = txtpr_p.Enabled = txtpr_d.Enabled = false;
            bp_delete.Enabled = bp_insert.Enabled = bp_update.Enabled = true;
            bp_save.Enabled = false;
        }

        private void bco_save_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (co_ri < 0)
            {
                try
                {
                    con.Open();
                    sql = @"SELECT * FROM co_insert(:_n,:_p,:_qu)";
                    com = new NpgsqlCommand(sql, con);
                    com.Parameters.AddWithValue("_n", fregues[cbco_n.SelectedIndex].getId());
                    com.Parameters.AddWithValue("_p", carrinho[cbco_p.SelectedIndex].getId());
                    com.Parameters.AddWithValue("_qu", int.Parse(txtco_q.Text));
                    r = (int)com.ExecuteScalar();
                    con.Close();
                    if (r == 1)
                    {
                        MessageBox.Show("Compra Realizada");
                        Select_Compra();
                    }
                    else
                    {
                        MessageBox.Show("Compra não Realizada");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Erro detectado: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    sql = @"SELECT * FROM co_update (:idc_,:idn_,:idp_,:q_)";
                    com = new NpgsqlCommand(sql, con);
                    com.Parameters.AddWithValue("idc_", int.Parse(dgvCompra.Rows[co_ri].Cells["id_"].Value.ToString()));
                    com.Parameters.AddWithValue("idn_", cbco_n.SelectedIndex);
                    com.Parameters.AddWithValue("idp_", cbco_p.SelectedIndex);
                    com.Parameters.AddWithValue("q_", int.Parse(txtco_q.Text));

                    r = (int)com.ExecuteScalar();
                    con.Close();
                    if (r == 1)
                    {
                        MessageBox.Show("Compra Alterada");
                        Select_Produto();
                    }
                    else
                    {
                        MessageBox.Show("Compra não Alterada");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Erro detectado: " + ex.Message);
                }
            }
            co_ri = -1;
            cbco_n.Text = cbco_p.Text = txtco_q.Text = null;
            cbco_n.Enabled = cbco_p.Enabled = txtco_q.Enabled = false;
            bco_delete.Enabled = bco_insert.Enabled = bco_update.Enabled = true;
            bco_save.Enabled = false;
        }

        private void bcl_delete_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (cl_ri < 0)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }
            try
            {
                con.Open();
                sql = @"SELECT * FROM cl_delete(:id_)";
                com = new NpgsqlCommand(sql, con);
                com.Parameters.AddWithValue("id_", int.Parse(dgvCliente.Rows[cl_ri].Cells["id_"].Value.ToString()));
                r = (int)com.ExecuteScalar();
                con.Close();
                if (r == 1)
                {
                    MessageBox.Show("Cliente deletado");
                    txtcl_n.Text = txtcl_s.Text = null;
                    Select_Cliente();
                    Select_Compra();

                }
                else
                {
                    MessageBox.Show("Não foi possível deletar cliente");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Erro detectado: " + ex.Message);
            }

        }

        private void bp_delete_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (pr_ri < 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }
            try
            {
                con.Open();
                sql = @"SELECT * FROM pr_delete(:id_)";
                com = new NpgsqlCommand(sql, con);
                com.Parameters.AddWithValue("id_", int.Parse(dgvProduto.Rows[pr_ri].Cells["id_"].Value.ToString()));
                r = (int)com.ExecuteScalar();
                con.Close();
                if (r == 1)
                {
                    MessageBox.Show("Produto deletado");
                    txtpr_n.Text = txtpr_p.Text = txtpr_d.Text = null;
                    Select_Produto();
                    Select_Compra();

                }
                else
                {
                    MessageBox.Show("Não foi possível deletar produto");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Erro detectado: " + ex.Message);
            }
        }

        private void bco_delete_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (co_ri < 0)
            {
                MessageBox.Show("Selecione uma compra");
                return;
            }
            try
            {
                con.Open();
                sql = @"SELECT * FROM co_delete(:id_)";
                com = new NpgsqlCommand(sql, con);
                com.Parameters.AddWithValue("id_", int.Parse(dgvCompra.Rows[co_ri].Cells["id_"].Value.ToString()));
                r = (int)com.ExecuteScalar();
                con.Close();
                if (r == 1)
                {
                    MessageBox.Show("Compra deletada");
                    cbco_n.Text = cbco_p.Text = txtco_q.Text = null;
                    Select_Compra();

                }
                else
                {
                    MessageBox.Show("Não foi possível deletar compra");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Erro detectado: " + ex.Message);
            }
        }
    }
}
