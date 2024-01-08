using System;
using Unity.VisualScripting;

namespace Example2
{
    public interface IInput
    {
        event Action<MovementDirection> InputEvent;
    }
}