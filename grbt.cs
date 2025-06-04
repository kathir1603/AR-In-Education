using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class grbt : MonoBehaviour
{
    public Button grbutton;
    // Start is called before the first frame update
    
    void Start()
    {
        grbutton.onClick.AddListener(grnxt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void grnxt()
    {
        SceneManager.LoadScene(17);
    }
}
