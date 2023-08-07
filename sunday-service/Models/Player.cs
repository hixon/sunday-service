using System.ComponentModel.DataAnnotations.Schema;

namespace sunday_service.Models
{
    [Table("test_player")]
    public class Player
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public decimal startindex { get; set; }
        public decimal currindex { get; set; }
        public int typeid { get; set; }
        public bool active { get; set; }
        public DateTime createdt { get; set; }
    }
}
