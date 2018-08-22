using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public class Activity
  {
    public string _id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int Likes { get; set; }

    public int Dislikes { get; set; }

    //public string Picture { get; set; }

    public string createdAt { get; set; }

    public string updatedAt { get; set; }

    public string __V { get; set; }

    public string id { get; set; }
  }
}