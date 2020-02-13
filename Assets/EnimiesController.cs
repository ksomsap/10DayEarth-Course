using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimiesController : MonoBehaviour
{

    public GameObject earth;
    public float speed;

    private void Start()
    {
        earth = GameObject.Find("Earth");
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,earth.transform.position,speed*Time.deltaTime);

        Vector3 MeoPosition = earth.transform.position;
       

        Vector2 direction = new Vector2(
            MeoPosition.x = transform.position.x,
            MeoPosition.y = transform.position.y            
            );

        transform.up = direction;
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
