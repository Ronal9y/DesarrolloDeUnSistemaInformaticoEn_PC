using System.ComponentModel.DataAnnotations;



namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class RelacionSize
    {
        [Key]
        public int RelacionSizeId { get; set; }

        [Required(ErrorMessage = "El nombre del tamaño obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        public ICollection<Mascota> Mascotas { get; set; }
    }
}
