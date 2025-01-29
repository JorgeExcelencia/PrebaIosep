﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telephone { get; set; }
        public string? ImagePath { get; set; }
    }
}
