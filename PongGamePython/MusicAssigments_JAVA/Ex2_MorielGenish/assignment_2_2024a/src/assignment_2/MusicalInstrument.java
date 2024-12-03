package assignment_2;

import java.net.StandardSocketOptions;

public abstract class MusicalInstrument {

    //fields to inherit
    protected String name;

    //empty constructor
    public MusicalInstrument() { }

    public abstract String getName();
    public abstract int getNSimultaneousSounds();

    public boolean play(SoundSet soundSet) {
        int[] pitches = soundSet.getPitches();
        int maxNotes = getNSimultaneousSounds();

        // when the instrument cant play more than his max simultaneous notes
        if (pitches.length > maxNotes) {
            System.out.println(getName() + " can play at most " + maxNotes + " simultaneous notes, cannot play a sound set with " + pitches.length + " notes!");
            return false;
        } else {
            if (pitches.length == 0) {
                System.out.println("Playing duration: " + soundSet.getDuration() + "ms, notes: break");
                return true; // it's not an error condition
            }
            else
            {
                // check if the instrument is tunable and if it is and out of tune - adjust the pitches
                int[] adjusted_pitches = new int[pitches.length];
                if (this instanceof Tunable tunable && tunable.isOutOfTune()) {
                    for (int i = 0; i < pitches.length; i++) {
                        adjusted_pitches[i] = pitches[i] - 1; // out of tune - adjusting down by semitone
                    }
                }
                else
                {
                    adjusted_pitches = pitches.clone();
                }

                //check if instrument is effectable
                if (this instanceof Effectable effectable) {
                    effectable.effect();
                }

                // print notes
                System.out.print("Playing duration: " + soundSet.getDuration() + "ms, notes: ");
                for (int i = 0; i < adjusted_pitches.length; i++) {
                    System.out.print(PitchHelper.pitchToName(adjusted_pitches[i]));
                    if (i != adjusted_pitches.length - 1) {
                        System.out.print(", ");
                    }
                }
                System.out.println();

                // check if muted
                if (!isMuted) {
                    Player player = new Player(getName());
                    player.playSound(new SoundSet(soundSet.getDuration(), adjusted_pitches));
                }

                return true;
            }
        }
    }


    public void playSong(Song song) {
        System.out.println("Playing " + song.getTitle() + " on " + this.toString());

        while (song.hasNext()) {
            SoundSet soundSet = song.next();

            int[] pitches = soundSet.getPitches();

            // play the soundset, if it stopped print a message
            if (!play(soundSet)) {
                System.out.println("Stopped playing " + song.getTitle() + " due to error!");
                song.reset();
                return;
            }
        }

        song.reset();


        System.out.println("Done playing " + song.getTitle());
    }



    private static boolean isMuted = false;
    public static void setMuteState(boolean muteState) {
        isMuted = muteState;
    }

}





