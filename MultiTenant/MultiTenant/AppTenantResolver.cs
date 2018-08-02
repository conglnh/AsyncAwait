using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MultiTenant.Models;
using SaasKit.Multitenancy;

namespace MultiTenant
{
    public class AppTenantResolver : ITenantResolver<AppTenant>
    {
        private readonly ApplicationDbContext _dbContext;

        public AppTenantResolver(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<TenantContext<AppTenant>> ResolveAsync(HttpContext context)
        {
            TenantContext<AppTenant> tenantContext = null;
            var hostName = context.Request.Host.Value.ToLower();

            var tenant = _dbContext.AppTenants.FirstOrDefault(
                t => t.Hostname.Equals(hostName));

            if (tenant != null)
            {
                tenantContext = new TenantContext<AppTenant>(tenant);
            }

            return Task.FromResult(tenantContext);
        }
    }
}
