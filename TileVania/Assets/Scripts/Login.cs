using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputFUser;
    public InputField inputFPassword;
  
    void Start()
    {
        
    }

    public void SetLogin()
    {
        if (inputFUser.text == "admin" && inputFPassword.text == "123")
        {
            SceneManager.LoadScene("Level 1");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
