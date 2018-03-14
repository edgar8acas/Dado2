using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado2
{
    class Dado
    {
        private Random _generador;

        public Dado()
        {
            _generador = new Random(DateTime.Now.Millisecond);
        }

        public int Lanzar()
        {
            return _generador.Next(1, 7);
        }
    }
}
