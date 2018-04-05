using UnityEngine;
using System.Collections;
public class loopForWhales : MonoBehaviour {

    private Vector3 MovingDirection = Vector3.back;

    void Update() {
        gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime * 15);

        if (gameObject.transform.position.x > -1300) {
            MovingDirection = Vector3.forward;
        }
        else if (gameObject.transform.position.x < 2600) {
            MovingDirection = Vector3.back;
        }
    }
}