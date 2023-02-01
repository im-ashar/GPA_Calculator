using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace BLL
{
    public class GpaBLL
    {
        public void MarksToGrade(List<GpaDTO> studentsList)
        {
            List<GpaDTO> newList = new List<GpaDTO>();
            foreach (GpaDTO dto in studentsList)
            {
                if (dto.Marks >= 85)
                {
                    dto.Grade = "A";
                }
                else if (dto.Marks >= 80 && dto.Marks <= 84)
                {
                    dto.Grade = "B";
                }
                else if (dto.Marks >= 75 && dto.Marks <= 79)
                {
                    dto.Grade = "C";
                }
                else if (dto.Marks >= 70 && dto.Marks <= 74)
                {
                    dto.Grade = "D";
                }
                else if (dto.Marks >= 65 && dto.Marks <= 69)
                {
                    dto.Grade = "E";
                }
                else if (dto.Marks < 60)
                {
                    dto.Grade = "F";
                }
                newList.Add(dto);
            }
                GpaDAL dal = new GpaDAL();
                dal.SerializeObjects(newList);


        }
        public List<GpaDTO> GradeToGpa()
        {
            GpaDAL dal = new GpaDAL();
            List<GpaDTO> newList = dal.DeSerializedObjects();
            List<GpaDTO> newList2 = new List<GpaDTO>();
            foreach (GpaDTO dto in newList)
            {
                if (dto.Grade == "A")
                {
                    dto.Gpa = 4;
                }
                else if (dto.Grade == "B")
                {
                    dto.Gpa = 3.7;
                }
                else if (dto.Grade == "C")
                {
                    dto.Gpa = 3.5;
                }
                else if (dto.Grade == "D")
                {
                    dto.Gpa = 3.3;
                }
                else if (dto.Grade == "E")
                {
                    dto.Gpa = 3.0;
                }
                else if (dto.Grade == "F")
                {
                    dto.Gpa = 2.7;
                }
                newList2.Add(dto);
            }
            return newList2;
            
        }
    }
}


