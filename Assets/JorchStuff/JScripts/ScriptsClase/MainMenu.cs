using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    
    public void OnClickPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    

    public void OnClickQuitButton()
    {
        //Solo funciona en versión ejecutable
        Application.Quit();
    }
}

