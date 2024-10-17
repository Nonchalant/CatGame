using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour {
    
    private void Start() {
        Debug.Log("TitleScene Start");
        GetComponent<UnityEngine.Camera>().backgroundColor = Color.red;
    }

    private void Update() {}
}
