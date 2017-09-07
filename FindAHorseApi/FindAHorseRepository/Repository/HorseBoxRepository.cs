using FindAHorseApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseRepository.Repository
{
    public class HorseBoxRepository: IHorseBoxRepository
    {
        private FindAHorseBoxDbEntities _db = new FindAHorseBoxDbEntities();
        public List<tblHorseBox> GetAllHorseBoxes()
        {
            return (from horseBoxes in _db.tblHorseBoxes select horseBoxes).ToList();
        }
        public tblHorseBox GetHorseBoxesById(int id)
        {
            return (from horseBox in _db.tblHorseBoxes where horseBox.HorseBoxId == id select horseBox).FirstOrDefault();
        }
        public List<tblHorseBox> GetHorseBoxesByBoxOwnerId(int boxOwnerId)
        {
            return (from horseBox in _db.tblHorseBoxes where horseBox.UserId == boxOwnerId select horseBox).ToList();
        }
        public int AddHorseBox(tblHorseBox horseBox)
        {
            _db.tblHorseBoxes.Add(horseBox);
            return (_db.SaveChanges());
        }
    }
}
