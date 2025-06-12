using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{

    public class SolicitudAdopcion
    {
        [Key]
        public int SolicitudAdopcionId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un adoptante.")]
        public int AdoptanteId { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha de solicitud.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el estado de la solicitud.")]
        public int EstadoSolicitudId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una mascota.")]
        public int MascotaId { get; set; }

        [ForeignKey("AdoptanteId")]
        public Adoptante Adoptante { get; set; } = null!;

        [ForeignKey("EstadoSolicitudId")]
        public EstadoSolicitud EstadoSolicitud { get; set; } = null!;

        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; } = null!;
    }
}
