using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallGameOver : MonoBehaviour
{

    public Animator anim;
    public GameObject GameOverScreen;



    public void OnTriggerEnter(Collider col) {

        if (col.gameObject.tag == "Player")
        {
            GameOverScreen.SetActive(true);
            anim.Play("zoomOut");
        }
    }

}
