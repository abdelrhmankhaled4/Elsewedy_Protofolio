using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Elsewedy_Platform.Models;
using Elsewedy_Platform.Models.DTO;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;

namespace Elsewedy_Platform.repo_courses.Achivment_repo
{
    public class Im_Achivments : IAchivments
    {
        private readonly AppDbContext context;
        private readonly Cloudinary _cloudinary;

        
        public Im_Achivments(AppDbContext context, Cloudinary _cloudinary)
        {
            this.context = context;
            this._cloudinary = _cloudinary;
        }
        public bool add(Achivments_DTO_add x)
        {
            if (x.image != null)
            {
               

                using var stream = x.image.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(x.image.FileName, stream),
                    Folder = "dotnet_upload" 
                };
                var uploadResult =  _cloudinary.Upload(uploadParams);
                var ac = new Achivments
                {
                    description = x.description,
                    title = x.title,
                    imageUrl = uploadResult.SecureUrl.ToString()
                };
                context.Achivments.Add(ac);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public void delete(string title)
        {
            var x = context.Achivments.FirstOrDefault(x => x.title == title);
            if(x != null)
            {
                var deleteParams = new DelResParams()
                {
                    PublicIds = new List<string> { "dotnet_upload/tmglnsuegzhcsdx2hupw" },
                    Type = "upload",
                    ResourceType = ResourceType.Image
                };
                var result = _cloudinary.DeleteResources(deleteParams);
                context.Achivments.Remove(x);
                context.SaveChanges();
            }
        }

        public List<Achivments_DTO_get> getall()
        {
            var x = context.Achivments.Select(x => new Achivments_DTO_get
            {
                imageUrl = x.imageUrl,
                description = x.description,
                title= x.title,
            }).ToList();
            return x;
        }
    }
}
