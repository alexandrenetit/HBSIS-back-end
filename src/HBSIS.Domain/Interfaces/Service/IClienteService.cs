using System;
using System.Collections.Generic;
using HBSIS.Domain.Entities;

namespace HBSIS.Domain.Interfaces.Service
{
    public interface IClienteService : IDisposable
    {
        void Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        Cliente ObterPorCpfCnpj(string cpf);
        IEnumerable<Cliente> ObterTodos();
        void Atualizar(Cliente cliente);
        void Remover(Guid id);
    }
}