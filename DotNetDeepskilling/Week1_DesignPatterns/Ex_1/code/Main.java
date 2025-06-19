package Week1_DesignPatterns.Ex_1.code;

public class Main {
    public static void main(String[] args) {
        Logger firstLogger = Logger.getInstance();
        firstLogger.log("Starting the application...");

        Logger secondLogger = Logger.getInstance();
        secondLogger.log("Application is running...");

        if (firstLogger == secondLogger) {
            System.out.println("Confirmed: Only one Logger instance is being used.");
        } else {
            System.out.println("Error: Multiple Logger instances found!");
        }
    }
}
