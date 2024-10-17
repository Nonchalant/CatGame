using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour {

    static public bool isGameOver = false;
    static public bool isGameClear = true;

    public GameObject gameOver;
    public GameObject gameClear;
    public GameObject player;

    private CancellationTokenSource source;

    void Start() {
        isGameOver = false;
        isGameClear = false;
    }

    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }

        player.SetActive(!(isGameOver || isGameClear));
        gameOver.SetActive(isGameOver);
        gameClear.SetActive(isGameClear);
    }

    async void OnTriggerEnter2D(Collider2D collider) {
        source = new CancellationTokenSource();
        CancellationToken token = source.Token;

        try {
            await UniTask.Delay(TimeSpan.FromSeconds(2), cancellationToken: token);
            isGameOver = true;
        } catch (OperationCanceledException) {
            Debug.Log("Continue");
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        source.Cancel();
    }
}
