using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] sounds;
    AudioMixerGroup pitchBendGroup;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;
            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;
            s.Source.loop = s.Loop;
        }
        
        pitchBendGroup = Resources.Load<UnityEngine.Audio.AudioMixerGroup>("Pitch Bend Mixer");

        Play("WaveTomJobim");

        DontDestroyOnLoad(gameObject);
    }



    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.SoundName == name);
        s.Source.Play();
    }

    public void PlayOneShot(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.SoundName == name);
        s.Source.PlayOneShot(s.Clip);
    }

    public void ChangeVolume(string name, float amount)
    {
        Sound s = Array.Find(sounds, sound => sound.SoundName == name);
        s.Source.volume = amount;
    }

    public void ChangeVelocity (string name, float amount)
    {
        Sound s = Array.Find(sounds, sound => sound.SoundName == name);
        s.Source.outputAudioMixerGroup = pitchBendGroup;

        s.Source.pitch = amount;
        pitchBendGroup.audioMixer.SetFloat("pitchBend", 1f / amount);
    }
}
