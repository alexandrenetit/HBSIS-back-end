using HBSIS.Domain.Entities;

namespace HBSIS.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCpfCnpj(string cpfCnpj);
    }
}