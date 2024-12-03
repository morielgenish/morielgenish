package assignment_2;

public class Xylophone extends MusicalInstrument {

    //empty constructor
    public Xylophone() {

    }

    @Override
    public String getName() {
        return "Xylophone";
    }

    @Override
    public String toString() {
        return "Xylophone";
    }

    @Override
    public int getNSimultaneousSounds() {
        return 1;
    }



}
