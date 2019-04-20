package Ayala_HW6;
/*Student: Lily Ayala
HW6: Java program to demonstrate working of Comparator interface
Date: 3-01-18
Instructor: William Mortl*/

class Students
{
    int studentID;
    String firstName, lastName;

    // Constructor
    public Students(int studentID, String firstName,
                   String lastName)
    {
        this.studentID = studentID;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Used to print student details in main()
    public String toString()
    {
        return this.studentID + " " + this.firstName +
                " " + this.lastName;
    }
}


