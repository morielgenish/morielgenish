package assignment_3.instruments.decorators;

import assignment_3.instruments.MusicalInstrument;
import assignment_3.instruments.TooManySoundsException;
import assignment_3.player.*;

public class StaccatoMusicalInstrument extends MusicalDecorator {

    // Constructor
    public StaccatoMusicalInstrument(MusicalInstrument instrument) {
        super(instrument);
    }

    @Override
    public void play(SoundSet soundSet) throws SoundException, TooManySoundsException {

        int staccatoDuration = 20;
        int duration = soundSet.getDuration();
        int[] originalPitches = soundSet.getPitches();
        int[] staccatoPitches = originalPitches.clone();

        if(duration>staccatoDuration)
        {
            for (int pitch: staccatoPitches)
            {
                super.play(new SoundSet(staccatoDuration,pitch));
                super.play(new SoundSet(duration-staccatoDuration));

            }
        }
    }


    @Override
    public String toString() {
        return super.toString() + " with staccato";
    }
}
