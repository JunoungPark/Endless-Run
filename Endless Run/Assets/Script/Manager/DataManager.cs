using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public int score;

    public int level = 1;

    public int bestScore;

    public TextMeshProUGUI scoreGUI;

    public TextMeshProUGUI levelGUI;

    public TextMeshProUGUI bestScoreGUI;

    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        bestScore = PlayerPrefs.GetInt("BestScore");
    }

    public void Save()
    {
        if (score > bestScore)
        {
            bestScore = score;
        }

        PlayerPrefs.SetInt("BestScore", bestScore);

        bestScoreGUI.text = "bestScore : " + bestScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.condtion == true)
        {
            
            timer += Time.deltaTime;

            if (timer >= 1.0f)
            {
                score += level;
                timer -= 1.0f;
            }

            scoreGUI.text = "Score : " + score.ToString();
            levelGUI.text = "Level : " + level.ToString();
            bestScoreGUI.text = "bestScore : " + bestScore.ToString();
        }
    }
}
