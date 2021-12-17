using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    //public GameObject player;
    public int _score;

    [SerializeField] TMP_Text scoreboardText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CharacterScript.score != null)
        {
            //do nothing
            _score = CharacterScript.score;
        }
        scoreboardText.text = "Score: " + _score.ToString() ;

    }
}
