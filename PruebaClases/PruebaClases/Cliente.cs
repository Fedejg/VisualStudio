using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases
{
    class Cliente : Persona
    {
        private int IdCliente;

        public int IdCli
        {
            get { return IdCliente; }
            set { IdCliente = value; }
        }

    }
}
