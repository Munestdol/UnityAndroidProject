using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ch_contoller;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ch_contoller.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ch_contoller.transform.position + offset;
    }
}
