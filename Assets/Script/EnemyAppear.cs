using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppear : MonoBehaviour
{
    public GameObject enemyObj;

public float min = 2f;
public float max = 3f;

void Start(){
min = transform.position.x-15;
max = transform.position.x+15;
}

void Update(){
transform.position = new Vector3(Mathf.PingPong(Time.time*2 ,max-min)+min, transform.position.y, transform.position.z);
}
    void OnTriggerEnter(){
// call dmg script or points
    }
}
