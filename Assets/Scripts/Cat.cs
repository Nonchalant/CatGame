using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCollision : MonoBehaviour {
    public GameObject NextCat;

    void Update() {
        if(GameManager.isGameOver) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.tag == gameObject.tag) {

            if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID()) {
                if (NextCat != null) {
                    Instantiate(NextCat, transform.position, transform.rotation);
                } else {
                    GameManager.isGameClear = true;
                }
            }

            Destroy(gameObject);
        }
    }
}
