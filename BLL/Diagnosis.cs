using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Diagnosis
    {
        private int diagnosisID;

        public Diagnosis()
        {
            this.diagnosisID = AutoIncrementValue.authID("diagnosisID", "diagnosis");
        }

        public int DiagnosisID { get => diagnosisID ; }
    }

    public class TBDiagnosis : Diagnosis
    {
        private int _TBDiagnosisID;
        public Lab lab = new Lab();

        public TBDiagnosis()
        {
            this._TBDiagnosisID = AutoIncrementValue.authID("TBDiagnosisID", "TBDiagnosis");
        }

        public int TBDiagnosisID { get => _TBDiagnosisID; }

        public class Lab
        {
            private int labID;
            private string report;
            private string labTechnician;

            public Lab()
            {
                this.labID = AutoIncrementValue.authID("labID", "lab");
            }

            public int LabID { get => labID; }
            public string Report { get => report; set => report = value; }
            public string LabTechnician { get => labTechnician; set => labTechnician = value; }
        }
    }

    public class NTBDiagnosis : Diagnosis
    {
        private int _NTBDiagnosis;
        private string patientSymptoms;

        public NTBDiagnosis()
        {
            _NTBDiagnosis = AutoIncrementValue.authID("NTBDiagnosisID", "NTBDiagnosis"); ;
        }

        public int NTBDiagnosisID { get => _NTBDiagnosis; }
        public string PatientSymptoms { get => patientSymptoms; set => patientSymptoms = value; }
    }
}
