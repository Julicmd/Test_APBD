using APBD_TEST_TEMPLATE.DTos;
using APBD_TEST_TEMPLATE.Repositories;

namespace APBD_TEST_TEMPLATE.Service;

public class VendorService: IVendorService
{
    private readonly IVendorRepository _repository;

    public VendorService(IVendorRepository repository)
    {
        _repository = repository;
    }

    public Task<VendorProductResponse> GetVendorproducts(int code)
    {
       return _repository.GetVendorproducts(code);
    }

    
}