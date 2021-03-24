using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public class Tabellenplatz
    {
        [Key]
        public Guid Tabellenplatzguid { get; set; }

        public string Vereinsname { get; set; }

        public int Punktzahl { get; set; } = 0;

        public int Platzierung { get; set; }

        public int Matchanzahl { get; set; } = 0;

        public int Torverhältnis { get; set; } = 0;

        public int Tore_Insgesamt { get; set; } = 0;

        public int Gegentore { get; set; } = 0;
    }
}
