using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public GameObject player;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) {
        Debug.Log(player.name);
        int player1Score = ScoreManager.instance.player1Score;
        int player2Score = ScoreManager.instance.player2Score;
        if (collision.gameObject.name == "baseGround" && player1Score > 0 && player2Score > 0) {
            anim.Play("GameOverAnimation");
        } else if (player.name == "Player1") {
            if (collision.gameObject.tag == "unvisitConcrete") {
                ScoreManager.instance.AddPoints(1);
                collision.gameObject.tag = "player2Unvisted";
            }
            else if (collision.gameObject.tag == "player1Univisted" ) {
                ScoreManager.instance.AddPoints(1);
                collision.gameObject.tag = "untagged";
            }
        } else if(player.name == "Player2") {
            if (collision.gameObject.tag == "unvisitConcrete") {
                ScoreManager.instance.AddPoints(2);
                collision.gameObject.tag = "player1Unvisted";
            }
            else if (collision.gameObject.tag == "player2Univisted") {
                ScoreManager.instance.AddPoints(2);
                collision.gameObject.tag = "untagged";
            }
        }
    }
}
