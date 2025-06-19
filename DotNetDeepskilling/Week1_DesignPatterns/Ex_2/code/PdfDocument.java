package Week1_DesignPatterns.Ex_2.code;

public class PdfDocument implements Document {
    @Override
    public void open() {
        System.out.println("Opening a PDF document...");
    }
}
