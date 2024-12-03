package assignment_3.instruments.decorators;

import assignment_3.instruments.MusicalInstrument;
import assignment_3.instruments.TooManySoundsException;
import assignment_3.player.*;

public class ShiftedMusicalInstrument extends MusicalDecorator {
    private int shift;

    // Constructor
    public ShiftedMusicalInstrument(MusicalInstrument instrument, int shift) {
        super(instrument);
        this.shift = shift;
    }

    @Override
    public void play(SoundSet soundSet) throws SoundException, TooManySoundsException {


        int[] originalPitches = soundSet.getPitches();
        int[] shiftedPitches = new int[originalPitches.length];

        // Copying the pitches array and applying the shift
        for (int i = 0; i < originalPitches.length; i++) {
            shiftedPitches[i] = originalPitches[i] + shift;
        }
        for (int pitch : shiftedPitches) {
            if (pitch < 0 || pitch > 127) {
                throw new PitchOutOfRangeException(pitch);
            }
        }

        SoundSet shiftedSoundSet = new SoundSet(soundSet.getDuration(), shiftedPitches);

        instrument.play(shiftedSoundSet);

    }


    @Override
    public String toString() {
        return shift + " shifted " + super.toString();
    }



}