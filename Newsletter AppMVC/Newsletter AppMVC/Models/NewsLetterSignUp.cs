﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newsletter_AppMVC.Models
{
    public class NewsletterSignUp
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}