using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen : MonoBehaviour {

    public GameObject TrapDoor;

    private void OnTriggerEnter() {
        TrapDoor.GetComponent<Animation>().Play("TrapAniForDoor");

    }
}
