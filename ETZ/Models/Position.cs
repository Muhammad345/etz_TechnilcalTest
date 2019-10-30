using System.ComponentModel.DataAnnotations;

namespace ETZ.Models
{
    public class Position
    {
        public Position()
        {

        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
