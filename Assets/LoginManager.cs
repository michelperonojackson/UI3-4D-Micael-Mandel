using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string password = "contraseña";
    public InputField inputPassword;
    
    public void Saludar()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (inputPassword.text == password)
        {
            Debug.Log("Accsess granted");
            
        }
        else
        {
            Debug.Log("Accsess denied");
        }
    }
}
