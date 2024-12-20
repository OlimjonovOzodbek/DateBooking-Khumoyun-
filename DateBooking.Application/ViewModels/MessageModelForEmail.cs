﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.ViewModels
{
    public class MessageModelForEmail
    {
        public required string Subject { get; set; }
        public required string Email { get; set; }
        public required string Message { get; set; }
    }
}
