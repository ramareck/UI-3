using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField Input_Password;
    public string password;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Acept()
    {
        if (Input_Password.text == password)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Dennied");
        }
    }
}
