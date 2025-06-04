
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class visual : MonoBehaviour
{
    public Button visualize;
    // Start is called before the first frame update
    void Start()
    {
        visualize.onClick.AddListener(next);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void next()
    {
        SceneManager.LoadScene(1);
    }
}
