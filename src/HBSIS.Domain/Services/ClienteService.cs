using System;
using System.Collections.Generic;
using System.Linq;
using HBSIS.Domain.Entities;
using HBSIS.Domain.Interfaces.Repository;
using HBSIS.Domain.Interfaces.Service;
using HBSIS.Domain.Interfaces.UoW;

namespace HBSIS.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ClienteService(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
            _unitOfWork.Commit();
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public Cliente ObterPorCpfCnpj(string cpfCnpj)
        {
            return _clienteRepository.ObterPorCpfCnpj(cpfCnpj);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos().OrderBy(c => c.Nome);
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
            _unitOfWork.Commit();
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}