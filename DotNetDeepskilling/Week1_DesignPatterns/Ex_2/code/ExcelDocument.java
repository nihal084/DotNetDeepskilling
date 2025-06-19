package Week1_DesignPatterns.Ex_2.code;

public class ExcelDocument implements Document {
    @Override
    public void open() {
        System.out.println("Opening an Excel document...");
    }
}
