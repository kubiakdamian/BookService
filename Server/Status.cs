using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Status
    {
        private bool isBorrowed;

        public Status(bool isBorrowed)
        {
            this.isBorrowed = isBorrowed;
        }

        public Status()
        {
        }
    }
}