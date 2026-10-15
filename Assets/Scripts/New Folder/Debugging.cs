using UnityEngine;

public class Debugging : MonoBehaviour {

    private void OnCollisionEnter(Collision collision) {
        transform.position = new Vector3(0f, 5f, 0f);
    }
}
