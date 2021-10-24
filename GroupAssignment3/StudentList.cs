using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAssignment3
{
    class StudentList: IStudentList
    {
        const int MaxNrOfStudents = 50;
        List<string> students;
        List<List<string>> groupedStudents;

        /// <summary>
        /// The number of students to be divided into groups
        /// </summary>
        private int _NrOfStudents = 0;
        public int NrOfStudents {
            get { return students.Count; }
            set { _NrOfStudents = NrOfStudents; }
        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < (students?.Count); i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Number of groups to be created using CreateGroups
        /// Number must be between 1 and Count/2
        /// if Number < 1 and > Count/2 an ArgumentOutOfRangeException() is thrown
        /// if Count  == 0 an ArgumentException("Empty list") is thrown
        /// </summary>
        private int _NrOfGroups = 0;
        public int NrOfGroups {
            get
            {
                return _NrOfGroups;
            }
            set 
            {
                try
                {
                    // Because of the way UserInput is made, this exception will never be reached.
                    if (value < 1 || value > (NrOfStudents / 2))
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    // Because of the way UserInput is made, this exception will never be reached.
                    if (NrOfStudents == 0)
                        throw new Exception("Empty list");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                _NrOfGroups = value;
            }
        }


        /// <summary>
        /// Number of Students to be placed in each group
        /// </summary>
        public int NrStudentsInGroup 
        {
            get 
            {
                return NrOfGroups != 0 ? NrOfStudents / NrOfGroups : 0;
            }
        }

        /// <summary>
        /// Number of students that remains to be placed in groups after groups are created
        /// </summary>
        public int NrStudentsNotInGroup 
        {   
            get { return NrOfGroups != 0 ? NrOfStudents % NrOfGroups : NrOfStudents; }
        }


        /// <summary>
        /// Sort the Students alphabetically
        /// Implement sort on strings using either SelectionSort or BubbleSort from BOOP_05_07 
        /// </summary>
        public void Sort() {

            // Using .CompareTo with bubble sort
            for (int j = 0; j < students.Count - 1; j++)
            {
                for (int i = j + 1; i < students.Count; i++)
                {
                    if (students[j] != null && students[i] != null && students[j].CompareTo(students[i]) > 0)
                    {
                        (students[j], students[i]) = (students[i], students[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Shuffles the students randomly.
        /// Uses .OrderBy from System.Linq to sort elements, placing each element at a random index through random.Next()
        /// </summary>
        public void ShuffleStudents()
        {
            Random random = new Random();
            students = students.OrderBy(x => random.Next()).ToList();
        }

        /// <summary>
        /// Calls on ShuffleStudents to randomly sort the students. Places grouped students in the 2D list groupedStudents.
        /// </summary>
        public void CreateGroups()
        {
            ShuffleStudents();

            groupedStudents = new List<List<string>>();

            int counter = 0;
            for(int i = 0; i < NrOfGroups; i++)
            {
                List<string> temp = new List<string>();

                for (int j = 0; j < students.Count; j++)
                {
                    counter++;
                    counter = (counter == NrOfGroups) ? 0 : counter;

                    if (students[j] != null && counter == i)
                    {
                        temp.Add(students[j]);
                    }
                }

                groupedStudents.Add(temp);
            }
        }

        public string GetAllGroups()
        {
            string sRet = "";

            for (int i = 0; i < groupedStudents?.Count; i++)
            {
                sRet += $"Group {i + 1}:\n";

                for (int j = 0; j < groupedStudents?[i].Count; j++)
                {
                    sRet += $"{groupedStudents.ElementAt(i).ElementAt(j)}";
                    sRet += "\n";
                }
                sRet += "\n";
            }
            return sRet;
        }

        public string GetGroup(int GroupNr)
        {
            string sRet = "";

            sRet += $"Group {GroupNr}:\n";

            for (int i = 0; i < groupedStudents?[GroupNr - 1].Count; i ++)
            {
                sRet += $"{groupedStudents.ElementAt(GroupNr - 1).ElementAt(i)}";
                sRet += "\n";
            }

            return sRet;
        }


        /// <summary>
        /// Fills StudentList with the names of the students from of OOP1 .Net5 
        /// </summary>
        public void CreateOOP1dotNet5()
        {
            students = new List<string>();
            students.Add("Sahar");
            students.Add("Jennifer");
            students.Add("Shohruh");
            students.Add("Jonathan");
            students.Add("Leo");
            students.Add("Jenny");
            students.Add("Mohamed");
            students.Add("Ferri");
            students.Add("Alexandra F");
            students.Add("Vidar");
            students.Add("Kamran");
            students.Add("Pontus");
            students.Add("Kaveh");
            students.Add("Maria");
            students.Add("Adam");
            students.Add("Sophie");
            students.Add("Louise");
            students.Add("Fredric");
            students.Add("Carl-Henrik");
            students.Add("Frans");
            students.Add("Sam");
            students.Add("Alexandra S");
            students.Add("Alperen");
            students.Add("Josefine");
            students.Add("Ghasem");
            students.Add("Hanna");
            students.Add("Finan");
            students.Add("Niklas");
            students.Add("Hector");
            students.Add("Fredrik");
            students.Add("Adrian");
            students.Add("Teodor");
        }
    }
}
