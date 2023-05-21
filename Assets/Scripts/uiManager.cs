using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class uiManager : MonoBehaviour
{
    public Text scoreText;
    public bool gameOver = false;
    int score;
    public Background background;
    public Car_spawn spawn;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null){
            scoreText.text = "Score: " + score;
        }
    }

    public void Play() {
        SceneManager.LoadScene("Main");  // Faz upload de uma nova scene
    }

    void scoreUpdate() {
        if(!gameOver){
            score += 1;
        }
    }

    public void gameOverActivated(){
        gameOver = true;
        if (background != null) {
            background.speed = 0f;
        }
        spawn.timer = 100f;
        Invoke("returnMenu", 4f);
    }

    public void returnMenu(){
        SceneManager.LoadScene("menu");
    }

    public void exit(){
        Application.Quit();
    }

    public void Pause(){
        if (Time.timeScale == 1){
            Time.timeScale = 0;
        }

        else if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }
}
