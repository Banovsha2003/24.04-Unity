using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] private List<GameObject> oyunObyektleri;
    private void Start()
    {
        oyunObyektleri = GameObject.FindGameObjectsWithTag("changed").ToList();
        gameObject.tag = "changed";
        if (gameObject.tag == "changed")
        {
            gameObject.name = "changed";
        }
    }
    void Update()
    {

    }
}
