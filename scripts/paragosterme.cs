using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class paragosterme : MonoBehaviour
{
    public int para;
    Scene m_Scene;
    public string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        para = PlayerPrefs.GetInt("parag");
        Text txt = GameObject.Find ("Canvas/paragosterme/Text").GetComponent<Text>();
        txt.text = para.ToString();

        m_Scene = SceneManager.GetActiveScene();
        currentScene = m_Scene.name;
        Text txt2 = GameObject.Find ("Canvas/levelgosterme/Text").GetComponent<Text>();
        txt2.text = currentScene;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
