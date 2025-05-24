using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public Text scoreText;
    public Text endGame;
    int score = 0;
    public AudioSource audioSource;
    public AudioClip coinRecieved;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        restartGame();
    }
    public void totalScore ()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log(score);
        audioSource.PlayOneShot(coinRecieved, 1);

        if(score == 8)
        {
            endGame.gameObject.SetActive(true);
        }
    }
    void restartGame()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
