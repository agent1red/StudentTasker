using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskerModels
{
    [NotMapped]
    public class MyPieChartModel
    {
        public string SegmentName { get; set; }
        public int Completed { get; set; }
        public string SegmentColor { get; set; }
        public bool? IsSeparated { get; set; }
    }
}
