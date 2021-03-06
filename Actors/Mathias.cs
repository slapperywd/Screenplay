﻿using CSF.FlexDi;
using CSF.Screenplay;
using CSF.Screenplay.Actors;
using Screenplay.Abilities;

namespace Screenplay.Actors
{
    public class Mathias : Persona
    {
        public override string Name => "Mathias";

        public override void GrantAbilities(ICanReceiveAbilities actor, IResolvesServices resolver)
        {
            actor.IsAbleTo<AddNumbers>();
        }
    }
}
