﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18.Interfaces
{
    public interface IPerson
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
    }
}
