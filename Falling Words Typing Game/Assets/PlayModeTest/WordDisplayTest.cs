using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class WordDisplayTest
    {
        [UnityTest]
        public IEnumerator WordDisplaySetWordTest()
        {
            var wordDisplay = new GameObject().AddComponent<WordDisplay>();

            wordDisplay.text = new GameObject().AddComponent<Text>();

            wordDisplay.SetWord("Hello");

            Assert.AreEqual("Hello", wordDisplay.text.text);

            yield return null;
        }

        [UnityTest]
        public IEnumerator WordDisplayRemoveLetterTest()
        {
            var wordDisplay = new GameObject().AddComponent<WordDisplay>();

            wordDisplay.text = new GameObject().AddComponent<Text>();

            wordDisplay.SetWord("Hello");

            wordDisplay.RemoveLetter();

            Assert.AreEqual("ello", wordDisplay.text.text);

            yield return null;
        }

        [UnityTest]
        public IEnumerator WordDisplayRemoveWordTest()
        {
            var wordDisplay = new GameObject().AddComponent<WordDisplay>();
            wordDisplay.effect = new GameObject();
            wordDisplay.text = new GameObject().AddComponent<Text>();

            wordDisplay.SetWord("Hello");

            wordDisplay.RemoveWord();

            yield return null;

            Assert.IsTrue(wordDisplay == null);
        }
    }
}
