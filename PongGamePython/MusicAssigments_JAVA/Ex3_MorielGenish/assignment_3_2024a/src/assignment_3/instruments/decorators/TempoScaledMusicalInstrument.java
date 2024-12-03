package assignment_3.instruments.decorators;

import assignment_3.instruments.MusicalInstrument;
import assignment_3.instruments.TooManySoundsException;
import assignment_3.player.*;

public class TempoScaledMusicalInstrument extends MusicalDecorator {
    private double scaleFactor;

    // Constructor
    public TempoScaledMusicalInstrument(MusicalInstrument instrument, double scaleFactor) {
        super(instrument);
        this.scaleFactor = scaleFactor;
    }

    @Override
    public void play(SoundSet soundSet) throws SoundException, TooManySoundsException {

        // Create a new SoundSet object with a copy of the pitches array
        int[] originalPitches = soundSet.getPitches();
        int[] scaledPitches = new int[originalPitches.length];

        // Make a copy of the original pitches
        System.arraycopy(originalPitches, 0, scaledPitches, 0, originalPitches.length);
        SoundSet clonedSoundSet = new SoundSet(soundSet.getDuration(),scaledPitches);

        // Adjust the duration of the sound set according to scaledFactor
        int scaledDuration = (int) (clonedSoundSet.getDuration() * scaleFactor);
        clonedSoundSet.setDuration(scaledDuration);

        instrument.play(clonedSoundSet);
    }


    @Override
    public String toString() {
        return scaleFactor + " tempo scaled " + super.toString();
    }
}
