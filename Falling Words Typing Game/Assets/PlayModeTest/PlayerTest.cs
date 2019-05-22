using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class PlayerTest
    {
        [UnityTest]
        public IEnumerator DepleteInvinBarAfterUseTest()
        {
            var player = new GameObject().AddComponent<Player>();
            player.playerUI = new GameObject().AddComponent<PlayerUI>();
            player.playerUI.scoreText = new GameObject().AddComponent<Text>();
            player.playerUI.invinBarText = new GameObject().AddComponent<Text>();
            player.playerUI.invinPromptText = new GameObject().AddComponent<Text>();
            player.playerUI.healthBarFill = new GameObject().AddComponent<RectTransform>();
            player.playerUI.invinBarFill = new GameObject().AddComponent<RectTransform>();
            player.playerUI.player = player;

            player.invinPoints = 20;

            player.useInvinBuff();

            yield return new WaitForSeconds(10);

            Assert.AreEqual(0, player.invinPoints);
        }

        [UnityTest]
        public IEnumerator InitialPlayerHpTest()
        {
            var player = new GameObject().AddComponent<Player>();

            yield return null;

            Assert.AreEqual(5, player.healthPoints);
        }

        [UnityTest]
        public IEnumerator InitialPlayerInvinPointsTest()
        {
            var player = new GameObject().AddComponent<Player>();
            
            yield return null;

            Assert.AreEqual(0, player.invinPoints);
        }
    }
}
