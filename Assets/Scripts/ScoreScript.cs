using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI pipeScoreTmp;
    private TMPro.TextMeshProUGUI mosquitoScoreTmp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TMPro.TextMeshProUGUI[] texts = this.GetComponentsInChildren<TMPro.TextMeshProUGUI>();
        pipeScoreTmp = texts[0];
        mosquitoScoreTmp = texts[1];
    }

    // Update is called once per frame
    void Update()
    {
        pipeScoreTmp.text = BirdScript.pipeScore.ToString();
        mosquitoScoreTmp.text = BirdScript.mosquitoScore.ToString();
    }
}
