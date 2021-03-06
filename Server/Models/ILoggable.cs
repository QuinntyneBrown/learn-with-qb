﻿using System;

namespace LearnWithQB.Server.Models
{
    public interface ILoggable
    {
        DateTime? CreatedDate { get; set; }
        DateTime? LastModifiedDate { get; set; }
        string LastModifiedByUserName { get; set; }
        int? LastModifiedByUserId { get; set; }
    }
}
