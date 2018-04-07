using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectController : MonoBehaviour {
    public enum Direction1 { X, Y, Z };

    public Direction1 directionFaced;
    public GameObject plane;
    public GameObject character;

    float offset;
    Vector3 newPos;

    void Update() {

        if (directionFaced == Direction1.X) {
            offset = (plane.transform.position.x - character.transform.position.x);
            newPos.x = plane.transform.position.x + offset;
            newPos.y = character.transform.position.y;
            newPos.z = character.transform.position.z;
        }
        if (directionFaced == Direction1.Y) {
            offset = (plane.transform.position.y - character.transform.position.y);
            newPos.x = character.transform.position.x;
            newPos.y = plane.transform.position.y + offset;
            newPos.z = character.transform.position.z;
        }
        if (directionFaced == Direction1.Z) {
            offset = (plane.transform.position.z - character.transform.position.z);
            newPos.x = character.transform.position.x;
            newPos.y = character.transform.position.y;
            newPos.z = plane.transform.position.z + offset;
        }
        transform.position = newPos;
    }

}