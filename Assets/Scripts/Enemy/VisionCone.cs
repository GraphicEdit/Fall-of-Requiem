using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisionCone : MonoBehaviour
{

    public GameObject player;

    public Enemy enemyState;

    public int chaseToken = 0;

    public Material VisionConeMaterial;
    public float VisionRange;
    public float VisionAngle;
    public LayerMask VisionObstructingLayer;//layer with objects that obstruct the enemy view, like walls, for example
    public int VisionConeResolution = 120;//the vision cone will be made up of triangles, the higher this value is the pretier the vision cone will be

    public Mesh VisionConeMesh;

    public MeshFilter MeshFilter_;

    public bool isOutOfVision;

    //Create all of these variables, most of them are self explanatory, but for the ones that aren't i've added a comment to clue you in on what they do


    void Start()
    {
        transform.AddComponent<MeshRenderer>().material = VisionConeMaterial;
        MeshFilter_ = transform.AddComponent<MeshFilter>();
        VisionConeMesh = new Mesh();
        VisionAngle *= Mathf.Deg2Rad;

        chaseToken = 0;

        enemyState.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {

        DrawVisionCone();//calling the vision cone function everyframe just so the cone is updated every frame

    }

    protected void DrawVisionCone()//this method creates the vision cone mesh

    {

        int[] triangles = new int[(VisionConeResolution - 1) * 3];

        Vector3[] Vertices = new Vector3[VisionConeResolution + 1];

        Vertices[0] = Vector3.zero;

        float Currentangle = -VisionAngle / 2;

        float angleIcrement = VisionAngle / (VisionConeResolution - 1);

        float Sine;

        float Cosine;

        for (int i = 0; i < VisionConeResolution; i++)
        {

            Sine = Mathf.Sin(Currentangle);

            Cosine = Mathf.Cos(Currentangle);

            Vector3 RaycastDirection = (transform.forward * Cosine) + (transform.right * Sine);

            Vector3 VertForward = (Vector3.forward * Cosine) + (Vector3.right * Sine);

            if (Physics.Raycast(transform.position, RaycastDirection, out RaycastHit hit, VisionRange, VisionObstructingLayer))
            {
                Vertices[i + 1] = VertForward * hit.distance;

            }
            else
            {
                Vertices[i + 1] = VertForward * VisionRange;
            }

            if (hit.collider != null && hit.collider.gameObject.CompareTag("Player"))
            {

                if (chaseToken != 1)
                {

                    enemyState.ChangeState(Enemy.EnemyState.Chasing);
                    enemyState.playerIsDetected = true;

                    Debug.Log("Detected");

                }
                
            }


            Currentangle += angleIcrement;

        }

        for (int i = 0, j = 0; i < triangles.Length; i += 3, j++)
        {
            triangles[i] = 0;

            triangles[i + 1] = j + 1;

            triangles[i + 2] = j + 2;
        }

        VisionConeMesh.Clear();

        VisionConeMesh.vertices = Vertices;

        VisionConeMesh.triangles = triangles;

        MeshFilter_.mesh = VisionConeMesh;

    }
}
