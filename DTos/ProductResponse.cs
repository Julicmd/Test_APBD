using System.ComponentModel.DataAnnotations;

namespace APBD_TEST_TEMPLATE.DTos;

public class ProductResponse
{
    public int Id { get; set; }
    [Required]
    public string NameModel { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
    [Required]
    public decimal StickerPrice { get; set; }

}