using UnityEngine;
using UnityEngine.InputSystem;

public class circle : MonoBehaviour
{

    //variables

    //to make a singleton
    public static circle instance;

    public Rigidbody2D rb;

    public float movespeed;

    private Vector2 _direction;

    public InputActionReference move;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        _direction = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x: _direction.x * movespeed, y: _direction.y * movespeed);
    }

}
