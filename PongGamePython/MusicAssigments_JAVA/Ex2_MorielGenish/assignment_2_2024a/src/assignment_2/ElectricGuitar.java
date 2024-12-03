package assignment_2;

public class ElectricGuitar extends MusicalInstrument implements Tunable, Effectable {

    private boolean distortion = false;
    private int tuningCheck = 0;

    //empty constructor
    public ElectricGuitar() {

    }

    @Override
    public String getName() {
        return "Electric Guitar";
    }

    @Override
    public String toString() {
        if (distortion) {
            return "Electric Guitar with distortion";
        } else {
            return "Electric Guitar";
        }
    }

    @Override
    public int getNSimultaneousSounds() {
        return 6;
    }

    @Override
    public boolean play(SoundSet soundSet) {
        tuningCheck++;
        return super.play(soundSet);
    }

    //tunable methods
    @Override
    public boolean isOutOfTune() {
        return tuningCheck > 20;
    }

    @Override
    public void tune() {
        System.out.println("Tuning...");
        tuningCheck = 0;
    }


    //effectable methods
    @Override
    public void effect() {

        Player player = new Player(getName());
        if (distortion) {
            player.setInstrument("Distortion Electric Guitar");
        }
        else {
            player.setInstrument("Electric Guitar");
        }

    }

    public void setEffectOn() {
        distortion = true;
    }

    public void setEffectOff() {
        distortion = false;
    }

}
