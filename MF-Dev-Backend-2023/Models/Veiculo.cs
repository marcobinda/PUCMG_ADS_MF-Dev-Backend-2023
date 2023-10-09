using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MF_Dev_Backend_2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo placa é obrigatório!")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "O campo ano de fabricação é obrigatório!")]
        [Display(Name ="Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "O campo ano do modelo é obrigatório!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
