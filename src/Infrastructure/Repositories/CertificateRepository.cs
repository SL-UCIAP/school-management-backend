using Microsoft.EntityFrameworkCore;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Infrastructure.Data;
using school_management_service.src.Core.Entities;


namespace school_management_service.Infrastructure.Repositories
{
     public class CertificateRepository(AppDbContext context) :ICertificateRepository
    {
        private readonly AppDbContext _context=context;

        public async Task<Certificate> CreateAsync(Certificate certificate)
        {
            _context.Certificates.Add(certificate);
            await _context.SaveChangesAsync();
            return certificate;
        }

        public async Task DeleteAsync(Certificate certificate)
        {
             _context.Certificates.Remove(certificate);
             await _context.SaveChangesAsync();
        }

        public async Task<List<Certificate>> GetAllAsync()
        {
            var certificate=await _context.Certificates.ToListAsync();
            return certificate;
        }

        public async Task<Certificate?> GetByCertificateNumberIdAsync(string certificateNumber)
        {
            return await _context.Certificates
             .FirstOrDefaultAsync(s => s.CertificateNumber == certificateNumber);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

 
    }
}