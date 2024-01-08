using System;
using Unity.VisualScripting;

namespace Example1
{
    public interface IInput
    {
        event Action<MovementDirection> InputEvent;
    }
}