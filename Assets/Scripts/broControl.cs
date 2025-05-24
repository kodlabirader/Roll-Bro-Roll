using UnityEngine;
using UnityEngine.SceneManagement;

public class broControl : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float speed = 5;
    public GameObject scoring;
    
    
    void Start()
    {
        scoring = GameObject.FindGameObjectWithTag("Manager");
    }

    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(Horizontal, 0, Vertical);
        rb.AddForce(move * speed, ForceMode.VelocityChange);
    }

    private void Update()
    {
        ballCheck();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="CoinTag")
        {
            Destroy(other.gameObject);
            Debug.Log("Nesne toplandý!");
            scoring.GetComponent<gameManager>().totalScore();
            
        }
    }
    void ballCheck ()
    {
        if(gameObject.transform.position.y<-1f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Top düþtü!");
        }
    }
}
