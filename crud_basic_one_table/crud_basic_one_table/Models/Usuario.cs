using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_basic_one_table.Models {

    [Table("Usuarios")]
    public class Usuario {

        [Key] 
        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }


        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name ="Digite seu nome:")]
        [Column("Nome")]
        public string Nome { get; set; }
    }
}
