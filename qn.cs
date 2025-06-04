
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class qn : MonoBehaviour
{
    public Button questionbt;
    // Start is called before the first frame update
    void Start()
    {
        questionbt.onClick.AddListener(question);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void question()
    {
        SceneManager.LoadScene(13);
    }
}
