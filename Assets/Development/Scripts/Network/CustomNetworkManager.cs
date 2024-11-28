using Mirror;
using UnityEngine;

namespace Booooof
{
    public class CustomNetworkManager : NetworkManager
    {
        public override void OnClientConnect()
        {
            base.OnClientConnect();

            Debug.Log("OnClientConnect");
        }

        public override void OnServerAddPlayer(NetworkConnectionToClient conn)
        {
            base.OnServerAddPlayer(conn);

            Debug.Log($"Added {numPlayers} player");
        }
    }
}
