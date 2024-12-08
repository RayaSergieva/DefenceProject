using System.ComponentModel.DataAnnotations;

namespace LuminousStudio.Models.Lamp
{
    public class LampAllViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Type")]
        public string Type { get; set; } = null!;

        [Display(Name = "Lamp Pictures")]
        public string? Picture { get; set; }
    }
}
