using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class HistorialAdopcion
    {
        [Key]
        public int HistorialId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un adoptante.")]
        public int AdoptanteId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una mascota.")]
        public int MascotaId { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha de adopción.")]
        public DateTime FechaAdopcion { get; set; } = DateTime.Now;

        public string Notas { get; set; } = string.Empty;

        [ForeignKey("AdoptanteId")]
        public Adoptante Adoptante { get; set; } = null!;

        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; } = null!;
    }
}
