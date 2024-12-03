package assignment_2;

public class Piano extends MusicalInstrument implements Tunable{

    private int tuningCheck = 0;

    //empty constructor
    public Piano() {

    }

    @Override
    public String getName() {
        return "Piano";
    }

    @Override
    public String toString() {
        return "Piano";
    }

    @Override
    public int getNSimultaneousSounds() {
        return 10;
    }

    @Override
    public boolean play(SoundSet soundSet) {
        tuningCheck++;
        return super.play(soundSet);
    }

    // tunable methods
    @Override
    public boolean isOutOfTune() {
        return tuningCheck > 65;
    }

    @Override
    public void tune() {
        System.out.println("Tuning...");
        tuningCheck = 0;
    }

    public void playSlide(int from, int to, int duration) {
        int i;
        int middleDuration = duration / 10;

        if (from < to) {
            i = 1; // ascending
        } else {
            i = -1; // descending
        }

        play(new SoundSet(duration, from)); // first note

        // in between notes
        for (int note = from + i; note != to; note += i) {
            play(new SoundSet(middleDuration, note));
        }

        play(new SoundSet(duration, to)); // last note
    }


}


