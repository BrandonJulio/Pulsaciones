using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class PersonaRepository
    {
        private string fileName = "Persona.txt";

        public void Guardar(Persona persona) 
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsacion}");

            writer.Close();
            file.Close();
        }
        public void ConsultarTodos() { }
        public void Modificar() { }

        public void Eliminar() { }

        public void BuscarPorIdentificacion() { }
    }
}
