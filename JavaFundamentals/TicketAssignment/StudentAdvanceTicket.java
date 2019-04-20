package cs211.Ayala.HW2;

//Class student advance ticket extends advance ticket class

public class StudentAdvanceTicket extends AdvanceTicket {

    //constructor
    public StudentAdvanceTicket(int number, int daysInAdvance) {
        super(number, daysInAdvance);
        /*
        If days in advance are more or equal than 10 days, ticket price  is $15
        If days are less than 10, ticket price is $20
        */
        price = daysInAdvance >= 10 ? price / 2 : 20; // Ternary Operator
    }
}
