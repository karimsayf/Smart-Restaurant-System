using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Ordering_Food.Models
{
    [MetadataType(typeof(UserInfoMetadata))]
    public partial class UserInfo
    {
        //add
        public string ConfirmPassword { get; set; }
    }

    public class UserInfoMetadata
    {
        //edit
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}