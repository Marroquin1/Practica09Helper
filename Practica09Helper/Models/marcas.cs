using System.ComponentModel.DataAnnotations;
namespace Practica09Helper.Models
{
    public class marcas
    {

        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }
        [Display(Name = "Nombre de la marca")]

        public string? nombre_marcas { get; set; }
        [Display(Name = "Estado")]

        public string? estado { get; set; }
    }
}
