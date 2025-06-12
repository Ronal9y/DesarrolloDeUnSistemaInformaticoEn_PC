namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SeguimientoMascota
    {
        [Key]
        public int SeguimientoId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una mascota.")]
        public int MascotaId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un adoptante.")]
        public int AdoptanteId { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha de visita.")]
        public DateTime FechaVisita { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el estado de la mascota.")]
        public int EstadoMascotaId { get; set; }

        public string Observaciones { get; set; }

        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; }

        [ForeignKey("AdoptanteId")]
        public Adoptante Adoptante { get; set; }

        [ForeignKey("EstadoMascotaId")]
        public EstadoMascota EstadoMascota { get; set; }
    }

}
