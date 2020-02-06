using Godot;
using System;

public class Idle : State
{
    public override String Handle(Player actor, float delta)
    {
        Vector2 direction = actor.GetDirection();

        if (direction != Vector2.Zero) {

            if (direction.x > -1) {
                GD.Print("Jump");
            }

            return "Run";
        }

        return null;
    }

}
