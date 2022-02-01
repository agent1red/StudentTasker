using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskerModels
{
    [NotMapped]
    public class MyProgressBarModel
    {
        public int MaxValue { get; set; }
        public int PBValue { get; set; }
    }
}
