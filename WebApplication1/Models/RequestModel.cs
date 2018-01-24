using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    [DataContract]
    public class GetUserNameByPhoneNumberRequest
    {
        [DataMember]
        public string PhoneNumber { get; set; }
    }
}