using System.ComponentModel.DataAnnotations;

namespace PracticaExamenWeb2.Data
{
    public class Visita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }
    }
}
