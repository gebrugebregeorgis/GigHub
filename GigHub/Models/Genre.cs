using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        /* Propriedade: Id - G�nero (definimos como tipo 'byte' porque a quantidade de g�neros
         * n�o ir� ultrapassar mais do que 255 */
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        /* Propriedade: Nome - G�nero */
        public string Name { get; set; }
    }
}