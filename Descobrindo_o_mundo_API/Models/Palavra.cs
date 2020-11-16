using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Descobrindo_o_mundo_API.Models
{
    public class Palavra
    {
        #region Propriedades
        private int _id;
        private string _nome;
        private int _nivel;
        private Silaba silabas;
        private Componente componente;
        #endregion

        #region Properties
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Nivel { get => _nivel; set => _nivel = value; }
        public Silaba Silabas { get => silabas; set => silabas = value; }
        public Componente Componente { get => componente; set => componente = value; }
        #endregion

        public Palavra() { }

        public Palavra(int id, string nome, int nivel, Silaba silabas, Componente componente)
        {
            this.Id = id;
            this.Nome = nome;
            this.Nivel = nivel;
            this.Silabas = silabas;
            this.Componente = componente;
        }

        public Palavra buscar(int nivel)
        {
            descobrindo_mundoContext db = new descobrindo_mundoContext();
            TblPalavra tblPalavra = db.TblPalavra.OrderBy(x => Guid.NewGuid()).Take(5).Include(x => x.TblSilaba).First(x => x.NvPalavra == nivel);
            TblComponente tblComponente = db.TblComponente.First(x => x.IdPalavraComponente == tblPalavra.IdPalavra);
            Componente componente = new Componente(tblComponente.IdComponente,tblComponente.IdPalavraComponente,tblComponente.TpComponente,tblComponente.NmComponente,tblComponente.DscComponente,tblComponente.LocalizacaoComponente);
            Silaba silaba = new Silaba(tblPalavra.TblSilaba.IdSilaba, tblPalavra.TblSilaba.IdPalavraSilaba, tblPalavra.TblSilaba.SlbsCorretasSilaba, tblPalavra.TblSilaba.SlbsIncorretasSilaba);
            Palavra palavraRetorno = new Palavra(tblPalavra.IdPalavra, tblPalavra.NmPalavra, (int)tblPalavra.NvPalavra, silaba, componente);
            return palavraRetorno;
        }
    }
}
