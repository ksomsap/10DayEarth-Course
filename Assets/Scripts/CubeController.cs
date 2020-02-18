using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 target = Vector3.forward;
    float speed = 5f;
    void Start()
    {
        transform.RotateAround(this.transform.position, target, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(this.transform.position, target, speed * Time.deltaTime);
    }
}
