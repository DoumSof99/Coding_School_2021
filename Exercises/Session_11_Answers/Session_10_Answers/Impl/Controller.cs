using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10_Answers.Impl {
    public class Controller {

        public University CodingSchool { get; set; }
        public string LogFile { get; set; }
        public EntityTypeEnum Type { get; set; }

        public string Message { get; set; }

        public Controller() {

        }

        public Controller(University university, string logFile) {

            CodingSchool = CodingSchool;
            LogFile = logFile;
        }

        public List<string> GetList() {

            List<string> list = new List<string>();

            switch (Type) {
                case EntityTypeEnum.Course:

                    try {
                        if (CodingSchool?.Courses != null) { // != null && CodingSchool.Students != null) {
                            foreach (Course item in CodingSchool.Courses) {

                                list.Add(string.Format("ID={0} \t Code={1} \t Subject={2}",
                                    item.ID, item.Code, item.Subject));
                            }
                        }
                        else {
                            Message = "No student data exists!";
                        }
                    }
                    catch (Exception ex) {
                        Message = "Something wrong happened! Please send me the log file!";

                        string path = Path.Combine(Environment.CurrentDirectory, LogFile);
                        File.WriteAllText(path, ex.ToString());
                    }

                    break;
                case EntityTypeEnum.Student:
                    try {
                        if (CodingSchool?.Students != null) { // != null && CodingSchool.Students != null) {
                            foreach (Student item in CodingSchool.Students) {

                                list.Add(string.Format("ID={0} \t Name={1} \t Surname={2} \t RegistrationNumber={3}",
                                    item.ID, item.Name, item.Surname, item.RegistrationNumber));
                            }
                        }
                        else {
                            Message = "No student data exists!";
                        }
                    }
                    catch (Exception ex) {
                        Message = "Something wrong happened! Please send me the log file!";

                        string path = Path.Combine(Environment.CurrentDirectory, LogFile);
                        File.WriteAllText(path, ex.ToString());
                    }
                    break;
                case EntityTypeEnum.Professor:

                    try {
                        if (CodingSchool?.Courses != null) { // != null && CodingSchool.Students != null) {
                            foreach (Professor item in CodingSchool.Professors) {

                                list.Add(string.Format("ID={0} \t Name={1} \t Surname={2}",
                                    item.ID, item.Name, item.Surname));
                            }
                        }
                        else {
                            Message = "No student data exists!";
                        }
                    }
                    catch (Exception ex) {
                        Message = "Something wrong happened! Please send me the log file!";

                        string path = Path.Combine(Environment.CurrentDirectory, LogFile);
                        File.WriteAllText(path, ex.ToString());
                    }

                    break;
                default:
                    break;
            }

            return list;


        }



    }
}
