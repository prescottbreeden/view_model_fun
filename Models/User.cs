using System;
using System.Collections.Generic;

namespace view_model_fun.Models
{
    public class User
    {
      public string FirstName { get; set; } = "Bob";
      public string LastName { get; set; } = "Ross";
      public List<int> FavoriteNumbers { get; set; } = new List<int> 
      {
          1, 2, 3, 10, 43, 5
      };
      public List<string> BestFriends { get; set; } = new List<string>
      {
          "Sally", "Billy", "Joey", "Moose"
      };
    }
}