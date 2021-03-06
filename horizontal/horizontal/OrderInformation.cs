﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horizontal
{
    public class OrderInformation
    {
        private String _item;
        private List<String> _users;
        private float _price;
        private List<String> _mods;
        private List<float> _modsPrice;
        private bool _isOrdered;

        public OrderInformation()
        {
            _users = new List<String>();
            _mods = new List<String>();
            _modsPrice = new List<float>();
        }

        public String item
        {
            get { return _item; }
            set { _item = value; }
        }

        public List<String> users
        {
            get { return _users; }
            set { _users = value; }
        }

        public float price
        {
            get { return _price; }
            set { _price = value; }
        }

        public List<String> mods
        {
            get { return _mods; }
            set { _mods = value; }
        }

        public List<float> modsPrice
        {
            get { return _modsPrice; }
            set { _modsPrice = value; }
        }

        public bool isOrdered
        {
            get { return _isOrdered; }
            set { _isOrdered = value; }
        }
    }
}
