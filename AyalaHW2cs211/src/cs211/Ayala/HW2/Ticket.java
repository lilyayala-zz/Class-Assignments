/*
* Student: Lily Ayala
* CS211 Assignment 2
* Instructor: William Mortl.
* Date: 01-24-2018
* */


package cs211.Ayala.HW2;
import java.util.Scanner;

public abstract class Ticket {

    protected double price;
    private int number;

    //constructor
    public Ticket(int number){
        this.number = number;
    }

    public static void main(String[] args){

        int option;

        System.out.println("Ticket Options:\n" +
                "\n1- Walk-up\n" +
                "2- Student\n" +
                "3- Advance");
        System.out.print("\n" +
                "Enter desired ticket \n" +
                "Option Number: ");


        //Create an object of the scanner class
        Scanner scan = new Scanner(System.in);

        //Take user input
        option = scan.nextInt();

       //If user needs walk-up tickets
        if(option == 1){
            //Print ticket
            int num = (int)(Math.random()*99);
            /*If user comes 10 or more days early,
              print the ticket accordingly
             */
            Ticket walkUp = new WalkUpTicket(num);
            System.out.println(walkUp.ToString());

        }

        //If student needs Student discount
        if(option == 2) {
            //Print ticket
            int num = (int) (Math.random() * 99);
             /*If user comes 10 or more days early,
              print the ticket accordingly
             */
            Ticket studentAdvance = new StudentAdvanceTicket(num, 11);
            System.out.println(studentAdvance.ToString());

        }

        //If user needs advance ticket

        if(option == 3){

            int num = (int) (Math.random() * 99);
            /*If user comes 10 or more days early,
              print the ticket accordingly
             */
            Ticket advanceTicket = new AdvanceTicket(num,3);
            System.out.println(advanceTicket.ToString());

        }
        scan.close();
    }

    //Methods
    public double getPrice(){
        return price;
    }

    public String ToString(){
        //return "Ticket No: " + number + " Price: " + price;
        return "Ticket No." + number + " Price: " + "$" + getPrice();
    }


}
