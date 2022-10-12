using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class LecturerDto
    {
        public int LecturerId { get; set; }
        public string LecturerName { get; set; }
        public string LecturerOffice { get; set; }
        public string LecturerEmail { get; set; }
        public string LecturerPhone { get; set; }


    }

    public static class LecturerDtoMapExtensions
    {
        public static LecturerDto ToLecturerDto(this LecturerModel src)
        {
            var dst = new LecturerDto();
            dst.LecturerId = src.LecturerId;
            dst.LecturerName = src.LecturerName;
            dst.LecturerOffice = src.LecturerOffice;
            dst.LecturerEmail = src.LecturerEmail;
            dst.LecturerPhone = src.LecturerPhone;
            return dst;
        }

        public static LecturerModel ToLecturerModel(this LecturerDto src)
        {
            var dst = new LecturerModel();
            dst.LecturerId = src.LecturerId;
            dst.LecturerName = src.LecturerName;
            dst.LecturerOffice = src.LecturerOffice;
            dst.LecturerEmail = src.LecturerEmail;
            dst.LecturerPhone = src.LecturerPhone;
            return dst;
        }
    }
}
