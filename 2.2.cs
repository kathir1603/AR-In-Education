
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class next22 : MonoBehaviour
{
    public Button next2;
    // Start is called before the first frame update
    void Start()
    {
        next2.onClick.AddListener(nextbt2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void nextbt2()
    {
        Debug.Log("Button clicked!");
        SceneManager.LoadScene(3);
    }
}
