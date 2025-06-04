
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class previous : MonoBehaviour
{
    public Button prev;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hit");
        prev.onClick.AddListener(previousbt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void previousbt()
    {
        Debug.Log("hit");
        SceneManager.LoadScene(6);
    }
}
