package assignment_3.player;

public class SoundSet {

    private int duration;
    private int[] pitches;

    // Constructors
    public SoundSet(int duration)  {
        setDuration(duration);
        pitches = new int[0];
    }

    public SoundSet(int duration, int... pitches)  {
        setDuration(duration);
        setPitches(pitches);
    }

    public SoundSet(int duration, String... notes)  {
        setDuration(duration);
        pitches = new int[notes.length];
        for (int i = 0; i < notes.length; i++) {
            pitches[i] = PitchHelper.nameToPitch(notes[i]);
        }
    }

    // Setter to check for negative duration
    public void setDuration(int duration)  {
        try {
            if (duration < 0) {
                throw new SoundDurationException(duration);
            }

        } catch (SoundDurationException e) {
            System.out.println(e.getMessage());
        }
        this.duration = duration;
    }

    // Setter to check if the pitch is higher than 127 and lower than 0
    public void setPitches(int... pitches)  {

        try {
            for (int pitch : pitches) {
                if (pitch < 0 || pitch > 127) {
                    throw new PitchOutOfRangeException(pitch);
                }
            }

        }catch(PitchOutOfRangeException e)
        {
            System.out.println(e.getMessage());
        }
        this.pitches = pitches;

    }

    // Getters
    public int getDuration() {
        return duration;
    }

    public int[] getPitches() {
        return pitches;
    }

    public String toString() {
        return "Duration: " + duration + "ms, notes: " + PitchHelper.pitchToName(pitches);
    }
}
