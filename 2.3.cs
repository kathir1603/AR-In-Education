
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class next23 : MonoBehaviour
{
    public Button next;
    // Start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(nextbt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void nextbt()
    {
        SceneManager.LoadScene(4);
    }
}
