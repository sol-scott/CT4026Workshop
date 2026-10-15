using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ConfettiTrigger : MonoBehaviour
{
    [SerializeField]
    private InputActionReference CInput;
    float ConInputValue;
    bool confetti;
    bool isInTrigger;
    [SerializeField]
    GameObject confettiText;
    [SerializeField]
    GameObject confettiObject;
    [SerializeField]
    int confettiNum = 100;
    [SerializeField]
    float spawnRadius = 2;
    [SerializeField]
    float hightAbovePlayer = 2;
    void Awake() {
        CInput.action.performed += context => ConInputValue = context.action.ReadValue<float>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "ConfettiArea") {

            isInTrigger = true;
            confettiText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        isInTrigger = false;
        confettiText.SetActive (false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update() {
        if (ConInputValue == 1 && isInTrigger) {
            if (confetti == false) {
                Confetti();
            }
        } else if (ConInputValue == 0) {
            confetti = false;
        }

   void Confetti() {
            confetti = true;
            for (int i = 0; i < confettiNum; i++) {
                CreateOneConfetti();
            }
           }
        void CreateOneConfetti() {
            GameObject newConfetti = Instantiate(confettiObject);
            newConfetti.AddComponent<Rigidbody>();
            newConfetti.transform.position = transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius), hightAbovePlayer, Random.Range(-spawnRadius, spawnRadius));
            newConfetti.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.00f, 1.00f), 1, 1);
        }

        }
}
