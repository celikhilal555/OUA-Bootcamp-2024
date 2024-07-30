using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public GameObject panel;
    
    public void Baslatma()
    {
        panel.SetActive(false);
    }

    public void Cikis()
    {
        Application.Quit();
    }


}
