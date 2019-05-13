using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Word {

	public string word;
	private int typeIndex;
    public Text buffText;
	public WordDisplay display;
    private int typeValue;
    public GameObject effect;

	public Word (string _word, WordDisplay _display)
	{
		word = _word;
		typeIndex = 0;

		display = _display;
		display.SetWord(word);
	}

    public Word(string _word, WordDisplay _display, int typeVal)
    {
        word = _word;
        typeIndex = 0;
        typeValue = typeVal;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
	{
        char returnWord = '\0';
        if (typeIndex <= word.Length)
        {
            returnWord = word[typeIndex];
        }

        return returnWord;
	}

	public void TypeLetter ()
	{
		typeIndex++;
		display.RemoveLetter();
	}

	public bool WordTyped ()
	{
		bool wordTyped = (typeIndex >= word.Length);
        
		return wordTyped;
	}

    public int TypeValue
    {
        get
        {
            return typeValue;
        }
        set
        {
            typeValue = value;
        }
    }
}
