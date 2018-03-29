using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class Sound_Collection : MonoBehaviour {

    public AudioSource tickSource;

    private void Start() {
        tickSource = GetComponent<AudioSource>();

    }

 

    void onCollisionEnter (Collision collision) {

        tickSource.Play();
    }

}
