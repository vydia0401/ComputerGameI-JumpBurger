using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
	private Vector3 target_Offset;

    private void Start()
    {
        target_Offset = transform.position - target.position;
    }

    void Update()
    {
            transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 1f);
    }
}
