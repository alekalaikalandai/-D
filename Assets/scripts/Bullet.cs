using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
  private  void Start()
    {
        Destroy(gameObject);
    }

   
   private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    private IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
