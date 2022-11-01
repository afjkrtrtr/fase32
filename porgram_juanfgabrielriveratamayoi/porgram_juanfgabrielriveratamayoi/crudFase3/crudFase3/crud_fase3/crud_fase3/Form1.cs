using System.Net;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace crud_fase3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string soundURL = @"https://onedrive.live.com/download?cid=545A361126072FD2&resid=545A361126072FD2%218411&authkey=AA_412lehx8TTMc";

            pbBusqueda.LoadAsync(soundURL);
        }

        private void limpiar() {

            txtsound = "";
            txtentrevistado = "";
            txtentrevistador = "";
            txtPresidente de la reunion.Text = "";
            txtResumen del acta.Text = "";
            txtFecha.Text = "";
            txtLugar.Text = "";
            txtObjetivo.Text = "";
            txtURL.Text = "";

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

        private void label7_Click(object sender, EventArgs e)
        {
        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {  
            string imageUrl = "https://onedrive.live.com/download?cid=545A361126072FD2&resid=545A361126072FD2%218411&authkey=AA_412lehx8TTMc";
            string imageUrl2 = "@"+imageUrl;
            pbBusqueda.LoadAsync(imageUrl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string sound_url = txtsound.Text;
                string entrevistado = txtsound.Text;
                string entrevistador = txtsound.Text;
                string Presidentedelareunion = txtPresidentedelareunion.Text;
                string Resumendelacta = txtResumendelacta.Text;
                string Fecha = txtFecha.Text;
                string Lugar = txtLugar.Text;
                string Objetivo = txtObjetivo.Text;
                string txt_url = txttxt_url.Text;
                string imagen_url = txtURL.Text;
                
                if (sound_url != "" && entrevistado != "" && entrevistador != "" && Presidentedelareunion != "" && Resumendelacta != "" && Fecha != "" && Lugar != "" && Objetivo != "" && txt_url != "" && imagen_url != "")
                {


                    string sql = "INSERT INTO evento( sound_url, entrevistado, entrevistador, rresidenciadelareunion, resumendelacta, fecha, lugar, objetivo, txt_url, video_url) VALUES ('" +sound_url+ "','" +entrevistado+ "','" +entrevistador+ "','" +Presidentedelareunion+ "','" +Resumendelacta+ "','" +Fecha+ "','" +Lugar+ "','" +Objetivo+ "','" +txt_url+ "','" +imagen_url+ "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {


                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado con �xito");
                        limpiar();

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al guardar: " + ex.Message);

                    }
                    finally {


                        conexionBD.Close();                  
                    
                    }


            
                }




            }
            catch (FormatException fex)
            {

                MessageBox.Show("Datos Incorrectos: " + fex.Message);

            }


        }
    }
}