package assignment_3.instruments;

public class UnknownInstrumentException extends Exception {

    public UnknownInstrumentException(String instrumentName) {

        super("Unknown instrument: " + instrumentName + ".");

    }
}
