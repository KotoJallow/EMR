using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Appointment
    {
        private int appointmentID;
        private string period; //should be datetime but datetimepicker.text gives a string no worries

        public Appointment()
        {
            this.appointmentID = AutoIncrementValue.authID("appointmentID", "appointment"); ;
        }

        public string Period { get => period; set => period = value; }
        public int AppointmentID { get => appointmentID; }
    }

    public class Prescription
    {
        private int prescriptionID;
        public enum PrescriptionTypes
        {
            APPOINTMENT,ADVICE
        };

        private PrescriptionTypes prescriptionType;
        private string details;

        public Prescription()
        {
            this.prescriptionID = AutoIncrementValue.authID("prescriptionID", "prescription"); ;
        }

        public int PrescriptionID { get => prescriptionID; }
        
        public string Details { get => details; set => details = value; }
        public PrescriptionTypes PrescriptionType { get => prescriptionType; set => prescriptionType = value; }
    }

}
