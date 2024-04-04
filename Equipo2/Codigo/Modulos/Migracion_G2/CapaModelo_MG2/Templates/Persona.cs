using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MG2.Templates
{
    public class Persona
    {
        public int per_id;
        public string per_primer_nombre;
        public string per_segundo_nombre;
        public string per_primer_apellido;
        public string per_segundo_apellido;
        public DateTime per_fecha_nacimiento;
        public string per_no_doc;
        public int per_sexo;
        public string per_nacionalidad;
        public int per_id_estado_civil;
        public int per_id_pais;
        public string per_departamento;
        public string per_municipio;
        public string per_celular;
        public string per_telefono;
        public string per_correo;
        public double per_altura;
        public string per_tez;
        public string per_ojos;
        public string per_ocupacion;
        public Persona()
        {

        }
        public Persona(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string noDocumento, int sexo, string nacionalidad, int idEstadoCivil)
        {
            per_id = id;
            per_primer_nombre = primerNombre;
            per_segundo_nombre = segundoNombre;
            per_primer_apellido = primerApellido;
            per_segundo_apellido = segundoApellido;
            per_fecha_nacimiento = fechaNacimiento;
            per_no_doc = noDocumento;
            per_sexo = sexo;
            per_nacionalidad = nacionalidad;
            per_id_estado_civil = idEstadoCivil;
        }
        public void setData(int idPais, string departamento, string municipio, string celular, string telefono, string correo, double altura, string tez, string ojos, string ocupacion)
        {
            per_id_pais = idPais;
            per_departamento = departamento;
            per_municipio = municipio;
            per_celular = celular;
            per_telefono = telefono;
            per_correo = correo;
            per_altura = altura;
            per_tez = tez;
            per_ojos = ojos;
            per_ocupacion = ocupacion;
        }
    }
}
