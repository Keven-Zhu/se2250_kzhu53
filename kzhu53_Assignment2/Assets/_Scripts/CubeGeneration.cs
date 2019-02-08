using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGeneration : MonoBehaviour
{
    public GameObject Cube;
    public int numCubes = 0;

    void Start()
    {
        Vector3 centre = new Vector3(0.0f, 1.0f, 0.0f);

        Color c1 = Color.yellow;
        Color c2 = Color.cyan;
        Color c3 = Color.grey;    

        for (int i = 0; i < numCubes; i++)
        {
            /*
            Vector3 pos = RandomCircle(centre, 5.0f);
            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, centre - pos);
            Instantiate(Cube, pos, rot);
            */
            GameObject obj = Instantiate<GameObject>(Cube);
            obj.name = "Cube " + i;

            if (i % 3 == 0)
            {
                obj.GetComponent<Renderer>().material.color = c2;
            }
            else if (i % 2 == 0)
            {
                obj.GetComponent<Renderer>().material.color = c3;
            }
            else
            {
                obj.GetComponent<Renderer>().material.color = c1;
            }

            int a = (360 / numCubes) * i;
            Vector3 pos = RandomCircle(centre, 4.0f, a);
            obj.transform.position = pos;
            //Instantiate(Cube, pos, Quaternion.identity);

            /*
            if (i % 3 == 0)
            {
                Cube.GetComponent<Renderer>().material.color = colors[1];
            }
            else if (i % 2 == 0)
            {
                Cube.GetComponent<Renderer>().material.color = colors[2];
            }
            else
            {
                Cube.GetComponent<Renderer>().material.color = colors[0];
            }
            */
        }
        /*
        gameObjectList = new List<GameObject>();

        for (numCubes = 1; numCubes < 9; numCubes++)
        {
            Instantiate(Cube);
        }
        */
    }

    Vector3 RandomCircle(Vector3 centre, float radius, int a)
    {
        float ang = a;
        Vector3 pos;
        pos.x = centre.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = centre.y;
        pos.z = centre.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        
        return pos;
    }

    /*
    Vector3 RandomCircle (Vector3 centre, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = centre.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = centre.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = centre.z;

        return pos;
    }
    */

    // Update is called once per frame
    void Update()
    {

    }
}
