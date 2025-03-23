using Elsewedy_Platform.Models;
using Elsewedy_Platform.Models.DTO;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;

namespace Elsewedy_Platform.repo_courses.projects
{
    public class Im_Project_Information : IProject
    {
        private readonly AppDbContext context;
        public Im_Project_Information(AppDbContext context)
        {
            this.context = context;
        }
        public bool Add_Project(Project_Infromation_DTO_add x)
        {
            try
            {
                var project = new Porject_Information
                {
                    fName = x.f_name,
                    company_name = x.company_name,
                    email = x.email,
                    lname = x.l_name,
                    massege = x.massege,
                    phone = x.phone,
                    description = x.project_information,
                    status = "Pending",
                    date =  DateTime.Now,
                };
                context.porject_Information.Add(project);
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Project_Infromation_DTO_get> Get_All()
        {
            var list = context.porject_Information.Select(x=>new Project_Infromation_DTO_get
            {
                f_name = x.fName,
                company_name = x.company_name,
                email = x.email,
                l_name = x.lname,
                massege = x.massege,
                phone = x.phone,
                project_information = x.description,
                status  =x.status,
                date = x.date,
            }).ToList();
            return list;
        }

        public void update_statue(string email,string status)
        {
           var x = context.porject_Information.FirstOrDefault(x=>x.email==email);
           if(x != null)
           {
                x.status = status;
                context.porject_Information.Update(x);
                context.SaveChanges();
           }
        }
    }
}
