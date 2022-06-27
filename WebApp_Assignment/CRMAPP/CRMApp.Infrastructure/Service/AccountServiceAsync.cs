using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepositoryAsync accountRepositoryAsync;
        public AccountServiceAsync(IAccountRepositoryAsync AccountRepository)
        {
            accountRepositoryAsync = AccountRepository;
        }
        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            return await accountRepositoryAsync.SignUpAsync(model);
        }
    }
}
