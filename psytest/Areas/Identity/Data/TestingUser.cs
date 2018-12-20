﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace psytest.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TestingUser class
    public class TestingUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public string Occupation { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
