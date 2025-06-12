using System.ComponentModel.DataAnnotations;

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class EstadoMascota
    {
        [Key]
        public int EstadoMascotaId { get; set; }

        [Required(ErrorMessage = "El nombre del estado es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        public virtual ICollection<SeguimientoMascota> Seguimientos { get; set; } = null!;
    }
}
