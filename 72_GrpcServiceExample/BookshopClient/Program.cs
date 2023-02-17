// See https://aka.ms/new-console-template for more information
using Bookshop;
using Grpc.Net.Client;

Console.WriteLine("Hello, World!");
// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5096");
var client = new Inventory.InventoryClient(channel);
var reply = await client.GetBookListAsync(new GetBookListRequest { });

Console.WriteLine("Greeting: " + reply.Books);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();//*/