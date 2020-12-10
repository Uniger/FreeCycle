﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models
{
    public abstract class BaseModel
    {
        [Key]
        public long Id { get; set; }
    }
}