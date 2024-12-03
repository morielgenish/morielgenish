package assignment_3.instruments;

import assignment_3.player.*;

public interface MusicalInstrument {

    void play(SoundSet soundSet) throws SoundException, TooManySoundsException;
    void playSong(Song song);
    String toString();

}
