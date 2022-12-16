using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnePlayer : MonoBehaviour
{
    public GameObject player2;
    // Start is called before the first frame update
    public void DeletePlayer2()
    {
        player2.SetActive(false);
    }

}
