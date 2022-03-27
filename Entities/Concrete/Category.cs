﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        
     
    }
}