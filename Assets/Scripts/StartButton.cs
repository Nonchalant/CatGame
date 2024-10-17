using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    private Button button;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
    }

    private void StartGame() {
        Debug.Log("StartButton StartGame");
        SceneManager.LoadScene("GameScene");
    }
}
