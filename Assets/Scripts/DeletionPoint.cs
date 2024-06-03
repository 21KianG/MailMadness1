using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DeletionPoint : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Package1"))
        {
            Destroy(collision.gameObject);
            ScoreController.instance.RemovePoint();
        }
        if (collision.gameObject.CompareTag("Package2"))
        {
            Destroy(collision.gameObject);
            ScoreController.instance.RemovePoint();
        }
        if (collision.gameObject.CompareTag("Package3"))
        {
            Destroy(collision.gameObject);
            ScoreController.instance.RemovePoint();
        }
    }
}
