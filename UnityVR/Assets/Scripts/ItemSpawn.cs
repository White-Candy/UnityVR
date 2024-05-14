using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class ItemSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Test()
    {
        GetComponent<VRTK_ControllerEvents>().TouchpadPressed += ItemSpawn_TouchpadPressed;
        GetComponent<VRTK_ControllerEvents>().TouchpadReleased += ItemSpawn_TouchpadReleased;
    }

    private void ItemSpawn_TouchpadPressed(object sender, ControllerInteractionEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void ItemSpawn_TouchpadReleased(object sender, ControllerInteractionEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}
