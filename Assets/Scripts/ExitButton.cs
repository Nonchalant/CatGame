using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour {

    private Button button;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(ExitGame);
    }

    private void ExitGame() {
        Debug.Log("ExitButton ExitGame");

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
