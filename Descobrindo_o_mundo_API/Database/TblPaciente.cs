using System;
using System.Collections.Generic;

namespace Descobrindo_o_mundo_API
{
    public partial class TblPaciente
    {
        public TblPaciente()
        {
            TblPartida = new HashSet<TblPartida>();
        }

        public int IdPaciente { get; set; }
        public string DscNicknamePaciente { get; set; }
        public int IdUsuarioPaciente { get; set; }

        public virtual TblUsuario IdUsuarioPacienteNavigation { get; set; }
        public virtual ICollection<TblPartida> TblPartida { get; set; }

        public TblPaciente(string nick, int idUsuarioPaciente)
        {
            this.DscNicknamePaciente = nick;
            this.IdUsuarioPaciente = idUsuarioPaciente;
        }

        public TblPaciente(string nick)
        {
            this.DscNicknamePaciente = nick;
        }
    }
}
