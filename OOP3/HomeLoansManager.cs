﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class HomeLoansManager : ICreditManager
    {
        public void Compute()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void Test()
        {

        }
    }
}
