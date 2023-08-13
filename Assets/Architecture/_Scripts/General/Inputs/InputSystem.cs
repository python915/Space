using UnityEngine;

namespace SpaceTrip.Architecture._Scripts.Player
{
    public abstract class InputSystem : IInputService
    {
        public virtual float GetAxisHorizontal => Input.GetAxis("Horizontal");
    }
}
