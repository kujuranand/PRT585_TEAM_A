using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class UnitDto
    {
        public int UnitId { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string UnitDiscipline { get; set; }
        public string UnitCreditPoints { get; set; }



    }

    public static class UnitDtoMapExtensions
    {
        public static UnitDto ToUnitDto(this UnitModel src)
        {
            var dst = new UnitDto();
            dst.UnitId = src.UnitId;
            dst.UnitCode = src.UnitCode;
            dst.UnitName = src.UnitName;
            dst.UnitDiscipline = src.UnitDiscipline;
            dst.UnitCreditPoints = src.UnitCreditPoints;
            return dst;
        }

        public static UnitModel ToUnitModel(this UnitDto src)
        {
            var dst = new UnitModel();
            dst.UnitId = src.UnitId;
            dst.UnitCode = src.UnitCode;
            dst.UnitName = src.UnitName;
            dst.UnitDiscipline = src.UnitDiscipline;
            dst.UnitCreditPoints = src.UnitCreditPoints;
            return dst;
        }
    }
}
