﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public interface IFibonacciService
    {
        long CalcularFibonacci(long i);
        
    }
}
