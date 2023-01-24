using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public int computerScore { get; private set; }
    public Text computerScoreText;

    public int playerScore { get; private set; }
    public Text playerScoreText;

    public Paddle PlayerPaddle;

    public Paddle ComputerPaddle;

    
    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        PlayerPaddle.ResetPosition();
        ComputerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        Debug.Log("pscore");
        SetPlayerScore(playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        Debug.Log("cscore");
        SetComputerScore(computerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

}
