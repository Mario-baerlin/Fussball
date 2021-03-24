using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public class Verein
    {
        [Key]
        public Guid VereinGuid { get; set; }

        public string VereinName { get; set; }

        public Guid LigaGuid { get; set; }

        public string LigaName { get; set; }

        public string active { get; set; } = "true";
    }
}
