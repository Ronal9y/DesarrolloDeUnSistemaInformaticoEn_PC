using System.ComponentModel.DataAnnotations;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class EstadoSolicitud
    {
        [Key]
        public int EstadoSolicitudId { get; set; }

        [Required(ErrorMessage = "El nombre del estado de la solicitud es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        public virtual ICollection<SolicitudAdopcion> Solicitudes { get; set; } = null!;
    }
}
