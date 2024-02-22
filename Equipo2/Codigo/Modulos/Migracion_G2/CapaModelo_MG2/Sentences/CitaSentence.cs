using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaModelo_MG2.Templates;

namespace CapaModelo_MG2.Sentences
{
    public class CitaSentence : Sentencias
    {
        public void update(Cita cita)
        {
            try
            {
                string query = "update cita set fecha_i='" + cita.fecha_i.ToString("yyyy/MM/dd") + "' where Corre_cita='" + cita.Corre_cita + "'";
                this.executerCommand(query);
                MessageBox.Show("Actualizado Correctamente");
            }
            catch (OdbcException e)
            {
                MessageBox.Show(e.Message);
            }
        }



        public int getDatesByDateTime(string fecha)
        {
            OdbcDataReader myresponse = this.getByParam("fecha_i", "", "cita", 1, "'" + fecha + "'", "");
            int count = 0;
            if (myresponse.HasRows)
            {
                while (myresponse.Read())
                {
                    count++;
                }
            }
            Console.WriteLine("Cantidad: " + count + " --" + fecha);
            return count;
        }

        public void saveCita(Persona persona)
        {
            try
            {
                string query = "insert into cita(Nombre, dpi, fecha_i)values('" + persona.per_primer_nombre + "', '" + persona.per_no_doc + "', '" + persona.per_fecha_nacimiento.ToString("yyyy/MM/dd").Replace("/", "-") + "');";
                this.executerCommand(query);
                MessageBox.Show("Insertado Correctamente");
            }
            catch (OdbcException e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
