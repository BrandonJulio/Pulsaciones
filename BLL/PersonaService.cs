using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public decimal CalcularPulsacion(string sexo, int edad) 
        {
            decimal Pulsacion = 0;
            if (sexo.ToUpper().Equals("F"))
            {
                Pulsacion = (220-edad)/10;
            }
            else if (sexo.ToUpper().Equals("M"))
            {
                Pulsacion = (210-edad)/10;
                
            }else
            {
                Pulsacion=0;
            }
            return Pulsacion;
        }
        public string Guardar(Persona persona)
        {
            try
            {
                personaRepository.Guardar(persona);
                return "Se guardó la Informarción satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error de Aplicacion:" + e.Message;
            }
        }
    }
}
