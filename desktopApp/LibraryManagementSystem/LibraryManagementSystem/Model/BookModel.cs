using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
  public  class BookModel
    {
      public  int Id { set; get; }
      public string Title { set; get; }
      public string SubjectCode { set; get; }
      public string Author { set; get; }
      public string Publisher { set; get; }
      public string RackNo { set; get; }
      public string Price { set; get; }
    }
}
