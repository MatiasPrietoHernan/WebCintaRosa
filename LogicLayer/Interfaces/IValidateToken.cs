﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface IValidateToken
    {
        bool ValidateJwtToken(string token);
    }
}
