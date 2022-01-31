using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskerModels
{
    public class StudentTask
    {
        [Key]
        [Editable(false)]
        public int TaskId { get; set; }
        [Display(Name ="Subject")]
        public string SubjectName {
            get 
            {
                return this.SubjectType.ToString();
            }
            set 
            {
                SubjectType = (SubjectType)Enum.Parse(typeof(SubjectType), value, true);
            }
        }
        [Display(Name = "Task No.")]
        [Required]
        [Range(1.0, Double.MaxValue, ErrorMessage = "The field must be greater than 1.")]
        public decimal TaskNumber { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Display(Name = "Date Completed")]
        public DateTime? DateCompleted { get; set; }
        [Display(Name = "Complete Status")]
        public bool IsCompleted { get; set; }
        [NotMapped]
        [Display(Name = "Subject")]
        public SubjectType SubjectType { get; set; }
    }


    public enum SubjectType
    {
        Science = 0,
        English = 1,
        Math = 2,
        History = 3
    }
}
