﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public interface UserCourse
    {
        IEnumerable<courses> Courses{ get; }

    }
}
