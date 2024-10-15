using System.ComponentModel.DataAnnotations;

namespace StefamJativa_Semana4_Progrmacion4.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
    }
}
