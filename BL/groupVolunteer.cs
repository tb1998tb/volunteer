using BL.Convert;
using DAL;
using DTO;
namespace BL
{
   public class groupVolunteer
    {
        private static readonly Entities2 DB = new Entities2();
        public static groupVolunteeryDTO AddNewGroup(groupVolunteeryDTO groupVolunteeryDTO)
        {
            groupVolunteery groupVolunteer = groupVolunteeryConvertercs.groupVolunteery(groupVolunteeryDTO);

            DB.groupVolunteeries.Add(groupVolunteer);
            if(DB.SaveChanges()>0)
            { return groupVolunteeryConvertercs.groupVolunteeryDTO(groupVolunteer);}
            return null;
        }
    }
}
