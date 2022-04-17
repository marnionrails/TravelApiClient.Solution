using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("https://local:5003/api");
      Console.WriteLine("Client: " + client);
      RestRequest request = new RestRequest($"reviews", Method.GET);
      Console.WriteLine("Request: " + request);
      // RestRequest request = new RestRequest("", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}