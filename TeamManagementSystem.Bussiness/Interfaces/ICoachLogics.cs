﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagementSystem.Bussiness.Props;

namespace TeamManagementSystem.Bussiness.Interfaces
{
    public interface ICoachLogics
    {
        List<CoachProps> GetCoachList();
        bool InsertUpdateCoachMaster(CoachProps pr);
        bool DeleteCoach(int ID);
        List<CoachProps> GetCoachListByID(int ID);
    }
}
