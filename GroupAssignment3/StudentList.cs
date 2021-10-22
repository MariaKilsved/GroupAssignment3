using System;

namespace GroupAssignment3
{
    class StudentList: IStudentList
    {
        const int MaxNrOfStudents = 50;
        string[] students;
    
        /// <summary>
        /// The number of students to be divided into groups
        /// </summary>
        private int _NrOfStudents = 0;
        public int NrOfStudents => _NrOfStudents;

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _NrOfStudents; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        private void CountStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    _NrOfStudents++;
                }
            }
        }

        /// <summary>
        /// Number of groups to be created using CreateGroups
        /// Number must be between 1 and Count/2
        /// if Number < 1 and > Count/2 an ArgumentOutOfRangeException() is thrown
        /// if Count  == 0 an ArgumentException("Empty list") is thrown
        /// </summary>
        private int _NrOfGroups = 0;
        public int NrOfGroups {get; set;}


        /// <summary>
        /// Number of Students to be placed in each group
        /// </summary>
        public int NrStudentsInGroup 
        {
            get { return _NrOfStudents / _NrOfGroups; }
        }

        /// <summary>
        /// Number of students that remains to be placed in groups after groups are created
        /// </summary>
        public int NrStudentsNotInGroup 
        {   
            get { return _NrOfStudents % _NrOfGroups; }
        }


        /// <summary>
        /// Sort the Students alphabetically
        /// Implement sort on strings using either SelectionSort or BubbleSort from BOOP_05_07 
        /// </summary>
        public void Sort() {

            // Using .CompareTo with bubble sort
            for (int j = 0; j < students.Length - 1; j++)
            {
                for (int i = j + 1; i < students.Length; i++)
                {
                    if (students[j] != null && students[i] != null && students[j].CompareTo(students[i]) > 0)
                    {
                        (students[j], students[i]) = (students[i], students[j]);
                    }
                }
            }
        }


        /// <summary>
        /// Fills StudentList with the names of the students from of OOP1 .Net5 
        /// </summary>
        public void CreateOOP1dotNet5()
        {
            students = new string[MaxNrOfStudents];
            students[0] = "Sahar";
            students[1] = "Jennifer";
            students[2] = "Shohruh";
            students[3] = "Jonathan";
            students[4] = "Leo";
            students[5] = "Jenny";
            students[6] = "Mohamed";
            students[7] = "Ferri";
            students[8] = "Alexandra F";
            students[9] = "Vidar";
            students[10] = "Kamran";
            students[11] = "Pontus";
            students[12] = "Kaveh";
            students[13] = "Maria";
            students[14] = "Adam";
            students[15] = "Sophie";
            students[16] = "Louise";
            students[17] = "Fredric";
            students[18] = "Carl-Henrik";
            students[19] = "Frans";
            students[20] = "Sam";
            students[21] = "Alexandra S";
            students[22] = "Alperen";
            students[23] = "Josefine";
            students[24] = "Ghasem";
            students[25] = "Hanna";
            students[26] = "Finan";
            students[27] = "Niklas";
            students[28] = "Hector";
            students[29] = "Fredrik";
            students[30] = "Adrian";
            students[31] = "Teodor";

            // Without changing the way _NrOfStudents is set, the override string ToString won't work properly
            CountStudents();
        }
    }
}
