using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MonitoringOfStudentProgress.Models
{
    public class TeachersModel
    {
        public string Id { get; set; }

        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Превышено допустимое количество символов, либо неподходящий тип данных")]
        public string Mail { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Превышено допустимое количество символов")]
        public string Specialization { get; set; }
    }
}
