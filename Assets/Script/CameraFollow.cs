using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
	private Vector3 target_Offset;

    public InstantiateLevels instantiateLevels;

    private void Start()
    {
        target_Offset = transform.position - target.position;
        target_Offset.y -= 4f;
    }

    void Update()
    {
            //transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 0.1f);
        transform.position = Vector3.Lerp(transform.position, instantiateLevels.CameraPosition+target_Offset, 0.1f);
    }
}
