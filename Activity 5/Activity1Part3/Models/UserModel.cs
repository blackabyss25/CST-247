using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Services.Description;

namespace Activity1Part3.Models
{
    [DataContract]
    public class UserModel
    {
        public UserModel()
        {
            Username = "";
            Password = "";
        }
        public UserModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        [DataMember]
        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Username { get; set; }
        [DataMember]
        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Password { get; set; }

    }
}   