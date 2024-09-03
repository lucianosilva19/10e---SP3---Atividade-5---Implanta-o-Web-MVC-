using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using System.ComponentModel.Design;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "João Maria Netto", "666.696.969-69", "joao.maria@netto.com", "Perdigudo");
        Cliente cliente2 = new Cliente(02, "Maria Delfina de Moraes", "777.797.979-79", "maria.delfina@microsoft.com", "Guidda");
        Cliente cliente3 = new Cliente(03, "Nattanael Bonfim dos Santos", "888.898.989-89", "bonfim.santos@sp.senai.br", "Faleiro");
        Cliente cliente4 = new Cliente(04, "Brida Assunção Fernandes", "999.989.868-98", "brida.fernandes@df.senai.br", "Matilda");
        Cliente cliente5 = new Cliente(05, "José Clovis Silva", "555.595.959-59", "ze.clovis@df.senai.br", "Kurisco");
        
        // lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        // instancias do tipo fornecedor

        Fornecedor fornecedor1 = new Fornecedor(01, "Tech Soluções Ltda", "11.222.333/0001-33", "tech.solucao@tech.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Boa Vista Tecnologia", "22.333.444/0001-44", "bv.tecno@bv.tecno.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "DVO Tecnologia da Informação", "33.444.555/0001-55", "dvo.ti@dvo.ti.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "TWL Consoles Ltda", "44.555.666/0001-66", "consoles@twl.consoles.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Vinil Techno Solution", "55.666.777/0001-77", "vinil.solution@techno.com");
       
       // lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5); 

        ViewBag.listaFornecedores = listaFornecedores;
       
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
