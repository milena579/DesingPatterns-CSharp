using listCharacter;
using Radiance;

public class MovingState(int x, int y) : State
{
    public override void Act()
    {
        if (character is null)
            return;

        for(int i = 1; i < CharacterList.Lista.Count; i++){

            var pacman =  CharacterList.Lista[0];
            var phantom = CharacterList.Lista[i];

            if(
                pacman.X < phantom.X  + phantom.Size && 
                pacman.X + pacman.Size > phantom.X &&
                pacman.Y < phantom.Y  + phantom.Size && 
                pacman.Y + pacman.Size > phantom.Y &&
                phantom.Size > 10
            )
            {
                CharacterList.Lista[i].SetState(new DivisionState());
            }
        }

        var dx = x - character.X;
        var dy = y - character.Y;
        var mod = MathF.Sqrt(dx * dx + dy * dy);
        dx /= mod;
        dy /= mod;

        if (mod < 5) {
            character.SetState(new WaitingState());
            return;
        }

        character.X += 200 * Window.DeltaTime * dx;
        character.Y += 200 * Window.DeltaTime * dy;
    }
}