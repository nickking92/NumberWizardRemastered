using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    Text TextComponent;
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;
    int guessCounter;
    // Use this for initialization
    void Start() {

        StartGame();
    }


    void StartGame()
    {

        NextGuess();

    }

    public void GuessCount()
    {
        guessCounter++;
        if (guessCounter == 4)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void clickedForHigher()
    {

        if (guess < 1000)
        {
            min = guess + 1;
        }
        else
        {
            min = guess;
        }
                NextGuess();
            
    }
    public void clickedForLower()
    {
        max = guess-1;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max);
        //guess = (max + min) / 2;
        guessText.text = guess.ToString();

    }


}
