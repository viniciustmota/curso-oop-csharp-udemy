﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}
