using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastro.Models
{
  [Table("clientes")]
  public class Cliente
  {
    [Key] // definir que é primary key
    [Column("ID")] // nome da coluna
    public int Id { get; set; }

    [Column("Nome")]
    [MaxLength(150)] // tamanho do campo
    [Required(ErrorMessage = "O nome é obrigatório")] // deixa o campo obrigatorio no backand (mensagem especifica no back)
    public string Nome { get; set; }

    [Column("Telefone")]
    [MaxLength(17)]
    public string Telefone { get; set; }

    [Column("Email", TypeName = "varchar(155)")]
    public string Email { get; set; }
  }
}
