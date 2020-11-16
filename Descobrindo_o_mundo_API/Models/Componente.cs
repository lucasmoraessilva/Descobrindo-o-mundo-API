using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Descobrindo_o_mundo_API.Models
{
    public class Componente
    {
        #region Propriedades
        private int id;
        private int idPalavra;
        private int tipo;
        private string nome;
        private string descricao;
        private string localizacao;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int IdPalavra { get => idPalavra; set => idPalavra = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        #endregion

        #region Componente
        public Componente() { }
        public Componente(int id, int idPalavra, int tipo, string nome, string descricao, string localizacao)
        {
            this.Id = id;
            this.IdPalavra = idPalavra;
            this.tipo = tipo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Localizacao = localizacao;
        }
        #endregion

    }
}
