/*Piper Abbott-Phillips
 * Target.cs
 * Prototype 5/ Assigment 6
 * This is an edited version of the original ShootWithRaycasts script that allows for the IDamageable interface to be implemented
 */
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            
            IDamageable damageableObject = hitInfo.transform.GetComponent<IDamageable>();

           
            if (damageableObject != null)
            {
                damageableObject.TakeDamage((int)damage);

                if (hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                }
            }
        }
    }
}
