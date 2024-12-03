package assignment_2;
import java.util.NoSuchElementException;

public class Song {

    //fields
    private String title;
    private SoundSet[] sounds;
    private int currentIndex;

    //constructor
    public Song(String title, SoundSet[] sounds)
    {
        this.title = title;
        this.sounds = sounds;
        this.currentIndex = 0;
    }

    //get method
    public String getTitle(){ return title; }

    //methods
    public boolean hasNext() {
        return currentIndex < sounds.length;
    }

    public SoundSet next() {

        return sounds[currentIndex++];
    }

    public void reset() {
        currentIndex = 0;
    }


}
