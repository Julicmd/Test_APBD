using System.ComponentModel.DataAnnotations;

namespace APBD_TEST_TEMPLATE.DTos;

public class VendorProductResponse
{
    [Required] public string Code { get; set; } = null!;
    public string MakerName { get; set; } = null!;
    public List<ProductResponse> Products { get; set; } = new();

}