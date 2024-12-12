using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI scoreTmp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreTmp = this.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTmp.text = BirdScript.score.ToString();
    }
}
