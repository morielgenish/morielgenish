package assignment_3.instruments;

public class TooManySoundsException extends Exception  {

    //TooManySoundsException does not inherit from SoundException because if it is, it occurs a complitaion error in the tests( which i can't change)

    // Constructor
    public TooManySoundsException(String instrument, int nSimultaneousSounds, int notesToPlay) {
        super(instrument + " can play at most " + nSimultaneousSounds + " simultaneous notes, cannot play a sound set with " + notesToPlay + " notes!");
    }
}
