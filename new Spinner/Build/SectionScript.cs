using UnityEngine;
using UnityEngine.UI;

public class SectionScript : MonoBehaviour
{
    Color originalColor;
    SpriteRenderer sRenderer;
    Text prizeText;
    Text winText;
    int winner;

    private void OnDisable()
    {
        sRenderer.material.color = originalColor;
    }

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        originalColor = sRenderer.material.color;
        prizeText = GameObject.Find("Prize Text").GetComponent<Text>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        sRenderer.material.color = Color.blue;
        prizeText.text = "You Won: " + gameObject.transform.GetChild(0).name;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        sRenderer.material.color = originalColor;
    }
}