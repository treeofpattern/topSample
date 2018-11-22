using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var patientsWolrkList = new PatientsWorkList();
            patientsWolrkList.FarsiFamily = "صارم";
            patientsWolrkList.FarsiName = "صارم";
            patientsWolrkList.FarsiReferringPhysicianName = "صارم";
            patientsWolrkList.Sex = 1;
            patientsWolrkList.DateOfBirth = 13700112;
            patientsWolrkList.StudyDescription = "Chest";
            patientsWolrkList.SeriesDescription = "PA";
            patientsWolrkList.PatientID = "S073676-7-6";
            patientsWolrkList.ModalityId = 0;//Get Id From http://192.168.87.10:1010/api/His/GetModalityDevices
            patientsWolrkList.PerformingPhisicianNameId = 0;//Id of Performing Phisician Name
            var result = SaveNewPatient(patientsWolrkList);
        }
        public static BaseResult SaveNewPatient(PatientsWorkList patientsWolrkList)
        {
            using (HttpClient client = new HttpClient(new HttpClientHandler { UseProxy = false }))
            {
                string api = "http://192.168.87.10:1010/api/His/SaveNewPatient";
                var response = client.PostAsJsonAsync(api, patientsWolrkList);
                var pacsResult = response.Result.Content.ReadAsAsync<BaseResult>().Result;
                return pacsResult;
            }
        }
    }
}
