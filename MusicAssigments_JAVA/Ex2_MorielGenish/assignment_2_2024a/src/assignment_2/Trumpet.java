package assignment_2;

public class Trumpet extends MusicalInstrument implements Effectable{

    private boolean mute = false;

    //empty constructor
    public Trumpet() {

    }

    @Override
    public String getName() {
        return "Trumpet";
    }

    @Override
    public String toString() {
        if (mute) {
            return "Trumpet, muted";
        } else {
            return "Trumpet";
        }
    }

    @Override
    public int getNSimultaneousSounds() {
        return 1;
    }


    //effectable methods
    @Override
    public void effect() {

        Player player = new Player(getName());
        if (mute) {
            player.setInstrument("Muted Trumpet");
        }
        else {
            player.setInstrument("Trumpet");
        }

    }


    public void setEffectOn() {
        mute = true;
    }

    public void setEffectOff() {
        mute = false;
    }



}
