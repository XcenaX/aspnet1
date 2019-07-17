using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Producer(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}