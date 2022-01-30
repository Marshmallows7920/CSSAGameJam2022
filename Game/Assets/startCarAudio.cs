using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(CarSteering))]
public class startCarAudio : MonoBehaviour
{

    private CarSteering carSteering;
    private AudioSource aud;

    [SerializeField] float modifier;
    [SerializeField] AudioClip ac;


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

        soundPitch = 1 + (Mathf.Abs(speed) * .3f);
        aud.pitch = soundPitch;
    }
}
