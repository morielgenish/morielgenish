package assignment_2;

import javax.sound.midi.*;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.TimeUnit;

import static java.lang.Thread.sleep;

public class Player {
    private static final Map<String, Integer> instrumentToIx;
    private Instrument[] instr;
    private MidiChannel channel;

    static {
        instrumentToIx = new HashMap<>();
        instrumentToIx.put("Piano", 0);
        instrumentToIx.put("Xylophone", 13);
        instrumentToIx.put("Electric Guitar", 26);
        instrumentToIx.put("Distortion Electric Guitar", 30);
        instrumentToIx.put("Trumpet", 56);
        instrumentToIx.put("Muted Trumpet", 59);
    }

    public Player(String instrument) {
        try {
            Synthesizer midiSynth = MidiSystem.getSynthesizer();
            midiSynth.open();

            //get and load default instrument and channel lists
            instr = midiSynth.getDefaultSoundbank().getInstruments();
            channel = midiSynth.getChannels()[0];

        } catch (MidiUnavailableException e) {
            e.printStackTrace();
        }
        setInstrument(instrument);
        initialize();
    }

    private void initialize() {
        // Playing a dummy note to avoid time delay artifacts...
        channel.noteOn(0, 1);
        try {
            TimeUnit.MILLISECONDS.sleep(10); // wait the duration (in milliseconds)
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        finally {
            channel.noteOff(0);
        }
    }

    public void playSound(SoundSet soundSet) {
        int[] pitches = soundSet.getPitches();
        if (pitches != null) {
            for (int pitch: pitches) {
                channel.noteOn(pitch, 100); // playing the note
            }
        }
        try {
            TimeUnit.MILLISECONDS.sleep(soundSet.getDuration()); // wait the duration (in milliseconds)
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        finally {
            if (pitches != null) {
                for (int pitch: pitches) {
                    channel.noteOff(pitch); // stop playing the note
                }
            }
        }
    }

    public void setInstrument(String instrument) {
        channel.programChange(instr[instrumentToIx.get(
                instrument)].getPatch().getProgram());
    }

}
