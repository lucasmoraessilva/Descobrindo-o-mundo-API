using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Descobrindo_o_mundo_API.Models
{
    public class Silaba
    {
        public int id { get; set; }
        public int idPalavra { get; set; }
        public string silabasCorretas { get; set; }
        public string silabasIncorretas { get; set; }

        public Silaba() { }

        public Silaba(int id, int idPalavra, string silabasCorretas, string silabasIncorretas)
        {
            this.id = id;
            this.idPalavra = idPalavra;
            this.silabasCorretas = silabasCorretas;
            this.silabasIncorretas = silabasIncorretas;
        }
    }
}
