
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;




namespace crud_fase3
{
    class Conexion
    {

        public static MySqlConnection conexion(){

            string servidor = "localhost";
            string bd = "audio_eventos";
            string usuario = "samuelortiz";
            string password = "smamu1/C";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; userID= " + usuario+"; Password="+password+"";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }

            catch (MySqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return null;
            }
            
            
            }
                
            
            
            }
        }
    

