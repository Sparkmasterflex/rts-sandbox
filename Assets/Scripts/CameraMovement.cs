
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float panSpeed = 20f;
    public float panBorderThickness = 10f;

    public Vector2 panLimit;
    float rotateSpeed = 80f;
    float scrollSpeed = 20f;
    public float minY = 10f;
    public float maxY = 80f;

    public float rotationSmoothTime = 0.12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    void Update() {
        float scroll = Input.GetAxis("Mouse ScrollWheel") * 10;
        transform.position += (transform.up*scroll) * scrollSpeed * Time.deltaTime;

        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness) {
            transform.localPosition += transform.forward * panSpeed * Time.deltaTime;
        }

        if(Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness) {
            transform.localPosition += -transform.forward * panSpeed * Time.deltaTime;
        }

        if(Input.GetKey("d")) {
            transform.localPosition += transform.right * panSpeed * Time.deltaTime;
        }

        if(Input.GetKey("a")) {
            transform.localPosition += -transform.right * panSpeed * Time.deltaTime;
        }

        if(Input.GetKey("q")) { // || Input.mousePosition.x <= panBorderThickness) {
            transform.eulerAngles = RotateCamera(rotateSpeed * -1);
        }

        if(Input.GetKey("e")) { // || Input.mousePosition.x >= Screen.width - panBorderThickness) {
            transform.eulerAngles = RotateCamera(rotateSpeed);
        }

    }

    Vector3 RotateCamera(float speed) {
        Vector3 origin = transform.eulerAngles;
        Vector3 destination = origin;
        destination.y += speed * Time.deltaTime;
        return destination;
    }
}
