using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
using FindAHorseApiModel.ApiModel;
using FindAHorseRepository.Repository;

namespace FindAHorseBusiness.Business
{
    public class HorseBoxBusiness 
    {
        private HorseBoxRepository _horseBoxRepository=new HorseBoxRepository();
        public int AddHorseBox(TransporterApiModel transporter)
        {
            tblHorseBox horseBox = new tblHorseBox() {
                Age=transporter.Age,
                HasAccomodation=transporter.HasAccomodation,
                HasCameras=transporter.HasCameras,
                IsAirConditioned=transporter.IsAirConditioned,
                RampId=transporter.RampId,
                Tonnage=transporter.Tonnage,
                UserId=transporter.UserId
            };
            return _horseBoxRepository.AddHorseBox(horseBox,transporter.ImagePaths);
        }

        public List<tblHorseBox> GetAllHorseBoxes()
        {
            return _horseBoxRepository.GetAllHorseBoxes();
        }

        public List<tblHorseBox> GetHorseBoxesByBoxOwnerId(int boxOwnerId)
        {
            return _horseBoxRepository.GetHorseBoxesByBoxOwnerId(boxOwnerId);
        }

        public tblHorseBox GetHorseBoxesById(int id)
        {
            return _horseBoxRepository.GetHorseBoxesById(id);
        }
        public List<tblHorseBox> GetHorseBoxByAddress(string searchText)
        {
            return _horseBoxRepository.GetHorseBoxByAddress(searchText);
        }
        public tblHorseBox GetTransporterDetails(int id) {
            return _horseBoxRepository.GetTransporterDetails(id);
        }
    }
}
