
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int score_point = 0;
    public Button correctAnswer;
    //public Text text;
    void Start()
    {
        correctAnswer.onClick.AddListener(switching);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void switching()
    {
        Debug.Log("touched");
        score_point += 1;
        SceneManager.LoadScene(4);

    }
}
