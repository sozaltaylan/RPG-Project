using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class CoreGameSignals
    {
        public static UnityAction<Vector3> onPositionClicked;
    }
}