﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _12th_Sep2018
{
    static public class WriteToLog
    {
        static public void WriteToLogs(Exception e)
        {
            string Error1 = "-- " + DateTime.Now + " : " + e.StackTrace + Environment.NewLine+ Environment.NewLine+ Environment.NewLine;
            string Path = @"D:\logs1.txt";
            //var myfile = File.Create(path);
            
            Console.WriteLine("Exists :"+ File.Exists(Path));
            //            Console.WriteLine("Exists :" + File.GetAccessControl(path).);
            //myfile.Close();
            //File.OpenWrite(Path);
            File.AppendAllText(Path,Error1);
            //myfile.Close();
            
            
        }
    }
}
