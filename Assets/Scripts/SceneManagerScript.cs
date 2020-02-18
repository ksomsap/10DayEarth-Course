using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    static public bool startGame;
    public GameObject startScene;
    public GameObject endScene;

    public GameObject earth;
    void Start()
    {
        earth = GameObject.Find("Earth");
        startGame = false;
        startScene.gameObject.SetActive(true);
        endScene.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startGame = true;
            startScene.gameObject.SetActive(false);
        }

        if(earth == null)
        {
            endScene.gameObject.SetActive(true);
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
