using DataAccess.Repositories;
using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AUTOMAContext _repoContext;

        private IClientRepository _Client;
        public IClientRepository Client
        {
            get
            {
                if (_Client == null)
                {
                    _Client = new ClientRepository(_repoContext);
                }
                return _Client;
            }
        }

        public RepositoryWrapper(AUTOMAContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
