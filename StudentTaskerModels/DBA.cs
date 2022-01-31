using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskerModels
{
    public class DBA
    {
        [Key]
        public int DbaId { get; set; }
        [Display(Name = "DBA Subject")]
        public string SubjectName
        {
            get
            {
                return this.SubjectTypeForDba.ToString();
            }
            set
            {
                SubjectTypeForDba = (SubjectTypeForDba)Enum.Parse(typeof(SubjectTypeForDba), value, true);
            }
        }
        [Display(Name = "DBA Module")]
        public string DbaModule { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; } = DateTime.Now;
        [Display(Name = "Date of Dba")]
        public DateTime DateOfDba { get; set; }
        [Display(Name = "Time of DBA")]
        public DateTime TimeofDba { get; set; }
        [Display(Name = "Is Completed?")]
        public bool IsCompleted { get; set; }
        [NotMapped]
        [Display(Name = "Subject")]
        public SubjectTypeForDba SubjectTypeForDba { get; set; }
    }

     public enum SubjectTypeForDba
    {
        Science = 0,
        English = 1,
        Math = 2,
        History = 3
    }
}
