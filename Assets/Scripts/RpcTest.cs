using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Messaging;

public class RpcTest : NetworkBehaviour
{
    private bool firstTime = true;

    [ClientRpc]
    void TestClientRpc(int value) 
    {
        if (IsClient)
        {
            Debug.Log("Client received RPC #" + value);
            TestServerRpc(value + 1);
        }
    }

    [ServerRpc]
    void TestServerRpc(int value)
    {
        if (IsServer)
        {
            Debug.Log("Server received RPC #" + value);
            TestClientRpc(value);
        }
    }

    void Update()
    {
        if (IsClient && firstTime)
        {
            firstTime = false;
            TestServerRpc(0);
        }
    }
}
