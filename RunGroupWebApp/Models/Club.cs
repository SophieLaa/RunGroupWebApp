using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGroupWebApp.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public string Image { get; set; }
        [ForeignKey("Address")]
        public int MyProperty { get; set; }

    }
}
