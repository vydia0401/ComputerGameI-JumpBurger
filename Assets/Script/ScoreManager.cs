using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text player1ScoreText;
    public Text player2ScoreText;
    public int player1Score = 0;
    public int player2Score = 0;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start() {
        player1ScoreText.text = player1Score.ToString() + " POINT";
        player2ScoreText.text = player2Score.ToString() + " POINT";
    }

    public void AddPoints(int player) {
        if (player == 1) {
            player1Score += 1;
            player1ScoreText.text = player1Score.ToString() + " POINTS";
        } else if (player == 2) {
            player2Score += 1;
            player2ScoreText.text = player2Score.ToString() + " POINTS";
        }
    }
}
