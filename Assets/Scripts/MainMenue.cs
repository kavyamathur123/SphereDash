using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void NewGame(){

    }
}
