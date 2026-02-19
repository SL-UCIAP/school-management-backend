 
using Microsoft.AspNetCore.Mvc;
using school_management_service.Application.DTOs.Certificate.Request;
using school_management_service.Application.DTOs.Certificate.Response;
using school_management_service.Core.Interfaces.Services;
 
namespace school_management_service.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CertificateController(ICertificateService service) :ControllerBase
    {
        private readonly ICertificateService _service=service;

        [HttpPost]
        public async Task<ActionResult<CertificateResponse>> CreateCertificate([FromBody]CertificateCreateRequest  createRequest)
        {
            var certificate=await _service.CreateAsync(createRequest);
            return Ok(certificate);
        }
        [HttpPut("{CertificateNumber}")]
        public async Task<ActionResult<CertificateResponse>> UpdateCertificate(string certificateNumber,[FromBody]CertificateUpdateRequest updateRequest)
        {
            var certificate=await _service.UpdateAsync(certificateNumber,updateRequest);
            return Ok(certificate);
        }
        [HttpDelete("{CertificateNumber}")]
        public async Task<IActionResult>DeleteAsync(string certificateNumber)
        {
            await _service.DeleteAsync(certificateNumber);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCertificates()
        {
            var certificates=await _service.GetCertificatesAsync();
            return Ok(certificates);
        }
    }
}