using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;
using TMPro;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TMP_InputField userInput;

    //public GameObject playerName;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void GetName()
    {
        
        
        
     
    }
   public void SaveName()
    {
        userName.text = userInput.text;
        PlayerPrefs.SetString("userName", userName.text);
       
        
    }
  


}
