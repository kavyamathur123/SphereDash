using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartWhenFall : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void OnCollisionEnter(Collision collision){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
