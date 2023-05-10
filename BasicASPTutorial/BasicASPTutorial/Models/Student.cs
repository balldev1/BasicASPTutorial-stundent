using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter student name")]
        [DisplayName("Name Student")]
        public string Name { get; set; }
        [DisplayName("Score")]
        [Range(0, 100,ErrorMessage ="Plese enter a score in the range 0-100")]
        public int Score { get; set; }
    }
}
