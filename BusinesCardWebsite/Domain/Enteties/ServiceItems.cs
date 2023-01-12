using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BusinesCardWebsite.Domain.Enteties
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название заметки")]
        [Display(Name = "Название заметки")]
        public override string Title { get; set; }
        [Display(Name = "Краткое описание заметки")]
        public override string Subtitle { get; set; }
        [Display(Name = "Полное содержание заметки")]
        public override string Text { get; set; }
    }
}
