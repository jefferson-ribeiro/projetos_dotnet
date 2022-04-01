using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace cadastro
{
  public class Program
  {
    internal static List<Cliente> Clientes = new List<Cliente>();
    public static void Main(string[] args)
    {
      /*&try
      {
        string json = System.IO.File.ReadAllText(@"D:\Users\Jefferson\clientes.txt");
        Program.Clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
      }
      catch
      {
      }*/
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
