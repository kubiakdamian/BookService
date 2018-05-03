using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Status
    {
        private bool isBorrowed;

        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }

        public Status(bool isBorrowed)
        {
            this.IsBorrowed = isBorrowed;
        }

        public Status()
        {
        }
    }
}