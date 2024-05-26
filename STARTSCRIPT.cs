using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STARTSCRIPT : MonoBehaviour
{
    public void Baslat()
    {
        SceneManager.LoadScene(1);
    }
    public void Cikis()
    {
        Application.Quit();
        
        
    }

}
