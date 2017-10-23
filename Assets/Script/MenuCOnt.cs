using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCOnt : MonoBehaviour {
    public GameObject playButton;
    public GameObject muteButton;
    public GameObject menu;
    public GameObject Ok;
    public GameObject cameras;
    public Button SoundButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GetOption()
    {
        playButton.SetActive(false);
        muteButton.SetActive(true);
        menu.SetActive(false);
        Ok.SetActive(true);
    }
    public void okay()
    {
        playButton.SetActive(true);
        menu.SetActive(true);
        Ok.SetActive(false);
        muteButton.SetActive(false);
    }
    public void Mute()
    {

    }
}
