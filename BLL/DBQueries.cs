using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DBQueries
    {
        private static string currentDMS = AppFunctions.getDMSTransactionInitial;
        private static string qgetUserIDorType = "select {0} from login as l join user as u on l.loginID = u.loginID where l.username = '{1}'";
        private static string qlogin = "select username,password from login where username = '{0}' ";
        private static string qlistDoctorsAdmin = "select * from  doctor as d join user as u on d.userID = u.userID join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType;";
        private static string qgetUserAdmin = "select * from  admin as ad join user as u on ad.userID = u.userID join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType where ad.userID = {0};";
        private static string qaddDoctorAccount = currentDMS + " TRANSACTION;" +
                "insert into login values({0},'{1}','{2}');" +
                "insert into user values({3},'{4}','{5}','{6}','{7}','{8}',{9},{10},{11});" +
                "insert into doctor values({12},{13},'{14}');" +
                "COMMIT;";
        private static string qdeleteDoctorAccount = currentDMS + " TRANSACTION;" +
                    "delete from login where loginID = {0};" +
                    "delete from user where userID = {1};" +
                    "delete from doctor where doctorID = {2};" +
                    "delete from weeklySchedules where id >= {3} and id <= {4};" +
                "COMMIT;";
        private static string qmodifyDoctorAccount = currentDMS + " TRANSACTION;" +
                "update login set username = '{0}', password = '{1}' where loginID = {2};" +
                "update user set firstName = '{3}',middleName = '{4}',lastName = '{5}',gender = '{6}',phoneNumber = '{7}',userPerm = {8} where userID = {9} ;" +
                "update doctor set specialisation = '{10}' where userID = {11};" +
                "COMMIT;";
        private static string qlistPatientsAdmin = "select * from  patient as pt join user as u on pt.userID = u.userID join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType;";
        private static string qaddPatientAccount = currentDMS + " TRANSACTION;" +
                "insert into login values({0},'{1}','{2}');" +
                "insert into user values({3},'{4}','{5}','{6}','{7}','{8}',{9},{10},{11});" +
                "insert into patient values({12},{13},'{14}',{15},{16},'{17}','{18}','{19}','{20}');" +
                "COMMIT;";
        private static string qdeletePatientAccount = currentDMS + " TRANSACTION;" +
                    "delete from login where loginID = {0};" +
                    "delete from user where userID = {1};" +
                    "delete from patient  where patientID = {2};" +
                "COMMIT;";
        private static string qmodifyPatientAccount = currentDMS + " TRANSACTION;" +
                "update login set username = '{0}', password = '{1}' where loginID = {2};" +
                "update user set firstName = '{3}',middleName = '{4}',lastName = '{5}',gender = '{6}',phoneNumber = '{7}',userPerm = {8} where userID = {9} ;" +
                "update patient set weight = {10},height = {11},address = '{12}'," +
                "nextOfKin = '{13}',numNextOfKin = '{14}' where userID = {15};" +
                "COMMIT;";
        private static string qaddAdmin = currentDMS + " TRANSACTION;" +
                "insert into login values({0},'{1}','{2}');" +
                "insert into user values({3},'{4}','{5}','{6}','{7}','{8}',{9},{10},{11});" +
                "insert into admin values({12},{13});" +
                "COMMIT;";
        private static string qmanageAccountAdmin = currentDMS + " TRANSACTION;" +
                "update login set username = '{0}', password = '{1}' where loginID = {3};" +
                "update user set firstName = '{4}',middleName = '{5}',lastName = '{6}',gender = '{7}',phoneNumber = '{8}',userPerm = {9} where userID = {10};" +
                "COMMIT;";
        private static string qauthorisationManagement = "update user set userPerm = {0} where userID = {1};";
        private static string qqueryDoctorInfo = "select * from  doctor as d  join user as u on d.userID = u.userID join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType where d.doctorID = {0};";
        private static string qqueryPatientInfo = "select * from  patient as pt  join user as u on pt.userID = u.userID  join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType where pt.patientID = {0};";
        private static string qauthID = "select max({0}) from {1};";
        private static string qmailer = "select * from mailer";
        private static string quserExist = "select {0} from {1} where {2} = '{3}' ";
        private static string qlistPatientsDoctor = "select * from  DP "+
                                "join patient as pt on pt.patientID =  DP.patientID "+
                                "join user as u on pt.userID = u.userID "+
                                "join login as l on l.loginID = u.loginID "+
                                " join permissions as p on p.userPerm = u.userPerm "+
                                " join type as t on t.userType = u.userType "+
                                " where DP.doctorID = {0};";
        private static string qcreateMedicalAdvice = currentDMS + " TRANSACTION;" +
                    "insert into prescription values({0},{1},{2},'{3}');" +
                    "COMMIT;";
        private static string qqueryMedicalRecordsDoctor = currentDMS + " TRANSACTION;" +
                    "select * diagnosis as dg join TBDiagnosis as tbd on dg.diagnosisID = tbd.diagnosis join lab on lab.labID = tbd.labID where dg.doctorID = {0};" +
                    "COMMIT;";
        private static string qmanageAccountDoctor = currentDMS + " TRANSACTION;" +
                "update login set username = '{0}', password = '{1}' where loginID = {3};" +
                "update user set firstName = '{4}',middleName = '{5}',lastName = '{6}',gender = '{7}',phoneNumber = '{8}',userPerm = {9} where userID = {10};" +
                "update doctor set userID = {11} , specialisation = {12} where doctorID = {13}" +
                "COMMIT;";
        private static string qviewAppointmentsDoctor = currentDMS + " TRANSACTION;" +
                    "select * from appointment as app join doctor as d on d.doctorID = app.doctorID join user on user.userID = d.userID where patientID = {0};" +
                    "COMMIT;";
        private static string qgetUserDoctor = "select * from  doctor as d  join user as u on d.userID = u.userID  join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType where d.userID = {0};";
        private static string qgetUserPatient = "select * from  patient as pt join user as u on pt.userID = u.userID join login as l on l.loginID = u.loginID join permissions as p on p.userPerm = u.userPerm join type as t on t.userType = u.userType where pt.userID = {0};";
        private static string qlistDoctorsPatient = "select * from  DP " +
                                "join doctor as d on d.doctorID =  DP.doctorID " +
                                "join user as u on d.userID = u.userID " +
                                "join login as l on l.loginID = u.loginID " +
                                " join permissions as p on p.userPerm = u.userPerm " +
                                " join type as t on t.userType = u.userType " +
                                " where DP.patientID = {0};";
        private static string qsetAppointmentPatient = currentDMS + " TRANSACTION;" +
                    "insert into appointment values({0},{1},{2},'{3}');" +
                    "COMMIT;";
        private static string qqueryMedicalRecordsPatient = currentDMS + " TRANSACTION;" +
                    "select * diagnosis as dg join TBDiagnosis as tbd on dg.diagnosisID = tbd.diagnosis join appointment as app on app.appointmentID = tbd.TBDiagnosisID join prescription as prep on prep.diagnosisID = dg.diagnosisID join lab on lab.labID = tbd.labID; where dg.patientID = {0} " +
                    "COMMIT;";
        private static string qaskMedicalAdvice = currentDMS + " TRANSACTION;" +
                    "insert into diagnosis values({0},{1},{2});" +
                    "insert into NTBDiagnosis values({3},{4},{5});" +
                    "COMMIT;";
        private static string qqueryMedicalAdvice = currentDMS + " TRANSACTION;" +
                   "select * diagnosis as dg join NTBDiagnosis as tbd on dg.diagnosisID = tbd.diagnosis join prescription as prep on prep.diagnosisID = dg.diagnosis " +
                   "COMMIT;";
        private static string qmanageAccountPatient = currentDMS + " TRANSACTION;" +
                "update login set username = '{0}', password = '{1}' where loginID = {3};" +
                "update user set firstName = '{4}',middleName = '{5}',lastName = '{6}',gender = '{7}',phoneNumber = '{8}',userPerm = {9} where userID = {10} ;" +
                "update patient set weight = {10},height = {11},address = '{12}', nextOfKin = '{13}',numNextOfKin = '{14}' where userID = {15};" +
                "COMMIT;";
        private static string qviewAppointmentsPatient = currentDMS + " TRANSACTION;" +
                    "select * from appointment as app join doctor as d on d.doctorID = app.doctorID join user on user.userID = d.userID where patientID = {0};" +
                    "COMMIT;";
        private static string qlistUsersAdmin = "select * from user as u join type as t on t.userType = u.userType order by t.type";
        private static string qupdateuser = "update user set firstName = '{0}',middleName='{1}',lastName='{2}',phoneNumber='{3}' where userID = {4};";
        private static string qgetUser = "select * from user join login on login.loginID = user.loginID where userID = {0}";
        private static string qinsertDoctorPatient = "insert into DP values({0},{1},{2});";
        private static string qsetDefaultWeeklySchedule = currentDMS + " TRANSACTION;" +
            "insert into weeklySchedules values" +
            "({1},'{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}')," +
            "({2},'{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}'),"+
            "({3},'{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}'),"+
            "({4},'{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}'),"+
            "({5},'{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}','{0}');"+ 
            "COMMIT;";
        private static string qgetWeeklySchedule = "select * from weeklySchedules where id >= {0} and id <= {1};";
        private static string qupdateWeeklySchedule = "update weeklySchedules set {0} = '{1}' where id={2}";
        private static string qdPrecordExist = "select * from DP where patientID = {0} and doctorID = {1};";

        public static string QgetUserIDorType { get => qgetUserIDorType; }
        public static string Qlogin { get => qlogin; }
        public static string QlistDoctorsAdmin { get => qlistDoctorsAdmin; }
        public static string QgetUserAdmin { get => qgetUserAdmin; }
        public static string QaddDoctorAccount { get => qaddDoctorAccount; }
        public static string QdeleteDoctorAccount { get => qdeleteDoctorAccount; }
        public static string QmodifyDoctorAccount { get => qmodifyDoctorAccount; }
        public static string QlistPatientsAdmin { get => qlistPatientsAdmin; }
        public static string QaddPatientAccount { get => qaddPatientAccount; }
        public static string QdeletePatientAccount { get => qdeletePatientAccount; }
        public static string QmodifyPatientAccount { get => qmodifyPatientAccount; }
        public static string QaddAdmin { get => qaddAdmin; }
        public static string QmanageAccountAdmin { get => qmanageAccountAdmin; }
        public static string QauthorisationManagement { get => qauthorisationManagement; }
        public static string QqueryDoctorInfo { get => qqueryDoctorInfo; }
        public static string QqueryPatientInfo { get => qqueryPatientInfo; }
        public static string QauthID { get => qauthID; }
        public static string Qmailer { get => qmailer; }
        public static string QuserExist { get => quserExist; }
        public static string QlistPatientsDoctor { get => qlistPatientsDoctor; }
        public static string QcreateMedicalAdvice { get => qcreateMedicalAdvice; }
        public static string QqueryMedicalRecordsDoctor { get => qqueryMedicalRecordsDoctor; }
        public static string QmanageAccountDoctor { get => qmanageAccountDoctor; }
        public static string QviewAppointmentsDoctor { get => qviewAppointmentsDoctor; }
        public static string QgetUserDoctor { get => qgetUserDoctor; }
        public static string QgetUserPatient { get => qgetUserPatient; }
        public static string QlistDoctorsPatient { get => qlistDoctorsPatient; }
        public static string QsetAppointmentPatient { get => qsetAppointmentPatient; }
        public static string QqueryMedicalRecordsPatient { get => qqueryMedicalRecordsPatient; }
        public static string QaskMedicalAdvice { get => qaskMedicalAdvice; }
        public static string QqueryMedicalAdvice { get => qqueryMedicalAdvice; }
        public static string QmanageAccountPatient { get => qmanageAccountPatient; }
        public static string QviewAppointmentsPatient { get => qviewAppointmentsPatient; }
        public static string QlistUsersAdmin { get => qlistUsersAdmin; }
        public static string Qupdateuser { get => qupdateuser; }
        public static string QgetUser { get => qgetUser; }
        public static string QgetWeeklySchedule { get => qgetWeeklySchedule; }
        public static string QsetDefaultWeeklySchedule { get => qsetDefaultWeeklySchedule;}
        public static string QinsertDoctorPatient { get => qinsertDoctorPatient; }
        public static string QUpdateWeeklySchedule { get => qupdateWeeklySchedule; }
        public static string QdPrecordExist { get => qdPrecordExist; }
    }
}
