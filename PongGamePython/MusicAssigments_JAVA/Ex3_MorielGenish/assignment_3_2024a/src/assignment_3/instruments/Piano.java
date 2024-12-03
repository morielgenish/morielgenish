package assignment_3.instruments;

import assignment_3.player.*;


public class Piano extends MusicalInstrumentImpl {

    // Constructor
    public Piano() throws UnknownInstrumentException {
        super("Piano", 10);
    }


    // Methods
    public void playSlide(int from, int to, int duration){
        try {
            int diff = 1;
            if (to < from) {
                diff = -1;
            }

            int slideSoundDuration = duration / 10;
            play(new SoundSet(duration, from));
            for (int noteIx = from + diff; noteIx != to; noteIx += diff) {
                play(new SoundSet(slideSoundDuration, noteIx));
            }
            play(new SoundSet(duration, to));
        } catch (TooManySoundsException ignore) {}
        catch (SoundException e) {
            System.out.println(e.getMessage());;
        }
    }


}
