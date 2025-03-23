using Elsewedy_Platform.Models.DTO;

namespace Elsewedy_Platform.repo_courses.Achivment_repo
{
    public interface IAchivments
    {
        public bool add(Achivments_DTO_add x);
        public List<Achivments_DTO_get> getall();
        public void delete(string title);
    }
}
