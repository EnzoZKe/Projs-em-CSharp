using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Security;
using System;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class tarefaController : Controller
{
    //$ Instanciando um obj _tarefas que armazenará uma lista de tarefas;
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }

    //# [HttpGet] {opcional}
        public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //$ Adicionando o total de tarefas da lista e somando mais 1 para criar o ID;
        novaTarefa.ID = _tarefas.Count + 1;
        
        //$ Adicionando minha nova tarefa à minha lista;
        _tarefas.Add(novaTarefa);

        //$Redirecionando para a pag inicial;
        return RedirectToAction("Index");
    }
    
    public IActionResult Editar(int ID)
    {
        //$ Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.ID == ID);

        //$ Verificando se ela existe
        if (novaTarefa == null)
        {
            return NotFound();
        }

        //$ Enciando para a view a tarefa que queremos alterar;
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.ID == tarefaEditando.ID);
        if (tarefaEncontrada == null)
        {
            return NotFound();
        }

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
        tarefaEncontrada.Concluida = tarefaEditando.Concluida;
        return RedirectToAction("Index");
    }

        public IActionResult Deletar(int ID)
    {
        //$ Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.ID == ID);

        //$ Verificando se ela existe
        if (novaTarefa == null)
        {
            return NotFound();
        }

        //$ Enciando para a view a tarefa que queremos alterar;
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult DeletarConfirmado(int ID)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.ID == ID);
        if (tarefaEncontrada == null)
        {
            return NotFound();
        }

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");
    }

}