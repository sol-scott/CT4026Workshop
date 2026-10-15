using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BouncingToys : MonoBehaviour {
    private GameObject[] toys;
    [SerializeField]
    private float force = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        toys = GameObject.FindGameObjectsWithTag("toy");
        for (int i = 0; i < toys.Length; i++) {
            Debug.Log("Toys number " + i + " is named " + toys[i].name);
        }
        StartCoroutine(Bounce(1f));
    }
   
    private IEnumerator Bounce(float waitTime) {
        while (true) {
            foreach (GameObject toy in toys) {
                Rigidbody rb = toy.GetComponent<Rigidbody>();
                if (rb != null) {
                    Vector3 direction = transform.up + new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f),
                        Random.Range(-50f, 50f) );
                    rb.AddForce(direction * force);
                }
                Color col = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                toy.GetComponent<Renderer>().material.color = col;
              //  yield return new WaitForSeconds(waitTime);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }


    // Update is called once per frame
    void Update() {

    }
}
