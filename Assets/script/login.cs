using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswordInput;
    public Button LoginButton;

    // Start is called before the first frame update
    void Start()
    {

        LoginButton.onClick.AddListener(() => {
            StartCoroutine( main.Instance.web.Login(UsernameInput.text,PasswordInput.text));
        });
    }
   
}
