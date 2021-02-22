using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public InputField playerHandle;
    public InputField playerAge;
    public string playerName;
    public int myAge;

    public void SetInfo()
    {
        playerName = playerHandle.text;
        myAge = int.Parse(playerAge.text);
    }

    public void GameStart()
    {
        PlayerPrefs.SetString("ThisPlayer", playerName);
        PlayerPrefs.SetInt("ThisAge", myAge);
        SceneManager.LoadScene("Game");
    }

}
