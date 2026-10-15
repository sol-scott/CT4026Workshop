using UnityEngine;

public class Collisions : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        transform.position = new Vector3(0f, 5f, 0f);
    }

    private void OnTriggerEnter(Collider collider) {
        transform.position = new Vector3(0f, 2f, 0f);
    }
}
