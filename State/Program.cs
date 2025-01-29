using System.Runtime.Intrinsics.Arm;
using Radiance;
using Radiance.Primitives;
using static Radiance.Utils;
using listCharacter;

vec4 color1 = yellow;
vec4 color2 = blue;


Character pacman = new Character(yellow,  100,  900, 500);
Character phantom = new Character(blue, 60, 900, 700);
Character phantom2 = new Character(green, 60, 900, 700);
Character phantom3 = new Character(red, 60, 900, 700);
Character phantom4 = new Character(white, 60, 900, 700);

CharacterList.Lista.Add(pacman);
CharacterList.Lista.Add(phantom);
CharacterList.Lista.Add(phantom2);
CharacterList.Lista.Add(phantom3);
CharacterList.Lista.Add(phantom4);

pacman.SetState(new WaitingState());
phantom.SetState(new WaitingState());
phantom2.SetState(new WaitingState());
phantom3.SetState(new WaitingState());
phantom4.SetState(new WaitingState());


Window.OnFrame += () => {

    for (int i = 0; i < CharacterList.Lista.Count; i++) {
        var item = CharacterList.Lista[i];
        item.Act();
    }
};

Window.OnRender += () => {
    foreach(var item in CharacterList.Lista){
        item.Draw();
    }
};



Window.CloseOn(Input.Escape);
Window.Open();