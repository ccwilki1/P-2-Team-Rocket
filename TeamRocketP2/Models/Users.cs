﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Models
{
    public class Users
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private string _UserPass;
        public string UserPass
        {
            get { return _UserPass; }
            set { _UserPass = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {UserName}\nEmail: {Email}";
        }

    }
}