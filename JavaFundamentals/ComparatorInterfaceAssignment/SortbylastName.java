package Ayala_HW6;

import java.util.Comparator;

class SortbylastName implements Comparator<Students>
{
    // Used for sorting in ascending order of lastName
    public int compare(Students a, Students b)
    {
        return a.lastName.compareTo(b.lastName);
    }
}