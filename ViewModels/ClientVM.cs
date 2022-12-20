using MasterDetailsEVidence.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetailsEVidence.ViewModels
{
    public class ClientVM
    {
        public ClientVM()
        {
            this.SpotList = new List<int>();
        }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        [Display(Name = "Birth Date"),DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public HttpPostedFileBase PictureFile { get; set; }
        public string Picture { get; set; }
        public bool MaritalStatus { get; set; }
        public List<int> SpotList { get; set; }
    }
}