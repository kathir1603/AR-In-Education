
using UnityEngine;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour
{
    Ray r;
    RaycastHit hit;
   public LayerMask mask;
    public LayerMask mask2;
    public LayerMask mask3;
    public LayerMask mask4;
    public LayerMask mask5;
    //public LayerMask mask6;
    public LayerMask mask7;
    public LayerMask mask8;
    public LayerMask mask9;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        r=Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(r, out hit, 10000, mask))
            {
                SceneManager.LoadScene(7);
            }
            if(Physics.Raycast(r,out hit,10000,mask2))
            {
                SceneManager.LoadScene(8);
            }
            if(Physics.Raycast(r,out hit,10000,mask3))
            {
                SceneManager.LoadScene(9);
            }
            if (Physics.Raycast(r, out hit, 10000, mask4))
            {
                SceneManager.LoadScene(10);
            }
            if (Physics.Raycast(r, out hit, 10000, mask5))
            {
                SceneManager.LoadScene(11);
            }
            /*if (Physics.Raycast(r, out hit, 10000, mask6))
            {
                SceneManager.LoadScene(11);
            }*/
            if (Physics.Raycast(r, out hit, 10000, mask7))
            {
                SceneManager.LoadScene(12);
            }
            if (Physics.Raycast(r, out hit, 10000, mask8))
            {
                SceneManager.LoadScene(18);
            }
            if (Physics.Raycast(r, out hit, 10000, mask9))
            {
                SceneManager.LoadScene(14);
            }
        }
        
    }
}
