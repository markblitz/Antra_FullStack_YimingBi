using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Entity;
using CRMApp.Core.Model;
using CRMApp.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Infrastructure.Repository
{
    public class AccountRepositoryAsync : BaseRepositoryAsync<SignUpModel>, IAccountRepositoryAsync
    {
        private readonly UserManager<User> userManager;
        public AccountRepositoryAsync(CrmDBContext _dbContext,
            UserManager<User> userManager) : base(_dbContext)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            User user = new User();
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.Email;
            return await userManager.CreateAsync(user, model.Password);
        }
    }
}
