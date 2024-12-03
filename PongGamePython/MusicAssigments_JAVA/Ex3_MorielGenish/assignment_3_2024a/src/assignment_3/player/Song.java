package assignment_3.player;

public class Song {
    private String title;
    private SoundSet[] sounds;
    int next; // Pointer to current sound

    // Constructor
    public Song(String title, SoundSet[] sounds) {
        this.title = title;
        this.sounds = sounds;
        reset();
    }

    public String getTitle() {
        return title;
    }

    // Retrieves and moves to the next SoundSet
    public SoundSet next(){
        SoundSet soundSet = sounds[next];
        next++;
        return soundSet;
    }

    public void reset(){
        next = 0;
    }

    // Check if the song has soundset to play next
    public boolean hasNext() {
        return next < sounds.length;
    }
}
