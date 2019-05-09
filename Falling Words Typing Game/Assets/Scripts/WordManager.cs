using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;
    public GameObject gameOverdisplay;
    public static bool hasActiveWord;
	public static Word activeWord;

    public BuffDisplay buffDisplay;

    public static int initialPlayerHealth;
    public static float fallSpeed;

    private const int SPAWNWORDVAL = 3;
    private const int DEDUCTHPVAL = 4;

    public Difficulty difficultyValue = Difficulty.Easy;

    public enum Difficulty
    {
        Easy, Medium, Hard
    }

    void setDifficulty()
    {
        if(difficultyValue == Difficulty.Easy)
        {
            fallSpeed = 1f;
        }
        else if (difficultyValue == Difficulty.Medium)
        {
            fallSpeed = 2f;
        }
        else if (difficultyValue == Difficulty.Hard)
        {
            fallSpeed = 3f;
        }

        initialPlayerHealth = Player.healthPoints;
    }

	public void AddWord ()
	{
        Word word;

        if (difficultyValue == Difficulty.Easy)
        {
            word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
            Debug.Log(word.word);
        }

        else if (difficultyValue == Difficulty.Medium)
        {
            word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord(), Random.Range(0, 5));
            Debug.Log(word.word);
        }
        else
        {
            word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord(), Random.Range(0, 5));
            word.display.agility = true;
            if (word.TypeValue == 4)
            {
                word.display.SetColorRed();
            }
            Debug.Log(word.word);
        }

        words.Add(word);
	}

    //Pass in the active word's transform so more words can be spawned at the spot
    public void SpawnMoreWord(Transform activeWordtransform)
    {
        Word word;
        word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord(activeWordtransform), Random.Range(0, 5));
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
            //Check if the word is a buff or not
            bool buffResult = activeWord.checkBuff();
            if (buffResult)
            {
                buffDisplay.displayBuffText(activeWord.word);
            }
            //If difficulty is medium or hard and the word's typeValue is 3
            //Spawn more word after completing it
            if(difficultyValue != Difficulty.Easy && activeWord.TypeValue == SPAWNWORDVAL)
            {
                SpawnMoreWord(activeWord.display.transform);
            }
            if(difficultyValue == Difficulty.Hard && activeWord.TypeValue == DEDUCTHPVAL)
            {
                Player.healthPoints--;
            }
            activeWord.display.RemoveWord();
            words.Remove(activeWord);
		}
	}

    public void EndGame()
    {
        gameOverdisplay.SetActive(true);
        SceneManager.LoadScene("EndScreen");
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
                    //The word must also not be a speedbuff
                    if (Player.healthPoints != 0 && words[i].display.hasMinus == false && words[i].word != "speedbuff" && words[i].TypeValue != DEDUCTHPVAL)
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
