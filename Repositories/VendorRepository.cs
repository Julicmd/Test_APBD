using APBD_TEST_TEMPLATE.DTos;
using Microsoft.Data.SqlClient;

namespace APBD_TEST_TEMPLATE.Repositories;

public class VendorRepository : IVendorRepository
{
    private readonly string _connectionString;

    public VendorRepository(IConfiguration config)
    {
        _connectionString = config.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(" No connection string configured");
    }

    public async Task<VendorProductResponse> GetVendorproducts(int code)
    {
        await using var connection = new SqlConnection(_connectionString);
                await connection.OpenAsync();
                
                await using var command = new SqlCommand(
                    "SELECT * from VendorProducts where VendorProductCode = @code",connection);
                
                
                command.Parameters.AddWithValue("@code", code);
                
                await using var reader = await command.ExecuteReaderAsync();
                if (!await reader.ReadAsync())
                {
                    return null;
                }
                
                var ProductList = new Dictionary<int, ProductResponse>();
                

                return new VendorProductResponse
                {
                    Code = reader.GetString(0),
                    MakerName = reader.GetString(1),
                    Products = ProductList.Values.ToList()
                };
                    
                    
    }
}