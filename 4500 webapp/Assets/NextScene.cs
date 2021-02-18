using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
public class NextScene : MonoBehaviour
{
    public string sceneName; 
    // Start is called before the first frame update
    void Start()
    {
       // sceneName = "2nd Scene";
    }
    public void buttonBehavior()
    {
        Debug.Log("Clicked"); 
        SceneManager.LoadScene(sceneName);   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
