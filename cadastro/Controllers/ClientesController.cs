using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cadastro.Models;
using Newtonsoft.Json;

namespace cadastro.Controllers
{
  public class ClientesController : Controller
  {

    private readonly ContextoDb context;

    public ClientesController(ContextoDb context)
    {
      this.context = context;
    }

    [Route("/cadastro")]
    public IActionResult Cadastro()
    {
      return View();
    }

    [Route("/cadastrar")]
    [HttpPost]
    public IActionResult Cadastrar(string nome, string telefone, string email)
    {
      //Criar a instancia da classe
      Cliente cliente = new Cliente();

      cliente.Nome = nome;
      cliente.Telefone = telefone;
      cliente.Email = email;

      //Program.Clientes.Add(cliente);

      //Metodo para salvar no arquivo
      //string json = JsonConvert.SerializeObject(Program.Clientes);
      //System.IO.File.WriteAllText(@"D:\Users\Jefferson\clientes.txt", json);

      context.Clientes.Add(cliente);
      context.SaveChanges();

      //Criar a instancia do objeto cliente e preencher as propriedades
      return Redirect("/lista");
    }

    [Route("/lista")]
    public IActionResult Lista()
    {
      //ViewBag.Clientes = Program.Clientes;
      ViewBag.Clientes = context.Clientes.ToList();
      return View();
    }

    [Route("/cliente/{id}/excluir")]
    public IActionResult Excluir(int id)
    {
      //Criar varialvel
      var cliente = context.Clientes.Find(id);
      //Criar condição no caso de nulo
      if (cliente == null)
      {
        return Redirect("/lista");
      }
      //remove o id selecionado
      context.Clientes.Remove(cliente);
      //salva a exclusão
      context.SaveChanges();
      //retorna para lista
      return Redirect("/lista");
    }

    [Route("/cliente/{id}")]
    public IActionResult Editar(int id)
    {
      //Criar varialvel
      var cliente = context.Clientes.Find(id);
      //Criar condição no caso de nulo
      if (cliente == null)
      {
        return Redirect("/lista");
      }
      //coloca o cliente na viewbag
      ViewBag.Cliente = cliente;
      return View();
    }

    [Route("/cliente/{id}/atualizar")]
    [HttpPost]
    public IActionResult Atualizar(int id, string nome, string telefone, string email)
    {
      //Criar varialvel
      var cliente = context.Clientes.Find(id);
      //Criar condição no caso de nulo
      if (cliente == null)
      {
        return Redirect("/lista");
      }
      //atribui variaveis
      cliente.Nome = nome;
      cliente.Email = email;
      cliente.Telefone = telefone;
      //atualiza
      context.Clientes.Update(cliente);
      //salva a exclusão
      context.SaveChanges();
      //retorna para lista
      return Redirect("/lista");
    }
  }
}
