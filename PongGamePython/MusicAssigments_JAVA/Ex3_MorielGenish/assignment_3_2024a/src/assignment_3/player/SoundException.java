package assignment_3.player;

public class SoundException extends Exception {

    private String message;

    // Constructor
    public SoundException(String message) {
        super(message);
        this.message = message;
    }

    // Getter for the message
    @Override
    public String getMessage() {
        return message;
    }
}
