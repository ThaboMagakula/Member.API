using System;
using System.Collections.Generic;
using System.Linq;
using Member.Data.Interface;
using Member.Data.Model;

namespace Member.Data.Repository
{
    public class MembersRepository : IMembers
    {
        List<Model.Member> lisMembers = new List<Model.Member>
        {
            new Model.Member{MemberId=1, FirstName="Kirtesh", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=3, FirstName="Dilip", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=4, FirstName="Atul", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=5, FirstName="Swati", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=6, FirstName="Rashmi", LastName="Shah", Address="Vadodara" },
        };
        public List<Model.Member> GetAllMember()
        {
            return lisMembers;
        }

        public Model.Member GetMember(int id)
        {
            return lisMembers.FirstOrDefault(x => x.MemberId == id);
        }
    }
}

