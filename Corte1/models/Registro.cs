using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    public class Registro
    {
        private Persona[] personas;
        private int contador;

        public Registro()
        {
            personas = new Persona[30];
            contador = 0;
        }

        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
            }
            else
            {
                throw new InvalidOperationException("El registro está lleno.");
            }
        }

        public Persona[] ObtenerPersonas()
        {
            return personas.Take(contador).ToArray();
        }
    }
}

