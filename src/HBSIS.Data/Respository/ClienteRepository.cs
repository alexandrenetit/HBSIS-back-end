using System.Linq;
using HBSIS.Data.Context;
using HBSIS.Domain.Entities;
using HBSIS.Domain.Interfaces.Repository;

namespace HBSIS.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DataContext context) : base(context)
        {
        }

        public Cliente ObterPorCpfCnpj(string cpfCnpj)
        {
            return Buscar(c => c.CpfCnpj == cpfCnpj).FirstOrDefault();
        }
    }
}
