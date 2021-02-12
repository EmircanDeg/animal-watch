using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class girislevelci : MonoBehaviour
{
    public string level;
    public GameObject input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LevelGO(){
        level = input.GetComponent<Text>().text;
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
