using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using school_management_service.srcs.Core.Entities;

namespace school_management_service.srcs.Core.Interfaces.Repositories
{
    public interface ICertificateRepository
    {
        Task<Certificate>CreateAsync(Certificate certificate);
        Task<List<Certificate>>GetAllAsync();
        Task<Certificate>UpdateAsync(Certificate certificate);
        Task DeleteAsync(Certificate certificate);
        Task SaveChangesAsync();

    }
}