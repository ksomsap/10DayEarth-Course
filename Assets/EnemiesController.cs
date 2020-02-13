using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public GameObject earth;
    public float speed;
    void Start()
    {
        earth = GameObject.Find("Earth");
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, earth.transform.position, speed * Time.deltaTime);

        Vector3 AmaPosition = earth.transform.position;
        AmaPosition = Camera.main.ScreenToWorldPoint(AmaPosition);

        Vector2 direction = new Vector2(
            AmaPosition.x = transform.position.x,
            AmaPosition.y = transform.position.y
        );
        transform.left = direction;
    }
}
