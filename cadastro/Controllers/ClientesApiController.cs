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
  public class ClientesApiController : ControllerBase // herança
  {
    private readonly ContextoDb context;
    public ClientesApiController(ContextoDb context)
    {
      this.context = context;
    }

    [Route("/api/cliente/cadastrar")]
    [HttpPost]
    public IActionResult Cadastrar(string nome, string telefone, string email)
    {
      //Criar a instancia da classe
      Cliente cliente = new Cliente();

      cliente.Nome = nome;
      cliente.Telefone = telefone;
      cliente.Email = email;

      context.Clientes.Add(cliente);
      context.SaveChanges();
      /*
      Respostas de informação (100-199),
      Respostas de sucesso (200-299),
      Redirecionamentos (300-399)
      Erros do cliente (400-499)
      Erros do servidor (500-599).

      201 Created
      A requisição foi bem sucedida e um novo recurso foi criado como resultado. Esta é uma tipica resposta enviada após uma requisição POST.
      */
      return StatusCode(200, cliente);
    }

    [Route("api/clientes/lista")]
    public IActionResult Lista()
    {
      //Cria uma variavel para armazenar a lista
      var clientes = context.Clientes.ToList();

      return StatusCode(201, clientes);
    }

    [Route("/api/cliente/{id}/excluir")]
    [HttpDelete]
    public IActionResult Excluir(int id)
    {
      //Criar varialvel
      var cliente = context.Clientes.Find(id);
      //Criar condição no caso de nulo
      if (cliente == null)
      {
        return StatusCode(404);
      }
      //remove o id selecionado
      context.Clientes.Remove(cliente);
      //salva a exclusão
      context.SaveChanges();
      //retorna para lista
      return StatusCode(204);
    }

    [Route("api/cliente/{id}")]
    public IActionResult Editar(int id)
    {
      //Criar varialvel
      var cliente = context.Clientes.Find(id);
      //Criar condição no caso de nulo
      if (cliente == null)
      {
        return StatusCode(404);
      }
      return StatusCode(200, cliente);
    }

    [Route("api/cliente/{id}/atualizar")]
    [HttpPut]
    public IActionResult Atualizar(int id, string nome, string telefone, string email)
    {
      //Criar varialvel
      var cliente = context.Clientes.Find(id);
      //Criar condição no caso de nulo
      if (cliente == null)
      {
        return StatusCode(404);
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
      return StatusCode(200, cliente);
    }
  }
}
