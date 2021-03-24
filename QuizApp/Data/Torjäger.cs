using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public class Torjäger
    {
        [Key]
        public Guid TorjägerGuid { get; set; }

        public Guid MatchGuid { get; set; }

        public string Saison { get; set; }

        public Guid LigaId { get; set; }

        public string Spielername { get; set; }

        public int Tore { get; set; }
    }
}
