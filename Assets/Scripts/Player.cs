using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float maxX = 3.5f;
    public float speed = 3f;
    public float plus = 0.2f;

    public GameObject[] CatList;
    public GameObject next;

    const float spaceDelay = 1.0f;
    private float time = 1.0f;

    void Update() {
        time -= Time.deltaTime;

        if(transform.position.x < maxX) {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime * 5;
            }
        }

        if(transform.position.x > -maxX) {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
            }
        }
            
        if (time < 0 && Input.GetKeyDown(KeyCode.Space)) {
            time = spaceDelay;
            transform.position += new Vector3(plus, 0, 0) * Time.deltaTime * speed;
            plus *= -1;

            Instantiate(CatList[Next.nextID], transform.position, transform.rotation);
            next.GetComponent<Next>().Change();
        }
    }
}
