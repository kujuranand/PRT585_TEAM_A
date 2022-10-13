using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class UnitDto
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }


    }

    public static class UnitDtoMapExtensions
    {
        public static UnitDto ToUnitDto(this UnitModel src)
        {
            var dst = new UnitDto();
            dst.id = src.id;
            dst.code = src.code;
            dst.name = src.name;
            return dst;
        }

        public static UnitModel ToUnitModel(this UnitDto src)
        {
            var dst = new UnitModel();
            dst.id = src.id;
            dst.code = src.code;
            dst.name = src.name;
            return dst;
        }
    }
}
