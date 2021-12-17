using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalResult : MonoBehaviour
{
    //Text userNameInputText;
    //public GameObject canvas;
    string playerName; //= PlayerName.nameOfPlayer;

    public TMP_Text displayScore;
    int Pscore = CharacterScript.score;
    float timeScore = Timer.startingTime - Timer.currentTime;
    public GameObject Canvas;
    //public Text displayBoard;

    //public InputField Username;
    ////then drag and drop the Username_field


    const int maxPlayer = 5;
    static string[] playerNames = new string[] { "Gracie", "Amy", "Victor", "Mike", "Emily" };
    static float[] playerScores = new float[] { 60, 60, 60, 60, 60 };
    float currentLowScoreOnB = 100;
    float Pscore1 = 100;

    public void QuitGame()
    {
        Debug.Log("QUIT!!");
        Application.Quit();
    }

    public void goToMenu() {
        Application.LoadLevel("Menu");
    }

    //public void GetName()
    //{
    //    userNameInputText = canvas.transform.Find("UserNameInputField/Text").GetComponent<Text>();
    //    playerName = userNameInputText.text;
    //}

    public void DisplayBoard()
    {
        Debug.Log("Board!!");
        //if (Pscore < 100 || Pscore > currentLowScoreOnB)//changes for debug process
        if (Pscore == 999)
        {
            displayScore.text = "\n\nYou are not in Top5! Bye!";
        }
        else
        {
            int i = 0;
            for (; i < maxPlayer; i++)
            {
                if (playerScores[i] < Pscore)
                {
                    break;
                }
            }

            int k;
            for (k = maxPlayer - 1; k > i; k--)
            {
                playerNames[k] = playerNames[k-1];
                playerScores[k] = playerScores[k-1];
            }
            //kp
            playerName = PlayerName.nameOfPlayer;
            playerNames[k] = "You";
            if (playerName == null)
            {
                playerNames[k] = "You";
            }
            else
            {
                playerNames[k] = playerName;
            }
            //'kp
            playerScores[k] = timeScore;
            currentLowScoreOnB = playerScores[4];
            displayScore.text = "is No." + (k+1) + " on the scoreboard!!";
            for (int j = 0; j<maxPlayer; j++)
            {
                    displayScore.text += "\n No." + (j + 1) + "   " + playerNames[j] + "   " + playerScores[j];
            }
        }
    }

    private void ShowScore()
    {
        if (Pscore<100)
        {
            displayScore.text = "Oops you failed to feed Blob!\nHe is still hungry :/";
        }
        else
        {
            displayScore.text = "Congratulations!! \nYou managed to feed Blob in\n" + timeScore + " seconds"; 
            //if (timeScore < currentLowScoreOnB)
            //{
            //    int i = 0;
            //    for(; i<maxPlayer; i++)
            //    {
            //        if (timeScore > playerScores[i])
            //        {
            //            //for(int k = i; k<maxPlayer-1; k++)
            //            //{
            //            //    playerNames[k + 1] = playerNames[k];
            //            //    playerScores[k + 1] = playerScores[k];
            //            //}
            //            //playerNames[i] = Username.text;
            //            //playerScores[i] = timeScore;
            //            //currentLowScoreOnB = playerScores[4];
            //            break;
            //        }
            //    }
            //    //for(int i = 0; i<maxPlayer; i++)
            //    //{
            //    //    displayBoard.text += playerNames[i] + "    " + playerScores[i] + "    \n";
            //    //}
            //    displayBoard.text = "\n You are no." + i + "on the scoreboard!!";
            //}
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("buttonName").GetComponentInChildren<Text>().text = "QUIT";
        ShowScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
