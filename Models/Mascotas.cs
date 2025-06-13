  using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
 
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }


        [Required]
        public int RazaId { get; set; }

        [Required]
        public int RelacionSizeId { get; set; }

        [Required(ErrorMessage = "El tamaño es obligatorio.")]
        public string Tamaño { get; set; } = string.Empty;


        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La descricion es obligatoria.")]

        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La foto es obligatoria.")]

        public string FotoURL { get; set; } = string.Empty;

        [Required]
        public int EstadoId { get; set; }

        [ForeignKey("RazaId")]
        public Raza Raza { get; set; } = null!;

        [ForeignKey("RelacionSizeId")]
        public RelacionSize RelacionSize { get; set; } = null!;

        [ForeignKey("EstadoId")]
        public Estado Estado { get; set; } = null!;

    }

}
