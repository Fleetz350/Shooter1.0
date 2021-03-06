using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetUp : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentToDisable;

    void Start()
    {
        if (!isLocalPlayer)
            for (int i = 0; i < componentToDisable.Length; i++)
                componentToDisable[i].enabled = false;
    }

}
