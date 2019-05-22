using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class WordTest
    {
        [UnityTest]
        public IEnumerator CreateWordTest()
        {
            Word word = new Word("Hello");

            yield return null;

            Assert.AreEqual("Hello", word.word);
        }

        [UnityTest]
        public IEnumerator GetNextLetterWordTest()
        {
            Word word = new Word("Hello");

            char nextLetter = word.GetNextLetter();

            yield return null;

            Assert.AreEqual('H', nextLetter);
        }

        [UnityTest]
        public IEnumerator WordTypedTest()
        {
            Word word = new Word("Hello");

            //If word is completely typed
            word.typeIndex = 6;

            yield return null;

            Assert.AreEqual(true, word.WordTyped());
        }
    }
}
