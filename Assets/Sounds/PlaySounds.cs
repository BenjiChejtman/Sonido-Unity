using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour {
    public AudioClip GunSound;
    public AudioClip SwordSound;

    AudioSource FuenteAudio;
    // Use this for initialization
    void Start () {
        FuenteAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FuenteAudio.clip = GunSound;
            FuenteAudio.Play();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            FuenteAudio.clip = SwordSound;
            FuenteAudio.Play();
        }
    }
}
