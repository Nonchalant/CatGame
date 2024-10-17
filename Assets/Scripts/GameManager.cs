using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    static public bool isGameOver = false;
    static public bool isGameClear = true;

    public GameObject gameOver;
    public GameObject gameClear;
    public GameObject player;

    private bool hasUnstableObject = false;
    private float time = 0.0f;

    void Start() {
        isGameOver = false;
        isGameClear = false;
    }

    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }

        if(hasUnstableObject) {
            time += Time.deltaTime;
        }

        if(time > 2.0f) {
            isGameOver = true;
        }

        if(isGameOver) {
            player.SetActive(false);
            gameOver.SetActive(true);
        } else {
            player.SetActive(true);
            gameOver.SetActive(false);
        }

        if (isGameClear) {
            player.SetActive(false);
            gameClear.SetActive(true);
        } else {
            player.SetActive(true);
            gameClear.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
        hasUnstableObject = true;
    }

    void OnTriggerExit2D(Collider2D collider) {
        hasUnstableObject = false;
        time = 0.0f;
    }
}
