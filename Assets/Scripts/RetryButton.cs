using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour {

    private Button button;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(RetryGame);
    }

    private void RetryGame() {
        GameManager.isGameOver = false;
        GameManager.isGameClear = false;
    }
}
