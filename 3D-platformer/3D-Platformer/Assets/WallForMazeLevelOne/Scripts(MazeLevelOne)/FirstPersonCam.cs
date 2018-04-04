using UnityEngine;
using System.Collections;

public class FirstPersonCam : MonoBehaviour {

    public float minimumX = -60.0f;
    public float maximumX = 60.0f;
    public float minimumY = -360.0f;
    public float maximumY = 360.0f;
    public float sensitivityX = 15.0f;
    public float sensitivityY = 15.0f;

    public Camera cam;

    float rotationX;
    float rotationY;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update () {

        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;

        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
	}
}