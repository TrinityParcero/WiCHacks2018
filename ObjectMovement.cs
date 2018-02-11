using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour {

    public Vector3[] positions;
    public int counter;
    public SceneManager sceneManager;

    // Use this for initialization
    void Start () {
        positions = new Vector3[30];
        positions[0] = new Vector3(-7, -3, 0);
        positions[1] = new Vector3(0, -3, 0);
        positions[2] = new Vector3(7, -3, 0);
        positions[3] = new Vector3(-4.5f, -2, 0);
        positions[4] = new Vector3(0, -2, 0);
        positions[5] = new Vector3(4.5F, -2, 0);
        positions[6] = new Vector3(-2.7f, -1.3f, 0);
        positions[7] = new Vector3(0, -1.3f, 0);
        positions[8] = new Vector3(2.7f, -1.3f, 0);
        positions[9] = new Vector3(-1.6f, -0.95f, 0);
        positions[10] = new Vector3(0, -0.95f, 0);
        positions[11] = new Vector3(1.6f, -0.95f, 0);
        positions[12] = new Vector3(-0.9f, -0.9f, 0);
        positions[13] = new Vector3(0, -0.9f, 0);
        positions[14] = new Vector3(0.9f, -0.9f, 0);
        positions[15] = new Vector3(-5, 0, 0);
        positions[16] = new Vector3(0, 0, 0);
        positions[17] = new Vector3(5, 0, 0);
        positions[18] = new Vector3(-5, 3, 0);
        positions[19] = new Vector3(0, 3, 0);
        positions[20] = new Vector3(5, 3, 0);
        positions[21] = new Vector3(-5, 6, 0);
        positions[22] = new Vector3(0, 6, 0);
        positions[23] = new Vector3(5, 6, 0);

        counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (counter == 120)
        {
            //move all obstacles/ update prefabs
            //12->9   13->10  14->11  row12-row9 prefab
            //9->6    10->7   11->8   row9-row6 prefab
            //6->3    7->4    8->5    row6-row3 prefab
            //3->0    4->1    5->2    delete
            for (int i = 0; i < sceneManager.enemiesOnScreen.Length; i++)
            {

            }

            counter = 0;
        }
        else
        {
            counter += 1;
        }
	}
}
