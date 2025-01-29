using System.Collections.ObjectModel;
using System.Drawing;
using listCharacter;
using Radiance;
using Radiance.Primitives;

public class DivisionState : State
{
    public vec4 cor {get; set;} 

    private static Random random = new Random(); 

    private vec4 GerarCorAleatoria()
    {
        float r = (float)random.NextDouble();  
        float g = (float)random.NextDouble();
        float b = (float)random.NextDouble();
        float a = (float)random.NextDouble();  

        return (r, g, b, a); 
    }
    public override void Act()
    {   
        if (character is null)
            return;
    

        character.Size /= 2;
        var novaBolaSize = character.Size;

        cor = GerarCorAleatoria();
        
        Character nova = new Character(cor, novaBolaSize, character.X, character.Y);
        nova.SetState(new WaitingState());

        CharacterList.Lista.Add(nova);

        character.SetState(new WaitingState());
    }
}