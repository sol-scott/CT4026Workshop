using UnityEngine;
using UnityEngine.InputSystem;

public class PointInteraction : MonoBehaviour {
    [SerializeField]
    private InputActionReference playerInputs;
    float pointerInputValue;
    bool shoot;
    private Camera cam;

    void Awake() {
        playerInputs.action.performed += context => pointerInputValue = context.action.ReadValue<float>();
    }

    void Start() {
        cam = Camera.main;
    }

    void Update() {
        if (pointerInputValue == 1) {
            if (shoot == false) {
                Shoot();
            }
        } else if (pointerInputValue == 0) {
            shoot = false;
        }


        void Shoot() {
            shoot = true;
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100f)) {
                Debug.Log("shot " + hit.transform.name);
                if (hit.transform.CompareTag("Door")) {
                    hit.transform.GetComponentInParent<Animator>().SetTrigger("Trigger");
                }
                if (hit.transform.CompareTag("Light")) {
                    hit.transform.GetComponentInParent<Light>().enabled = !hit.transform.GetComponentInParent<Light>().enabled;
                }
            }
        }
    }
}
