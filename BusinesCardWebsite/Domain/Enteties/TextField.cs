using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel.DataAnnotations;

namespace BusinesCardWebsite.Domain.Enteties
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Название страници (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";
        [Display(Name = "Содержание страници")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
