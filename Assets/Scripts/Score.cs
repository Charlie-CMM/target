using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int newScore = 0;

    public void updateScore(int score)
    {
        newScore += score;
        GameObject.Find("Wall").GetComponent<Score>().score.text = newScore.ToString();
    }
}
