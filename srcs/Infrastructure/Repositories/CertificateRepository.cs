using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school_management_service.src.Infrastructure.Data;
using school_management_service.srcs.Core.Entities;
using school_management_service.srcs.Core.Interfaces.Repositories;

namespace school_management_service.srcs.Infrastructure.Repositories
{
     public class CertificateRepository(AppDbContext context) :ICertificateRepository
    {
        public readonly AppDbContext _context=context;

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

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public Task<Certificate> UpdateAsync(Certificate certificate)
        {
            throw new NotImplementedException();
        }
    }
}