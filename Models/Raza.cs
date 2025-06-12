using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DesarrolloDeUnSistemaInformaticoEn_PC.Models
{
    public class Raza
    {
        [Key]
        public int RazaId { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }




    }
}
