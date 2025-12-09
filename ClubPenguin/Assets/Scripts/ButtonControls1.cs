using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public string[] gameNames;
    [SerializeField] private int selectedGameIndex = 0;

    public void loadSceneButton()
    {
        SceneManager.LoadScene(gameNames[selectedGameIndex]);
        //pauseMenu.SetActive(false);
        //Time.timeScale = 1f;
    }

    public void quitGameButton()
    {
        Application.Quit();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
