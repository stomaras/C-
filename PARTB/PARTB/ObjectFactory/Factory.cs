﻿using PARTB.View.ErrorMessages;
using PARTB.View.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.ObjectFactory
{
    public static class Factory
    {
        public static PrintStudent CreatePrintStudent()
        {
            return new PrintStudent();
        }

        
    }
}
