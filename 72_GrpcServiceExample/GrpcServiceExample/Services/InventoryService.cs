using Grpc.Core;
using Bookshop;

namespace GrpcServiceExample.Services
{
    public class InventoryService : Inventory.InventoryBase
    {
        private readonly ILogger<InventoryService> _logger;
        public InventoryService(ILogger<InventoryService> logger)
        {
            _logger = logger;
        }

        public override Task<GetBookListResponse> GetBookList(GetBookListRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Received request to: GetBookList");
            var response = new GetBookListResponse();
            response.Books.Add(new Book
            {
                Title = "The Hitchhiker's Guide to the Galaxy",
                Author = "Douglas Adams",
                PageCount = 42
            });
            response.Books.Add(new Book
            {
                Title = "The Lord of the Rings",
                Author = "J.R.R. Tolkien",
                PageCount = 1234
            });
            return Task.FromResult(response);
        }
    }
}
