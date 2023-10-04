using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnTriggerEnter2D(Collider2D colilision)
    {
        SceneManager.LoadScene("Lose");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
