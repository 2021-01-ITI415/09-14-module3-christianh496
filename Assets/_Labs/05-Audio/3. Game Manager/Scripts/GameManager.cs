using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //what level is the game in
    //load and unload game levels
    // track game state
    //generate other persistent systems
    //

    private string _currentLevelName = string.Empty;

	private void Start()
	{
        LoadLevel("Main");
	}

	void OnLoadOperationComplete(AsyncOperation ao)
    {
        Debug.Log("Load Complete.");   
    }

    void OnUnLoadOperationComplete(AsyncOperation ao)
    {
        Debug.Log("Unload Operation Complete");
    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName);
        ao.completed += OnLoadOperationComplete;
        _currentLevelName = levelName;

    }

    public void UnLoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        ao.completed += OnUnLoadOperationComplete;
    }


}
