using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public class Spieltag
    {
        [Key]
        public Guid SpieltagGuid { get; set; }
       
        public string Season { get; set; }
        public Guid LigaGuid { get; set; }
        public int Spieltagzahl { get; set; }
    }
}
