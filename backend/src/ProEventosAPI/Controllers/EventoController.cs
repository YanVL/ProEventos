﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventosAPI.Data;
using ProEventosAPI.Models;

namespace ProEventosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id
                );
        }

        [HttpPost]
        public string Post()
        {
            return "Olá mundo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Olá mundo Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Olá mundo Delete {id}";
        }
    }
}
