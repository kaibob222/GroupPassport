using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using groupPassport.Classes;

namespace groupPassport
{
    public partial class AddStudentForm : Form
    {
        int groupId;
        bool isEditing = false;
        int studentId;
        Student student;

        public AddStudentForm(int id, bool mode = false, int studId = -1)
        {
            InitializeComponent();
            groupId = id;
            isEditing = mode;
            studentId = studId;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            var C = new Context();

            int n = C.Nationalities.Count();
            int m = C.Citizenships.Count();
            for (int i = 0; i < n; i++)
            {
                NationalityBox.Items.Add(C.Nationalities.ToArray()[i].PersonNationality);
            }
            for (int i = 0; i < m; i++)
            {
                CitizenshipBox.Items.Add(C.Citizenships.ToArray()[i].PersonCitizenship);
            }

            if (isEditing)
            {
                student = C.Students.Where(c => c.Id == studentId).FirstOrDefault();
                if (student != null)
                {
                    fNameTextBox.Text = student.FirstName;
                    sNameTextBox.Text = student.SurName;
                    mNameTextBox.Text = student.MiddleName;
                    ZachNumberTextBox.Text = student.ZachetkaNumber;
                    dateTimePicker1.Value = student.BirthDate;
                    string selectedNationality = student.Nationality.PersonNationality;
                    string selectedCitizenship = student.Citizenship.PersonCitizenship;
                    //NationalityBox.SelectedIndex = selectedNationality;
                    //CitizenshipBox.SelectedIndex = selectedCitizenship;
                    NationalityBox.SelectedItem = selectedNationality;
                    CitizenshipBox.SelectedItem = selectedCitizenship;

                    switch (student.Gender.ToString())
                    {
                        case "male":
                            GenderBox.SelectedItem = 0;
                            GenderBox.SelectedIndex = 0;
                            break;
                        case "female":
                            GenderBox.SelectedItem = 1;
                            GenderBox.SelectedIndex = 1;
                            break;
                    }
                    switch (student.MilitaryService.ToString())
                    {
                        case "military":
                            MilitaryBox.SelectedItem = 0;
                            MilitaryBox.SelectedIndex = 0;
                            break;
                        case "nonmilitary":
                            MilitaryBox.SelectedItem = 1;
                            MilitaryBox.SelectedIndex = 1;
                            break;
                    }
                    switch (student.Education.ToString())
                    {
                        case "secondary":
                            EducationBox.SelectedItem = 0;
                            EducationBox.SelectedIndex = 0;
                            break;
                        case "higher":
                            EducationBox.SelectedItem = 1;
                            EducationBox.SelectedIndex = 1;
                            break;
                    }
                    switch (student.FormEducation.ToString())
                    {
                        case "fulltime":
                            EducationFormBox.SelectedItem = 0;
                            EducationFormBox.SelectedIndex = 0;
                            break;
                        case "distant":
                            EducationFormBox.SelectedItem = 1;
                            EducationFormBox.SelectedIndex = 1;
                            break;
                    }
                }
                dropButton.Visible = true;
            }
            button1.Visible = isEditing;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            var C = new Context();

            string fName = fNameTextBox.Text;
            string sName = sNameTextBox.Text;
            string mName = mNameTextBox.Text;
            string zachNumber = ZachNumberTextBox.Text;
            int genderBoxItem = GenderBox.SelectedIndex;//0-male 1-female
            string nationality = NationalityBox.SelectedItem.ToString(); //from 1
            int militaryServiceBoxItem = MilitaryBox.SelectedIndex;//0-yes 1-none
            int educationBoxItem = EducationBox.SelectedIndex;//0-sec 1-high
            int formEducationBoxItem = EducationFormBox.SelectedIndex; //1-distant 0-fulltime
            string citizenship = CitizenshipBox.SelectedItem.ToString();//selected item text
            DateTime birthDate = dateTimePicker1.Value;

            string gender = "";
            switch (genderBoxItem)
            {
                case 0:
                    gender = "male";
                    break;
                case 1:
                    gender = "female";
                    break;
            }

            string militaryService = "";
            switch (militaryServiceBoxItem)
            {
                case 0:
                    militaryService = "military";
                    break;
                case 1:
                    militaryService = "nonmilitary";
                    break;
            }

            string education = "";
            switch (educationBoxItem)
            {
                case 0:
                    education = "secondary";
                    break;
                case 1:
                    education = "higher";
                    break;
            }

            string formEducation = "";
            switch (formEducationBoxItem)
            {
                case 0:
                    formEducation = "fulltime";
                    break;
                case 1:
                    formEducation = "distance";
                    break;
            }

            var studentCitizenship = C.Citizenships.Where(c => c.PersonCitizenship == citizenship).FirstOrDefault();
            var studentNationality = C.Nationalities.Where(c => c.PersonNationality== nationality).FirstOrDefault();

            if (fName != "" && sName != "" && mName != "" && zachNumber != "") {
                if (CitizenshipBox.SelectedIndex != -1 && GenderBox.SelectedIndex != -1 && NationalityBox.SelectedIndex != -1 && MilitaryBox.SelectedIndex != -1 && EducationFormBox.SelectedIndex != -1 && EducationBox.SelectedIndex != -1)
                {
                    if (!isEditing)
                    {
                        StudentLogic.AddStudent(fName,
                            sName,
                            mName,
                            groupId,
                            gender,
                            studentNationality,
                            studentCitizenship,
                            militaryService,
                            formEducation,
                            education,
                            zachNumber,
                            birthDate);
                    }
                    else
                    {
                        StudentLogic.EditStudent(studentId,
                            fName, 
                            sName, 
                            mName,
                            gender,
                            studentNationality,
                            studentCitizenship,
                            militaryService,
                            formEducation,
                            education,
                            zachNumber,
                            birthDate);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные");
            }
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            AddStudentForm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentForm docf = new DocumentForm();
            docf.Student = student;
            docf.Show();
            AddStudentForm_Load(sender, e);
        }
    }
}
