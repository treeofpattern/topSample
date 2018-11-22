using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestExample
{
    public class PatientsWorkList
    {
        public string FarsiName { get; set; }
        public string FarsiFamily { get; set; }
        public int Sex { get; set; }
        public int DateOfBirth { get; set; }
        public string FarsiReferringPhysicianName { get; set; }
        public string StudyDescription { get; set; }
        public string SeriesDescription { get; set; }
        public string PatientID { get; set; }
        public long ModalityId { get; set; }
        public long PerformingPhisicianNameId { get; set; }

    }
}
