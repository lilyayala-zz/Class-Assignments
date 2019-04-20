package cs211.Ayala.HW2;

//Class advance ticket extends Ticket class

public class AdvanceTicket extends Ticket {

//Constructor
    public AdvanceTicket(int number, int daysInAdvance) {
        super(number);
        /*
        If days in advance are more or equal than 10 days, ticket price  is $30
        If days are less than 10, ticket price is $40
        */
        price = daysInAdvance >= 10 ? 30 : 40; // Ternary Operator

    }




}
