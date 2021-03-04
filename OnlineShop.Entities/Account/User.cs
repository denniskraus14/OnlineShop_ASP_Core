﻿using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Entities.Account {
    public class User : IdentityUser {

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
