using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{

    public GameObject FloorTile_1;
    public GameObject FloorTile_2;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        FloorTile_1.transform.position -= new Vector3(GameManager.settings.worldSpeed, 0, 0);
        FloorTile_2.transform.position -= new Vector3(GameManager.settings.worldSpeed, 0, 0);


        if (FloorTile_2.transform.position.x < 0f)
        {
            // Zamiast 32f wpisujecie ca³kowit¹ d³ugoœæ waszych pod³óg
            FloorTile_1.transform.position += new Vector3(32f, 0f, 0f);

            var tmp = FloorTile_1;
            FloorTile_1 = FloorTile_2;
            FloorTile_2 = tmp;
        }

       


    }





}
