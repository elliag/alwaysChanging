using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getScene(){
        return SceneManager.GetActiveScene().name;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(sceneName: "Main_Menu");
    }

    public void LoadTutorial1()
    {
        SceneManager.LoadScene(sceneName: "Tutorial1");
    }

    public void LoadTutorial2()
    {
        SceneManager.LoadScene(sceneName: "Tutorial2");
    }

    public void LoadTutorial3()
    {
        SceneManager.LoadScene(sceneName: "Tutorial3");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(sceneName: "Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(sceneName: "Level2");
    }
}
