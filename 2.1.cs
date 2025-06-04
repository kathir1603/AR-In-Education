
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class next21: MonoBehaviour
{
    public Button next1;
    // Start is called before the first frame update
    void Start()
    {
        next1.onClick.AddListener(nextbt1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void nextbt1()
    {
        SceneManager.LoadScene(2);
    }
}
