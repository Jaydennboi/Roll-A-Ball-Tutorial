using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Targert;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - Targert.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Targert.transform.position + _offset;
    }
}
