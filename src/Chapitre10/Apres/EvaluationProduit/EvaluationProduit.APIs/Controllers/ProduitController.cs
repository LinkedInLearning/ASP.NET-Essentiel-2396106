﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvaluationProduit.Domaines.Models;
using EvaluationProduit.Domaines.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EvaluationProduit.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        // GET: api/<ProduitController>
        [HttpGet]
        public IEnumerable<ProduitModel> Get()
        {
            return  _produitService.ProduitModels;
        }

        // GET api/<ProduitController>/5
        [HttpGet("{nom}")]
        public IActionResult Get(string nom)
        {
            var produitResultat = _produitService.ProduitModels.FirstOrDefault(p => p.Nom.Equals(nom));
            if (produitResultat == null )
                return NotFound();
            return Ok(produitResultat);
        }

        // POST api/<ProduitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProduitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProduitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
