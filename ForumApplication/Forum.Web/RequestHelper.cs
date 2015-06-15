using Forum.DataLayer.Business_Logic_Layer;
using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web;

namespace Forum.Web
{
    public static class RequestHelper
    {
        public static int? GetId(HttpRequest request)
        {
            int? Id = null;

            string string_id = request.QueryString["Id"];
            int int_Id;

            if (!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out int_Id))
            {
                Id = int_Id;
            }

            return Id;
        }
    }
}
