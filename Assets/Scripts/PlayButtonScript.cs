using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public void OnplayButtonClicked(){
        SceneManager.LoadScene("Game_Scene");
        Debug.Log("Game Scene Loaded Successfully");
    }
}
