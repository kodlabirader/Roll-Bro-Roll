using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour
{
    
    

    void Update()
    {
        coinRotate();
    }

    void coinRotate ()
    {
        transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
    }
    
}
