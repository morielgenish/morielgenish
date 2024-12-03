package assignment_3.instruments.decorators;

import assignment_3.instruments.MusicalInstrument;
import assignment_3.instruments.TooManySoundsException;
import assignment_3.player.*;

public abstract class MusicalDecorator implements MusicalInstrument {
    protected MusicalInstrument instrument;

    public MusicalDecorator(MusicalInstrument instrument) {
        this.instrument = instrument;
    }

    @Override
    public void play(SoundSet soundSet) throws SoundException, TooManySoundsException {
        instrument.play(soundSet);
    }


    @Override
    public void playSong(Song song) {
        System.out.println("Playing " + song.getTitle() + " on " + this.toString());
        song.reset();

        try {
            while (song.hasNext()) {
                play(song.next());
            }
        } catch (SoundException | TooManySoundsException e) {
            // Stop playing the song and print the error message
            System.out.println("Stopped playing " + song.getTitle() + " due to error: " + e.getMessage());
            return;
        }

        System.out.println("Done playing " + song.getTitle());
    }


    @Override
    public String toString() {
        return instrument.toString();
    }
}
