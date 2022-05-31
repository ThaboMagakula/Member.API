using System;
using System.Collections.Generic;
using Member.Data.Model;

namespace Member.Data.Interface
{
    public interface IMembers
    {
        List<Model.Member> GetAllMember();
        Model.Member GetMember(int id);
    }
}

