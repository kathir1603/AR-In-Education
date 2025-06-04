
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class page: MonoBehaviour
{
    public Button camera;
    //public Button chatbot;
    public Button aboutus;
    // Start is called before the first frame update
    void Start()
    {
        camera.onClick.AddListener(camera1);
       // chatbot.onClick.AddListener(chatbot1);
       aboutus.onClick.AddListener(aboutus1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void camera1()
    {
        SceneManager.LoadScene(5);
    }
    void aboutus1()
    {
        SceneManager.LoadScene(20);
    }

}
