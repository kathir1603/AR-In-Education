
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class learn : MonoBehaviour
{
    public Button learnbt;
    // Start is called before the first frame update
    void Start()
    {
        learnbt.onClick.AddListener(learn1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void learn1()
    {
        SceneManager.LoadScene(6);
    }
}
