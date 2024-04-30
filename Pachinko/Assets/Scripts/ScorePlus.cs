using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScorePlus : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pumpkin")
        {
            if (gameObject.tag == "+1")
            {
                GameManager.Instance.AddScore(1);
            }
            else if(gameObject.tag == "+2")
            {
                GameManager.Instance.AddScore(2);
            }
            else if (gameObject.tag == "+3")
            {
                GameManager.Instance.AddScore(3);
            }
            else if (gameObject.tag == "+4")
            {
                GameManager.Instance.AddScore(4);
            }

            Destroy(collision.gameObject);
        }
    }

}
