using UnityEngine;
using UnityEngine.UIElements;

public class playerControler : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public Rigidbody rb;
    private Vector3 dir;
    private bool CanJump;
    public float rotateSpeed;


    void Start()
    {
       
        dir =  new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {

       
            
      
        dir.x = Input.GetAxisRaw("Vertical");
        dir.Normalize();


        transform.Translate(dir * Speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxisRaw("Horizontal") * rotateSpeed * Time.deltaTime,0);
      


        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            rb.AddForce(0,JumpForce, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        CanJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        CanJump = false;
    }
}


