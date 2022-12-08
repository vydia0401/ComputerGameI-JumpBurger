using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLevels : MonoBehaviour
{
    public GameObject ground;
    private int numBurgers = 0;
    private Vector2 burgerPosition;
    public GameObject newestBurger;

    public Vector3 CameraPosition;


    void Start() {
        burgerPosition.x = 430f;
        burgerPosition.y = 2f;
        Invoke("SpawnLevels", 5f);
    }

    void SpawnLevels() {
        if (burgerPosition.x <= 10) {
            burgerPosition.x += 5f;
        } else if (burgerPosition.x >= 810) {
            burgerPosition.x -= 5f;
        } else {
            burgerPosition.x = burgerPosition.x += Random.Range(-5, 5);
        }
        burgerPosition.y = burgerPosition.y += 4f;

        GameObject newBurger = (GameObject)Instantiate(ground);
        newBurger.tag = "unvisitConcrete";
        newBurger.transform.position = new Vector2(burgerPosition.x, burgerPosition.y);
        CameraPosition = newBurger.transform.position;
        newestBurger = newBurger;
        numBurgers++;
        NextLevelSpawn();

    }
    void NextLevelSpawn() {
        int max;
        if (ScoreManager.instance.player1Score > ScoreManager.instance.player2Score) {
            max = ScoreManager.instance.player1Score;
        } else {
            max = ScoreManager.instance.player2Score;
        }

        if (max + 3 <= numBurgers) {
            Invoke("SpawnLevels", 7f);
        } else {
            Invoke("SpawnLevels", 2f);
        }
    }
}
