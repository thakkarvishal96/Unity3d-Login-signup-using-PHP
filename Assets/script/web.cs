using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class web : MonoBehaviour
{
    public Text messageText;
    void Start()
    {
        
        //StartCoroutine(GetUser());
        //StartCoroutine(Login("vishal", "123132"));
       // StartCoroutine(RegisterUser("vishal", "123123"));

    }
    //show user from database..
    IEnumerator GetUser() 
    {
        using (UnityWebRequest WWW = UnityWebRequest.Get("http://localhost/unity/Userdata.php"))
        {
            // Request and wait for the desired page.

            yield return WWW.SendWebRequest();


            if (WWW.isNetworkError || WWW.isHttpError)
            {
                Debug.Log(": Error: " + WWW.error);
            }
            else
            {
                Debug.Log(":\nReceived: " + WWW.downloadHandler.text);

                byte[] results = WWW.downloadHandler.data;
            }
        }
    }

    //for Post

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        using (UnityWebRequest WWW = UnityWebRequest.Post("http://localhost/unity/Login.php", form))
        {
            yield return WWW.SendWebRequest();

            if (WWW.isNetworkError || WWW.isHttpError)
            {
                Debug.Log(WWW.error);
                messageText.text = WWW.error;
            }
            else
            {
                Debug.Log(":\nReceived: " + WWW.downloadHandler.text);
                messageText.text = WWW.downloadHandler.text;
            }
        }
    }

    //For Register user..

    public IEnumerator RegisterUser(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        using (UnityWebRequest WWW = UnityWebRequest.Post("http://localhost/unity/RegisterUser.php", form))
        {
            yield return WWW.SendWebRequest();

            if (WWW.isNetworkError || WWW.isHttpError)
            {
                Debug.Log(WWW.error);
                messageText.text = WWW.error;
            }
            else
            {
                Debug.Log(":\nReceived: " + WWW.downloadHandler.text);
                messageText.text = WWW.downloadHandler.text;

            }
        }
    }

}