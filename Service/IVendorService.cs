using APBD_TEST_TEMPLATE.DTos;

namespace APBD_TEST_TEMPLATE.Service;

public interface IVendorService
{
    Task<VendorProductResponse> GetVendorproducts(int code);
}