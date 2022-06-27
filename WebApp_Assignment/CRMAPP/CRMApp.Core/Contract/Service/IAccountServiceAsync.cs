using CRMApp.Core.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface IAccountServiceAsync
    {
        Task<IdentityResult> SignUpAsync(SignUpModel model);
    }
}
