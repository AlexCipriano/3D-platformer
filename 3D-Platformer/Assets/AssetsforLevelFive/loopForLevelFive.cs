using UnityEngine;
using System.Collections;
public class loopForLevelFive : MonoBehaviour {

    private Vector3 MovingDirection = Vector3.back;

    void Update() {
        gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime*15);

        if (gameObject.transform.position.z > -200 || gameObject.transform.position.x > 2300) {
            MovingDirection = Vector3.forward;
        }
        else if (gameObject.transform.position.z < -3000|| gameObject.transform.position.x < -1300 ) {
            MovingDirection = Vector3.back;
        }
    }
}