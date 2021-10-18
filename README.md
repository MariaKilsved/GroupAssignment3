# GroupAssignment3
## Objective
You are going to code a tool to create randomly generated groups for students to work in. I
provide a structure similar to what you, yourself, came up with during your Scrum Sprint in
class earlier.

You will be practicing implementing an interface, IStudentList, in the class StudentList.
You will also be practicing how to implement the sorting algorithm SelectionSort or Bubble
sort on string[]. Finally, you will be practicing / and % operator and the general Console
TryReadXXX pattern from code sessions.

Notice, using Interfaces, to compile your code you don’t have to change code in Main() as
myStudents is of type IStudentList. But to execute your code, myStudents needs to be set to
an instance of the class StudentList.

Running the program, it should:
- Create an empty instance of StudentList and print it out
- Fill the list with OOP1 .NET5 students and print it out
- Sort the list and print it out
- Ask the user how many groups to create and calculate and present, the number of
students in each group and how many students remains to be placed in groups.

#### Mandatory:
- Work in your assigned group
- Clone the repository https://github.com/smarlen/GroupAssignment3Exercise.git
- Implement IStudentList by creating a class StudentList that implements all the
properties and Methods declared in the interface. StudentList template is supplied
but commented out. You can remove the comment an continue implementation.

#### Challenge individually or in group (if you like to try):
- Implement a Method, CreateGroups(), that creates the groups and randomly place
the number of students in each group.
- Implement a Method, string[] GetGroup(int GroupNr), that return the names of the
students in a specific group
- Implement a Method, string[] RemainToGroup(), that return the names of the
students yet to be placed in groups.

#### Report:
- Hand in your group work with the names and participants in the group mentioned as
comments in the code at the deadline given. Hand as a link to your git repository.
