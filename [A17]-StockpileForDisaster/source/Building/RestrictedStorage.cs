using System.Collections.Generic;
using RimWorld;
using Verse;

namespace StockpileForDisaster
{
    class RestrictedStorage : Building_Storage
    {
        public override IEnumerable<Gizmo> GetGizmos()
        {
            foreach (var a in base.GetGizmos())
            {
                yield return a;
            }
            EntityListComp comp = this.GetComp<EntityListComp>();
            if(comp == null)
            {
                yield break;
            }
            foreach (var a in CopyPasteRestrictionSetting.CopyPasteRestrictSettingsGizmo(comp.filter))
            {
                yield return a;
            }
        }
    }
}
