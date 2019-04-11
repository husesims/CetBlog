using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBlog.ViewModels
{
    public class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FullName {get;set; }
        public  bool IsAdmin { get; set; }
    }
}
