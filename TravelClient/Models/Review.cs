using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TravelClient.Models
{
  public class Review
  {
    public string Description { get; set; }
    public int Rating { get; set; }
    public int ReviewId { get; set; }
    public string City { get; set; }


    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.ApiCall();
      Console.WriteLine("apicalltask: " + apiCallTask);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      //JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      // Console.WriteLine("Result: " + result);
      Console.WriteLine("jsonResponse: " + jsonResponse);
      // List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse["results"].ToString());
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());
    //IEnumerable<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse["results"].ToString());
      return reviewList;
    }
  }
}