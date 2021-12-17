using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public static string nameOfPlayer;
    public string saveName;
    public TMP_Text inputText;
    public TMP_Text loadedName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = nameOfPlayer;
    }

    public void SetName()
    {
        saveName = inputText.text;
        nameOfPlayer = saveName;
        PlayerPrefs.SetString("name", saveName);
    }
}
