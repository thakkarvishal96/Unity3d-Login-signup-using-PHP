using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject LoginButtonUI, RegisterButtonUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenLogin()
    {
        LoginButtonUI.SetActive(true);
        RegisterButtonUI.SetActive(false);
    }
    public void OpenRegistration()
    {
        RegisterButtonUI.SetActive(true);
        LoginButtonUI.SetActive(false);
    }
}
