using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using school_management_service.src.Core.Entities;

namespace school_management_service.Core.Interfaces.Repositories
{
    public interface ICertificateRepository
    {
        Task<Certificate>CreateAsync(Certificate certificate);
        Task<List<Certificate>>GetAllAsync(); 
        Task DeleteAsync(Certificate certificate);
        Task<Certificate?>GetByCertificateNumberIdAsync(string certificateNumber);
        Task SaveChangesAsync();

    }
}