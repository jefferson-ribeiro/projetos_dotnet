using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastro.Models
{
  [Table("contas")]
  public class Conta
  {
    [Key] // definir que é primary key
    [Column("ID")] // nome da coluna // Usado como numero da conta
    public int Id { get; set; }

    [Column("Agencia")]
    [Required(ErrorMessage = "A agência é obrigatoria")]
    public int Agencia { get; set; }

    [Column("Tipo")]
    public int Tipo { get; set; }
    public string TipoString()
    {
      if (this.Tipo == 0)
        return "Conta corrente";
      else if (this.Tipo == 1)
        return "Conta poupança";
      else
        return "Conta investimento";
    }

    [Column("Saldo")]
    public double Saldo { get; set; }

    [ForeignKey("ClienteID")]
    public Cliente Cliente { get; set; }
    public int ClienteID { get; set; }
  }
}
