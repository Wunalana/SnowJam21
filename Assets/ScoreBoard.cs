using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    //public GameObject player;
    public int _score;

    [SerializeField] Text scoreboardText;
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
        scoreboardText.text = _score.ToString() ;

    }
}
