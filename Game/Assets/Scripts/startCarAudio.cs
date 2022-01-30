using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(CarSteering))]
public class startCarAudio : MonoBehaviour
{

    private CarSteering carSteering;
    private AudioSource aud;


    void Start()
    {
        aud = GetComponent<AudioSource>();
        carSteering = GetComponent<CarSteering>();
    }

    // Update is called once per frame
    void Update()
    {
        float soundPitch = 1;
        float speed = carSteering.getSpeed();

        soundPitch = .5f + (Mathf.Abs(speed) * .3f);
        aud.pitch = soundPitch;
    }
}
