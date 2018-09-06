using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  class Activity
  {
    public Activity() {

    }

    public string _id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int Likes { get; set; }

    public int Dislikes { get; set; }

    public string createdAt { get; set; }

    public string updatedAt { get; set; }

    public int __v { get; set; }

    public string id { get; set; }

    //public Picture Picture { get; set; }
    public String Image { get; set; }
  }
}