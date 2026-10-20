using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public TMP_Text timeText;
    public RectTransform timeBar;
    public GameObject restarButton;
    public GameObject player;

    float timer = 10;
   // float fps;
    float timerP;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        //fps = 1f / Time.deltaTime;

        timer -= Time.deltaTime;
        timerP = Mathf.Max(0, timer);
        //print (fps);

        if (timerP == 0)
        {
            GameOver();
        }
        UpdateUI();
    }
    void UpdateUI()
    {
        //timeText.text = fps.ToString ();
        timeText.text = Mathf.Ceil(timerP).ToString ();
    }
    void GameOver()
    {
        player.SetActive (false);
        enabled = true;
    }
}
