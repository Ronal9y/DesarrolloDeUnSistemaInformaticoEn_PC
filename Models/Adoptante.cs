using System.ComponentModel.DataAnnotations;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class Adoptante
    {
        [Key]
        public int AdoptanteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La ocupacion es obligatoria.")]
        [StringLength(100, ErrorMessage = "La  ocupacion no puede exceder los 100 caracteres.")]

        public string Ocupacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Las preferencias son obligatorias.")]
        public string Preferencias { get; set; } = string.Empty;

        public virtual ICollection<SolicitudAdopcion> Solicitudes { get; set; } = null!;
        public virtual ICollection<HistorialAdopcion> HistorialAdopciones { get; set; } = null!;
        public virtual ICollection<SeguimientoMascota> Seguimientos { get; set; } = null!;

    }
}
