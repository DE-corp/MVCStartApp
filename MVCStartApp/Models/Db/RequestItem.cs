﻿using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MVCStartApp.Models.Db
{
    [Table("Requests")]
    public class RequestItem
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
    }
}
