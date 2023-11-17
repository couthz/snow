using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetect : MonoBehaviour
{
    [SerializeField] CircleCollider2D headCollider;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) 
    {
        //Determine if the collider of current gameObject that collided is headCollision
        if (other.otherCollider == headCollider) {
            SceneManager.LoadScene(0);
        }
        
    }
}
