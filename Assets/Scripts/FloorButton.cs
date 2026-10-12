using UnityEngine;
using UnityEngine.Events;

public class FloorButton : MonoBehaviour {
    const string PLAYER_TAG = "Player";
    public UnityEvent ButtonPressed;
    public UnityEvent ButtonRelsed;

    private void OnTriggerEnter(Collider Other) {
        if (Other.CompareTag(PLAYER_TAG)) {
            Debug.Log("Button Pressed");
            ButtonPressed.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag(PLAYER_TAG)) {
            Debug.Log("Button Realsed");
            ButtonRelsed.Invoke();
        }
    }
}
