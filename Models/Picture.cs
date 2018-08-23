using System;
using System.Collections.Generic;
using System.Text;

namespace Models {
  class Picture
  {
    public string _id { get; set; }
    public string name { get; set; }
    public string hash { get; set; }
    public string ext { get; set; }
    public string mime { get; set; }
    public double size { get; set; }
    public string url  { get; set; }
    public string provider { get; set; }
    public string[] related { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public int __v { get; set; }
    public string id { get; set; }
  }
}
