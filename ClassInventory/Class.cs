﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    class Class
    {
        public string name;
        public int age;
        public string team;
        public string position;

        public Class(string _name, int _age, string _team, string _position)
        {
            name = _name;
            age = _age;
            team = _team;
            position = _position;
        }
    }
}
