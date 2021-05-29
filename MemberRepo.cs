using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_todo_app
{
    public class MemberRepo
    {
        List<Member> members = new List<Member>()
        {
            new Member{Id=1, NameSurname="Yüzyüzeyken Konuşuruz"},
            new Member{Id=2, NameSurname="Mor Ve Ötesi"},
            new Member{Id=3, NameSurname="Adamlar"}
        };

        public List<Member> GetMembers()
        {
            return members;
        }

        public Member GetMemberById(int id)
        {
            return members.FirstOrDefault(i => i.Id == id);
        }
    }
}
