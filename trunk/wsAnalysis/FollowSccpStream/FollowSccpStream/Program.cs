﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Data.Linq;

namespace FollowSccpStream
{
    class Program
    {
        static void Main(string[] args)
        { 
            common.messagelist = common.mydb.LA_update.Where(e=>e.PacketNum<10000).Take(10000).ToDictionary(e => e.PacketNum);
            FollowStream fs = new FollowStream();
            fs.FollowSccpStream(common.messagelist);
        }
    }
}
 