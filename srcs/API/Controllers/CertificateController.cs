using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using school_management_service.srcs.Application.DTOs.Certificate.Request;
using school_management_service.srcs.Application.DTOs.Certificate.Response;
using school_management_service.srcs.Application.Services;
using school_management_service.srcs.Core.Entities;
using school_management_service.srcs.Core.Interfaces.Services;

namespace school_management_service.srcs.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CertificateController(ICertificateService service) :ControllerBase
    {
        public readonly ICertificateService _service=service;

        [HttpPost]
        public async Task<ActionResult<CertificateResponse>> CreateCertificate([FromBody]CertificateCreateRequest  createRequest)
        {
            var certificate=await _service.CreateAsync(createRequest);
            return Ok(certificate);
        }
    }
}