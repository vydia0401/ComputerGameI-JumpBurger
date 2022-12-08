using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public GameObject player;
    public GameObject GameOverScreen;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) {
        int player1Score = ScoreManager.instance.player1Score;
        int player2Score = ScoreManager.instance.player2Score;
        if (collision.gameObject.name == "baseGround" && player1Score > 0 && player2Score > 0) {
            GameOverScreen.SetActive(true);
        } else if (player.name == "Player1") {
            if (collision.gameObject.tag == "unvisitConcrete") {
                ScoreManager.instance.AddPoints(1);
                collision.gameObject.tag = "player2Unvisted";
            }
            else if (collision.gameObject.tag == "player1Unvisted" ) {
                ScoreManager.instance.AddPoints(1);
                collision.gameObject.tag = "Untagged";
            }
        } else if(player.name == "Player2") {
            if (collision.gameObject.tag == "unvisitConcrete") {
                ScoreManager.instance.AddPoints(2);
                collision.gameObject.tag = "player1Unvisted";
            }
            else if (collision.gameObject.tag == "player2Unvisted") {
                ScoreManager.instance.AddPoints(2);
                collision.gameObject.tag = "Untagged";
            }
        }
    }
}
