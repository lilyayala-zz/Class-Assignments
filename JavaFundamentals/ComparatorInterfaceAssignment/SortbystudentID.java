package Ayala_HW6;

import java.util.Comparator;

class SortbystudentID implements Comparator<Students>
{
    // Used for sorting in ascending order of StudentID
    public int compare(Students a, Students b)
    {
        return a.studentID - b.studentID;
    }
}