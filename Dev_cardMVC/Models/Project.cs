﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_cardMVC.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project(int id, string name, string description, string image, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}
