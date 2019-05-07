using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;
    public GameObject gameOverdisplay;
    public static bool hasActiveWord;
	public static Word activeWord;

    public BuffDisplay buffDisplay;

    public static int initialPlayerHealth;
    public static float fallSpeed;

    public Difficulty difficultyValue;

    public enum Difficulty
    {
        Easy, Medium, Hard
    }

    void setDifficulty()
    {
        if(difficultyValue == Difficulty.Easy)
        {
            fallSpeed = 1f;
            Player.healthPoints = 5;
        }
        else if (difficultyValue == Difficulty.Medium)
        {
            fallSpeed = 2f;
            Player.healthPoints = 3;
        }
        else if (difficultyValue == Difficulty.Hard)
        {
            fallSpeed = 3f;
            Player.healthPoints = 1;
        }

        initialPlayerHealth = Player.healthPoints;
    }

	public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
            if (activeWord != null)
            {
                if (activeWord.GetNextLetter() == letter)
                {
                    activeWord.TypeLetter();
                }
            }
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
            Score.score++;
            bool buffResult = activeWord.checkBuff();
            if (buffResult)
            {
                buffDisplay.displayBuffText(activeWord.word);
            }
            activeWord.display.RemoveWord();
			words.Remove(activeWord);
		}
	}

    public void EndGame()
    {
        gameOverdisplay.SetActive(true);
    }

    public void Start()
    {
        setDifficulty();
    }

    public void Update()
    {
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].display != null)
            {
                //if words leave the screen
                if (words[i].display.transform.position.y < -5)
                {
                    //check if there's an active word
                    if (activeWord != null)
                    {
                        //if there is, and it is the same as the word leaving the screen
                        //remove the active word and set it to false
                        if (activeWord.word == words[i].display.initialText)
                        {
                            hasActiveWord = false;
                            words.Remove(activeWord);
                        }
                    }

                    //check if player hp is not 0 and the word has not minus hp before
                    if (Player.healthPoints != 0 && words[i].display.hasMinus == false)
                    {
                        Player.healthPoints--;
                        words[i].display.hasMinus = true;
                    }
                    //Remove the word display
                    words[i].display.RemoveWord();
                    //Remove the word
                    words.Remove(words[i]);
                }
            }
        }
    }
}
