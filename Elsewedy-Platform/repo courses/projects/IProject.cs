using Elsewedy_Platform.Models.DTO;

namespace Elsewedy_Platform.repo_courses.projects
{
    public interface IProject
    {
        public bool Add_Project(Project_Infromation_DTO_add x);
        public List<Project_Infromation_DTO_get> Get_All();
        public void update_statue(string email,string status);

    }
}
