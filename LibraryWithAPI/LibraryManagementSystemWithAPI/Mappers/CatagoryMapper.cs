using LibraryManagementSystemWithAPI.DTOs.Catagory;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.Mappers
{
    public static class CatagoryMapper
    {
        public static CatagoryDTO ToCatagoryDTO(this Category catagory)
        {
            return new CatagoryDTO
            {
                Name = catagory.Name,
            };
        }
    }
}