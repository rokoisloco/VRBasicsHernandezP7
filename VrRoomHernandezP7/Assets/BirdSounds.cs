using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSounds : MonoBehaviour
{

    public AudioClip[] birdSounds;  // Array to hold bird sound clips
    private AudioSource audioSource;

    // Minimum and maximum time between sounds
    public float minTimeBetweenSounds = 5.0f;
    public float maxTimeBetweenSounds = 15.0f;

    private float timeUntilNextSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ScheduleNextSound();
    }

    void Update()
    {
        // Check if it's time to play the next sound
        if (timeUntilNextSound <= 0)
        {
            PlayRandomSound();
            ScheduleNextSound();
        }
        else
        {
            timeUntilNextSound -= Time.deltaTime;
        }
    }

    // Schedules the next sound with a random delay
    void ScheduleNextSound()
    {
        timeUntilNextSound = Random.Range(minTimeBetweenSounds, maxTimeBetweenSounds);
    }

    // Plays a random bird sound from the array
    void PlayRandomSound()
    {
        int randomIndex = Random.Range(0, birdSounds.Length);
        audioSource.PlayOneShot(birdSounds[randomIndex]);
    }
}
