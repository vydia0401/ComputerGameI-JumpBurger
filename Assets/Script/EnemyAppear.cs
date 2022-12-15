using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppear : MonoBehaviour
{
    public GameObject enemyObj;
    public Animator anim;
    public GameObject GameOverScreen;
    public InstantiateLevels instantiateLevels;
    public float min = 2f;
    public float max = 3f;

    void Start(){
    min = transform.position.x-15;
    max = transform.position.x+15;
    anim = GameObject.FindWithTag("MainCamera").GetComponent<Animator>();
    GameOverScreen = GameObject.FindWithTag("GameOver");
    instantiateLevels = GameObject.FindWithTag("MainCamera").GetComponent<InstantiateLevels>();


    }

    void Update(){
    int level = instantiateLevels.numBurgers / 2;
    transform.position = new Vector3(Mathf.PingPong(Time.time*level ,max-min)+min, transform.position.y, transform.position.z);
    }

    public void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player")
        {
            GameOverScreen.transform.GetChild(0).gameObject.SetActive(true);
            anim.Play("zoomOut");
        }
    }

}
