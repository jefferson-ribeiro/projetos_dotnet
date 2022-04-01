using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cadastro.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace cadastro.Controllers
{
  public class ContasApiController : ControllerBase
  {

    private readonly ContextoDb context;

    public ContasApiController(ContextoDb context)
    {
      this.context = context;
    }

    [Route("api/conta/cadastrar")]
    [HttpPost]
    public IActionResult Cadastro(int agencia, int tipo, double saldo, int ClienteID)
    {
      Conta conta = new Conta();

      conta.Agencia = agencia;
      conta.Tipo = tipo;
      conta.Saldo = saldo;
      conta.ClienteID = ClienteID;

      context.Contas.Add(conta);
      context.SaveChanges();
      //Criar a instancia do objeto cliente e preencher as propriedades
      return StatusCode(200, conta);
    }

    [Route("api/listacontas")]
    public IActionResult Lista()
    {
      var contas = context.Contas.Include("Cliente").ToList();
      return StatusCode(201, contas);
    }

    [Route("/api/conta/{id}")]
    [HttpGet]
    public IActionResult Mostrar(int id)
    {
      var conta = context.Contas.Include("Cliente").Where(c => c.Id == id).First();
      if (conta == null)
      {
        return StatusCode(404);
      }
      return StatusCode(200, conta);
    }

    [Route("api/conta/{id}/excluir")]
    [HttpDelete]
    public IActionResult Excluir(int id)
    {
      var conta = context.Contas.Find(id);
      if (conta == null)
      {
        return StatusCode(404);
      }
      context.Contas.Remove(conta);
      context.SaveChanges();

      return StatusCode(204);
    }
    /*
        [Route("/conta/{id}")]
        public IActionResult Editar(int id)
        {

          var conta = context.Contas.Find(id);
          if (conta == null) return Redirect("/listacontas");
          ViewBag.Conta = conta;
          ViewBag.Clientes = context.Clientes.ToList();
          return View();
        }
    */
    [Route("/conta/{id}/atualizar")]
    [HttpPost]
    public IActionResult Atualizar(int id, int clienteId, int agencia, int tipo, double saldo)
    {
      var conta = context.Contas.Find(id);
      if (conta == null)
      {
        return Redirect("/listacontas");
      }
      conta.Agencia = agencia;
      conta.Tipo = tipo;
      conta.Saldo = saldo;
      conta.ClienteID = clienteId;
      context.Contas.Update(conta);
      context.SaveChanges();
      return Redirect("/listacontas");
    }
  }
}
