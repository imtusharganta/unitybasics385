using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
    float secRemaining = 300f;
    bool timerEnded = false;
    float colorTimer = 0f;

    void Start()
    {
        slider.maxValue = secRemaining;
        slider.value = secRemaining - 5f;
    }

    void Update()
    {
        if (!timerEnded)
        {
            if (secRemaining > 1)
            {
                secRemaining -= Time.deltaTime * 5f;
                slider.value -= Time.deltaTime * 5f;

                // Alternate colors every 5 seconds
                colorTimer += Time.deltaTime;
                if (colorTimer >= 5f)
                {
                    colorTimer = 0f;
                    if (this.GetComponent<Text>().color == Color.white)
                    {
                        this.GetComponent<Text>().color = Color.red;
                    }
                    else
                    {
                        this.GetComponent<Text>().color = Color.white;
                    }
                }

                float minutes = Mathf.FloorToInt(secRemaining / 60);
                float seconds = Mathf.FloorToInt(secRemaining % 60);
                this.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                this.GetComponent<Text>().color = Color.red;
                timerEnded = true;
            }
        }
    }
}
