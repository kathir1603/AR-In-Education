
using UnityEngine;
using UnityEngine.UI;

public class scoreForMAinScript : MonoBehaviour
{
    score s;
    public Text main_score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score.score_point>0)
        {
            main_score.text=score.score_point.ToString();
        }
    }
}
