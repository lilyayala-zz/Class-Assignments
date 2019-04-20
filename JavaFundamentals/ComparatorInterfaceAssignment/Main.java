package Ayala_HW6;

import java.util.ArrayList;
import java.util.Collections;

class Main {
    //Array of 5 elements
    public static void main(String[] args) {
        ArrayList<Students> ar = new ArrayList<Students>();
        ar.add(new Students(111, "Will", "Mortl"));
        ar.add(new Students(113, "Lily", "Ayala"));
        ar.add(new Students(112, "Bill", "Gates"));
        ar.add(new Students(115, "Jeff", "Bezos"));
        ar.add(new Students(114, "Elon", "Musk"));

        System.out.println("Unsorted");
        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));

        Collections.sort(ar, new SortbystudentID());

        System.out.println("\nSorted by studentID");
        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));

        Collections.sort(ar, new SortbylastName());

        System.out.println("\nSorted by lastName");
        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));
    }
}