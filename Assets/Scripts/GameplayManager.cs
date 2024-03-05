using TMPro;
using UnityEngine;



public class GameplayManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerTextBox;
    [SerializeField] private TextMeshProUGUI scoreTextBox;
    [SerializeField] private float timeLimit;
    [SerializeField] private GameObject EndGamePanel;
    public int towersCompleted;
    private bool timerStarted;
    


    void Start()
    {
        // initialize the score to 0 for player to see
        // set the timelimit text
        updateDisplay();
        EndGamePanel.SetActive(false);

        StartCountdown();  // REMOVE THIS (this is for testing purposes)
    }


    public void StartCountdown()
    {
        if (!timerStarted)
        {
            // Invoke the Countdown function every second, starting after 1 second
            InvokeRepeating("Countdown", 1f, 1f);

            timerStarted = true;
        }
    }

    private void Countdown() // this is being repeated every 1 second once the timer bool becomes true
    {
        if ((timeLimit > 0))
        {
            // Decrease the countdown time by 1 second
            timeLimit -= 1f;

            // Update the display text
            updateDisplay();
        }

        if (timeLimit <= 0)
        {
            CancelInvoke("Countdown");
            print("Stop Timer");
            timerStarted = false;
            EndTheGame();
        }

    }



    public void updateDisplay()   // updates the text for both the Timer and the Score
    {
        //updates score text with the current score
        scoreTextBox.text = towersCompleted.ToString();

        // update the timerText with the time left
        timerTextBox.text = $"{Mathf.Floor(timeLimit / 60):0}:{timeLimit % 60:00}";

    }

    public void increaseScore()  // increases the score (for completing towers) And updates the display text 
    {
        towersCompleted++;
        updateDisplay();
    }

    public void EndTheGame()
    {
        print("Game Over");
        EndGamePanel.SetActive(true);
        TextMeshProUGUI finalScoreDisplay = EndGamePanel.GetComponentInChildren<TextMeshProUGUI>();
        finalScoreDisplay.text = "Final Score: " + towersCompleted.ToString();

    }
}
