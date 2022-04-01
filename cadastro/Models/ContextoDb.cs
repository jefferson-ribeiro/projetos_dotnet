using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cadastro.Models
{
  public class ContextoDb : DbContext
  {
    public ContextoDb(DbContextOptions<ContextoDb> options) : base(options) { }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Conta> Contas { get; set; }
  }
}
