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
  public class ContasController : Controller
  {

    private readonly ContextoDb context;

    public ContasController(ContextoDb context)
    {
      this.context = context;
    }

    [Route("/cadastroconta")]
    public IActionResult Cadastro()
    {
      ViewBag.Clientes = context.Clientes.ToList();
      return View();
    }

    [Route("/cadastrarconta")]
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
      return Redirect("/listacontas");
    }

    [Route("/listacontas")]
    public IActionResult Lista()
    {
      ViewBag.Contas = context.Contas.Include("Cliente").ToList();
      return View();
    }

    [Route("/conta/{id}/excluir")]
    public IActionResult Excluir(int id)
    {
      var conta = context.Contas.Find(id);
      if (conta == null)
      {
        return Redirect("/listacontas");
      }
      context.Contas.Remove(conta);
      context.SaveChanges();
      return Redirect("/listacontas");
    }

    [Route("/conta/{id}")]
    public IActionResult Editar(int id)
    {

      var conta = context.Contas.Find(id);
      if (conta == null) return Redirect("/listacontas");
      ViewBag.Conta = conta;
      ViewBag.Clientes = context.Clientes.ToList();
      return View();
    }

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
