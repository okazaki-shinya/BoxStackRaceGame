using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static bool GameOver { get; set; } = false;

    private void Update() {
        if (GameOver) {
            Debug.Log("Game over");
        }
    }
}
