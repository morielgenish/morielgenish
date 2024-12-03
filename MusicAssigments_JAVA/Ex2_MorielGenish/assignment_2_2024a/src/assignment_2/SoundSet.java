package assignment_2;

public class SoundSet {

    //fields
    private int duration;
    private int[] pitches;

    //Constructors
    // constructor for pitches
    public SoundSet(int duration, int ... pitches)
    {
        this.duration = duration;
        this.pitches = pitches;
    }

    //constructor for notes
    public SoundSet(int duration, String ... notes)
    {
        this.duration = duration;
        this.pitches = new int[notes.length];
        for (int i = 0; i < notes.length; i++) {
            this.pitches[i] = PitchHelper.nameToPitch(notes[i]); // convert note to pitch
        }
    }

    // constructor for pause
    public SoundSet(int duration) {
        this.duration = duration;
        this.pitches = new int[0]; // Empty array for pause
    }

    //get methods
    public int getDuration() { return duration; }
    public int[] getPitches() { return pitches; }


}
