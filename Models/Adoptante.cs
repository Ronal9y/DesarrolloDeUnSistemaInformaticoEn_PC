using System.ComponentModel.DataAnnotations;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class Adoptante
    {
        [Key]
        public int AdoptanteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La ocupacion es obligatoria.")]
        [StringLength(100, ErrorMessage = "La  ocupacion no puede exceder los 100 caracteres.")]

        public string Ocupacion { get; set; }

        [Required(ErrorMessage = "Las preferencias son obligatorias.")]
        public string Preferencias { get; set; }



        public ICollection<SolicitudAdopcion> Solicitudes { get; set; }
        public ICollection<HistorialAdopcion> HistorialAdopciones { get; set; }
        public ICollection<SeguimientoMascota> Seguimientos { get; set; }


    }
}
