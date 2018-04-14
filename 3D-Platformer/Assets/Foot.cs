using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Foot : MonoBehaviour {

    AudioSource audioSource;

    CharacterController cc;
    void Start() {
        audioSource = GetComponent<AudioSource>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audioSource.isPlaying == false) {
            audioSource.volume = Random.Range(0.2f, 0.4f);
            audioSource.pitch = Random.Range(0.7f, 0.9f);
            audioSource.Play();
        }
    }
}