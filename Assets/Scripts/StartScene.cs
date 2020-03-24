using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void startGame()
    {
        SceneManager.LoadScene("Main");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
