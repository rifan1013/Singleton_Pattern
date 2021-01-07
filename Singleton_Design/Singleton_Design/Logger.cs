﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns._11Sigleton
{
   public class Logger
    {
        //private static Logger logger;
        private static Logger instance;
        private Logger()
        {

        }
        public static Logger Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

       // public static Logger GetInstance()
       // {
         //   if (logger == null)
           // {
             //   logger = new Logger();
            //}
            //return logger;
        //}
    }
}
