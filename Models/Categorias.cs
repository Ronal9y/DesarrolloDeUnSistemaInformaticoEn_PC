using System.ComponentModel.DataAnnotations;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }
        public ICollection<Mascota> Mascotas { get; set; }
        public ICollection<Raza> Razas { get; set; }

    }

}
