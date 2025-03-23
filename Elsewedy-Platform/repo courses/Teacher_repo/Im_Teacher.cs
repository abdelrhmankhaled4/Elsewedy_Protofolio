using Elsewedy_Platform2.Models.DTO;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;

namespace Elsewedy_Platform2.repo_courses.Teacher_repo
{
    public class Im_Teacher : ITeacher
    {
        private readonly AppDbContext context;
        public Im_Teacher(AppDbContext context)
        {
            this.context = context;
        }
        public bool Login(Login_DTO_Teacher x)
        {
            var q = context.teachers.FirstOrDefault(z=>z.Name==x.Name && z.password==x.password);
            return q != null;
        }
    }
}
