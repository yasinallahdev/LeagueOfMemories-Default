using System.Collections.Generic;
using LeagueSandbox.GameServer.Logic.GameObjects;
using LeagueSandbox.GameServer.Logic.API;
using LeagueSandbox.GameServer.Logic.GameObjects.AttackableUnits;
using LeagueSandbox.GameServer.Logic.Scripting;


namespace ImpureShotsActive
{
    internal class ImpureShotsActive : BuffGameScript
    {
        private ChampionStatModifier _AttackSpeedMod;

        public void OnActivate(ObjAIBase buffOwner, Spell ownerSpell)
        {
            _AttackSpeedMod = new ChampionStatModifier();
            _AttackSpeedMod.AttackSpeed.PercentBonus = (new float[] { 0.2f, 0.3f, 0.4f, 0.5f, 0.6f })[ownerSpell.Level - 1];
            buffOwner.AddStatModifier(_AttackSpeedMod);
        }

        public void OnDeactivate(ObjAIBase unit)
        {
            unit.RemoveStatModifier(_AttackSpeedMod);
        }

        public void OnUpdate(double diff)
        {

        }
    }
}
