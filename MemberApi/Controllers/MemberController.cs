using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Member.Data.Interface;
using Member.Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemberApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMembers members = new MembersRepository();

        [Route("member")]
        [HttpGet]
        public ActionResult<IEnumerable<Member.Data.Model.Member>> GetAllMembers()
        {
            return members.GetAllMember();
        }

        [Route("memberbyId")]
        [HttpGet]
        public ActionResult<Member.Data.Model.Member> GetMemberById(int id)
        { 
            return members.GetMember(id);
        }
    }
}

