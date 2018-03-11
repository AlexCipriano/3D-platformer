using UnityEngine;
using System.Collections;
public class loopForLevelFive : MonoBehaviour {

    private Vector3 MovingDirection = Vector3.up;

    void Update() {
        gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime);

        if (gameObject.transform.position.y > 72) {
            MovingDirection = Vector3.down;
        }
        else if (gameObject.transform.position.y < 61) {
            MovingDirection = Vector3.up;
        }
    }
}