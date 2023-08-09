using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class CameraSignals
    {
        public static UnityAction<CameraAnimationState,bool> cameraState;
    }
}