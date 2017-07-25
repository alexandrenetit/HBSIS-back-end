using HBSIS.Domain.Interfaces.Service;
using HBSIS.Services.Api.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using HBSIS.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HBSIS.Services.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/clientes/")]
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClientesController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ClienteViewModel> Get()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteService.ObterTodos());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            return Json(_mapper.Map<ClienteViewModel>(_clienteService.ObterPorId(id)));
        }

        [HttpPost]
        [Route("novo")]
        public IActionResult Post([FromBody]ClienteViewModel clienteViewModel)
        {
            if (!ModelStateValida())
            {
                return BadRequest();
            }

            var clienteDomain = _mapper.Map<Cliente>(clienteViewModel);
            _clienteService.Adicionar(clienteDomain);

            return Json(_mapper.Map<ClienteViewModel>(clienteDomain));
        }

        [HttpPut]
        [Route("editar")]
        public IActionResult Put([FromBody]ClienteViewModel clienteViewModel)
        {
            if (!ModelStateValida())
            {
                return BadRequest();
            }

            var clienteDomain = _mapper.Map<Cliente>(clienteViewModel);
            _clienteService.Atualizar(clienteDomain);

            return Json(_mapper.Map<ClienteViewModel>(clienteDomain));
        }

        [HttpDelete]
        [Route("excluir/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _clienteService.Remover(id);

            return Ok(new
            {
                success = true
            });
        }

        private bool ModelStateValida()
        {
            if (ModelState.IsValid) return true;

            return false;
        }
    }
}