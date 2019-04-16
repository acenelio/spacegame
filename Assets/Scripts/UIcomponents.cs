using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class UIcomponents  {
    [Serializable]
    public class Hud {
        [Header("Text")]
        public Text txtCoinCount;

        [Header("Other")]
        public GameObject panelHud;
    }

[Serializable]
public class LevelCompleatePanel  {
    [Header("Text")]
    public Text txtScore;

    [Header("Other")]
    public GameObject LCPanel;
    }

[Serializable]
public class GameOverPanel  {
    [Header("Text")]
    public Text txtScore;

    [Header("Other")]
    public GameObject GOPanel;
    }

    public Hud hud;
    public LevelCompleatePanel LCPanel;
    public GameOverPanel gameOverPanel;
}