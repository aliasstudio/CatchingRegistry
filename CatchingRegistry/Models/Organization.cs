﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CatchingRegistry.Models
{
    public class Organization
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
