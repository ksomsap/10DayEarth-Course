using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public GameObject earth;
    public float speed;

    private float lifeTime = 0f;
    void Start()
    {
        earth = GameObject.Find("Earth");
        transform.up = new Vector2(transform.position.x, transform.position.y);
    }

    void Update()
    {
        lifeTime += Time.deltaTime;
        if(earth != null)
            transform.position = Vector2.MoveTowards(transform.position, earth.transform.position, speed * Time.deltaTime);

        if(lifeTime > 5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        ScoreManager.scoreValue++;
        Destroy(gameObject);
    }
}
