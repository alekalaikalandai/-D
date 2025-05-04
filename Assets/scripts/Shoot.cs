using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform SpawnPoint;
    private Rigidbody rb;
    public float shootForce;
  public  void ShootBullet()
    {
   var BulletClone = Instantiate(BulletPrefab, SpawnPoint.position,Quaternion.identity);
        var BulletRigidbody= BulletClone.GetComponent<Rigidbody>();
        BulletRigidbody.AddForce(Vector3.forward * shootForce);
    }

  
   private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ShootBullet();

        }
    }
}
