package assignment_3.instruments;

import assignment_3.player.*;

public abstract class MusicalInstrumentImpl implements MusicalInstrument {

    // Data Members
    private String name;
    protected Player player;
    private int nSimultaneousSounds;

    // Constructors
    public MusicalInstrumentImpl(String name, int nSimultaneousSounds) throws UnknownInstrumentException{
        this.name = name;
        this.nSimultaneousSounds = nSimultaneousSounds;
        setPlayer(name);
    }

    public MusicalInstrumentImpl(String name) throws UnknownInstrumentException {
        this(name, 1);
    }

    // Methods
    // Setter for catching an unknown instrument exception
    public void setPlayer(String name) throws UnknownInstrumentException {
        try {
            player = new Player(name);
        } catch (Exception e) {
            throw new UnknownInstrumentException(name);
        }
    }


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
    public void play(SoundSet soundSet) throws SoundException, TooManySoundsException {
        if(soundSet.getDuration()<0)
        {
            throw new SoundDurationException(soundSet.getDuration());

        }
        // check for too many sounds
        if (soundSet.getPitches().length > nSimultaneousSounds) {
            throw new TooManySoundsException(name, nSimultaneousSounds, soundSet.getPitches().length);
        }

        for (int pitch : soundSet.getPitches()) {
            if (pitch < 0 || pitch > 127) {
                throw new PitchOutOfRangeException(pitch);
            }
        }
        try {
           System.out.println("Playing " + soundSet.toString());
           player.playSound(soundSet);
         }catch(SoundException e)
     {
         System.out.println(e.getMessage());
     }
    }




    // Getters
    public String getName(){
        return name;
    }

    public int getNSimultaneousSounds() {
        return nSimultaneousSounds;
    }

    @Override
    public String toString(){
        return name;
    }
}
