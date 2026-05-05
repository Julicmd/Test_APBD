using APBD_TEST_TEMPLATE.DTos;

namespace APBD_TEST_TEMPLATE.Repositories;

public interface IVendorRepository
{
    Task<VendorProductResponse> GetVendorproducts(int code);
}