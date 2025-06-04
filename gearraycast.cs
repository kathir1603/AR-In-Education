using UnityEngine;
using UnityEngine.SceneManagement;

public class gearraycast : MonoBehaviour
{
    Ray r;
    RaycastHit hit;
    public LayerMask mask;
    public LayerMask mask2;
    public LayerMask mask3;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        r = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(r, out hit, 10000, mask))
            {
                SceneManager.LoadScene(14);
            }
            if (Physics.Raycast(r, out hit, 10000, mask2))
            {
                Debug.Log("hit");
                SceneManager.LoadScene(16);
            }
            if (Physics.Raycast(r, out hit, 10000, mask3))
            {
                SceneManager.LoadScene(15);
            }
            
        }

    }
}
