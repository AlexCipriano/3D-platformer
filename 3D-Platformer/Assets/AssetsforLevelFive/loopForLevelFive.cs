using UnityEngine;
using System.Collections;
public class loopForLevelFive : MonoBehaviour {

    private Vector3 MovingDirection = Vector3.forward;

    void Update() {
        gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime);

        if (gameObject.transform.position.z > -200) {
            MovingDirection = Vector3.back;
        }
        else if (gameObject.transform.position.z < -2000) {
            MovingDirection = Vector3.forward;
        }
    }
}