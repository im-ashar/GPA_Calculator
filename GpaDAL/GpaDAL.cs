using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DAL
{
    public class GpaDAL : BaseDAL
    {
        public void SerializeObjects(List<GpaDTO> ObjectsList)
        {
            List<string> newList = new List<string>();
            foreach (GpaDTO x in ObjectsList)
            {
                string serializedObject = JsonSerializer.Serialize(x);
                newList.Add(serializedObject);
            }
            WrtiteToFile("Gpa_Calculator.txt", newList);
            
        }
        public List<GpaDTO> DeSerializedObjects()
        {
            List<String> newList = ReadFromFile("Gpa_Calculator.txt");
            List<GpaDTO> newList2 = new List<GpaDTO>();
            foreach (string x in newList)
            {
                GpaDTO dto = JsonSerializer.Deserialize<GpaDTO>(x);
                newList2.Add(dto);
            }
            return newList2;
        }
    }
}
