using APBD_TEST_TEMPLATE.DTos;
using APBD_TEST_TEMPLATE.Service;
using Microsoft.AspNetCore.Mvc;

namespace APBD_TEST_TEMPLATE.Controllers;



[ApiController ]
[Route("api/vendor")]
public class VendorController : ControllerBase
{

    private readonly IVendorService _service;
    
    public VendorController(IVendorService service)
    {
        _service = service;
    }
    
    [HttpGet("vendor/{code}")]
    public async Task<ActionResult> GetVendorProduct(int code)
    {
        var vendor = await _service.GetVendorproducts(code);
        if (vendor == null)
        {
            return NotFound("Vendor Not Found");
        }
        
        
        
        return Ok(vendor);
        
    }





}