using CRMApp.Core.Entity;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Repository
{
    public interface IAccountRepositoryAsync : IRepositoryAsync<SignUpModel>
    {
        Task<IdentityResult> SignUpAsync(SignUpModel model);
    }
}
