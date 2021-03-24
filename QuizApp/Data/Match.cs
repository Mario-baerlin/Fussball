using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public class Match
    {
        public Match()
        {
            MatchGuid = Guid.NewGuid();
        }


        [Key]
        public Guid MatchGuid { get; set; }
        public string Mannschaft1 { get; set; }
        public string Mannschaf2 { get; set; }
        public int Tore_Mannschaft1 { get; set; } = 0;
        public int Tore_Mannschaft2 { get; set; } = 0;
        public DateTime Uhrzeit { get; set; }
        public Guid SpieltagGuid { get; set; }
        public Guid LigaId { get; set; }
        public string Season { get; set; }
        public DateTime Datum { get; set; }

        public Verein SelectedVerein { get; set; }
        public Verein SelectedVerein2 { get; set; }
    }
}
