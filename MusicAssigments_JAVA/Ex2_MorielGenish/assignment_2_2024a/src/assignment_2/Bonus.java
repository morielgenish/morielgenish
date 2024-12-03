package assignment_2;

public class Bonus {

    public static void main(String[] args) {

        MusicalInstrument piano = new Piano(); // I chose piano

        piano.playSong(einLiEretzAheret());

        //piano.playSong(myHeartWillGoOn());  // if you didn't like the first one

    }


    public static Song einLiEretzAheret() {
        int quarter = 500;
        int half = 2 * quarter;
        int eighth = 256;

        SoundSet[] sounds = {
                new SoundSet(half, "C5"),
                new SoundSet(half, "B4"),

                new SoundSet(quarter, "A4"),
                new SoundSet(eighth, "G#4"),
                new SoundSet(eighth, "A4"),
                new SoundSet(quarter, "C5"),
                new SoundSet(quarter, "A4"),

                new SoundSet(quarter, "D4"),
                new SoundSet(quarter, "D4"),
                new SoundSet(quarter, "E4"),
                new SoundSet(quarter, "F4"),

                new SoundSet(quarter, "E4"),
                new SoundSet(quarter, "E5"),
                new SoundSet(quarter, "E5"),
                new SoundSet(quarter, "D5"),

                new SoundSet(half, "C5"),
                new SoundSet(half, "B4"),

                new SoundSet(quarter, "A4"),
                new SoundSet(eighth, "G#4"),
                new SoundSet(eighth, "A4"),
                new SoundSet(quarter, "C5"),
                new SoundSet(quarter, "A4"),

                new SoundSet(quarter, "D4"),
                new SoundSet(quarter, "D4"),
                new SoundSet(quarter, "E4"),
                new SoundSet(quarter, "F4"),

                new SoundSet(quarter, "E4"),
                new SoundSet(quarter, "E5"),
                new SoundSet(quarter, "E5"),
                new SoundSet(quarter, "D5"),


        };
        return new Song("Ein Li Eretz Aheret", sounds); //אין לי ארץ אחרת
    }


    public static Song myHeartWillGoOn(){
        int eighth = 256;
        int quarter = 2 * eighth;
        int half = 2 * quarter;
        int three_quarter = 3 * quarter;
        int eighth3 = 3 * eighth;
        int whole = 2 * half;

        SoundSet[] sounds = {

                new SoundSet(eighth3,"C5"),
                new SoundSet(eighth,"C5"),
                new SoundSet(quarter,"C5"),
                new SoundSet(quarter,"C5"),

                new SoundSet(quarter,"B4"),
                new SoundSet(half,"C5"),
                new SoundSet(quarter,"B4"),

                new SoundSet(quarter,"B4"),
                new SoundSet(half,"C5"),
                new SoundSet(quarter,"D5"),

                new SoundSet(half,"E5"),
                new SoundSet(half,"D5"),

                new SoundSet(eighth3,"C5"),
                new SoundSet(eighth,"C5"),
                new SoundSet(quarter,"C5"),
                new SoundSet(quarter,"C5"),

                new SoundSet(quarter,"B4"),
                new SoundSet(half,"C5"),
                new SoundSet(quarter,"C5"),

                new SoundSet(whole,"G4"),

                new SoundSet(whole,"C5"),

                new SoundSet(three_quarter,"D5"),
                new SoundSet(quarter,"G4"),

                new SoundSet(half,"G5"),
                new SoundSet(quarter,"F5"),
                new SoundSet(quarter,"E5"),

                new SoundSet(half,"D5"),
                new SoundSet(quarter,"E5"),
                new SoundSet(quarter,"F5"),

                new SoundSet(half,"E5"),
                new SoundSet(quarter,"D5"),
                new SoundSet(quarter,"C5"),

                new SoundSet(quarter,"B4"),
                new SoundSet(half,"C5"),
                new SoundSet(quarter,"C5"),

                new SoundSet(whole,"A4"),
                new SoundSet(whole,"G4"),


        };
        return new Song("My Heart Will Go On", sounds);

    }


}
