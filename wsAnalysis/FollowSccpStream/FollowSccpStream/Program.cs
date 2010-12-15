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
            /*
            //common.messagelist = common.mydb.LA_update.Where(e=>e.PacketNum<10000).Take(10000).ToDictionary(e => e.PacketNum);
           common.messagelist = common.mydb.LA_update.Where(e => e.FileNum==0).ToDictionary(e => e.PacketNum);
            FollowStream fs = new FollowStream();
            fs.FollowSccpStream(common.messagelist);

            //执行其他的文件
            int? filenums = common.mydb.LA_update.Select(e => e.FileNum).Max();
            if (filenums == 0) return;
            for (int i = 0; i < filenums; i++)
            {
                common.messagelist = common.mydb.LA_update.Where(e => e.FileNum == i).ToDictionary(e => e.PacketNum);
                fs.FollowSccpStream(common.messagelist);
            }
             * */
            FollowStream fs = new FollowStream();
            var msgmax = common.mydb.LA_update.Select(e => e.FileNum).Count();
            var msg = common.mydb.LA_update;
            for (int i = 0; i < msgmax; i++)
                fs.FollowSccpStream(msg.Where(e => e.PacketNum == i).FirstOrDefault());

        }
    }
}
 