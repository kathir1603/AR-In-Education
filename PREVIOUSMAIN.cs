
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class previousmain: MonoBehaviour
{
    public Button prevm;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hit");
        prevm.onClick.AddListener(previousmbt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void previousmbt()
    {
        Debug.Log("hit");
        SceneManager.LoadScene(4);
    }
}
