using StarRail_Relics;

var character = new Characters();
Characters.CharacterChoice();
var relicSet = new Relics();
relicSet.HeadRelic();
relicSet.BodyRelic();
relicSet.ArmRelic();
relicSet.BootRelic();
relicSet.PlanarRelic();
relicSet.RopeRelic();
var newstats = relicSet.Calculate(Relics.flatHP, Relics.flatATK, Relics.flatDEF, Relics.flatSPD, Relics.percentHP, Relics.percentATK,Relics.percentDEF,Relics.percentCRTRate,Relics.percentCRTDMG,Relics.percentBreakEffect, Relics.percentOutgoingHealingBoost,Relics.percentEnergyRegenRate, Relics.percentEffectHitRate,Relics.percentEffectRES, Relics.percentPhyDMGBoost,Relics.percentFireDMGBoost,Relics.percentIceDMGBoost,Relics.percentLightningDMGBoost,Relics.percentWindDMGBoost,Relics.percentQuantumDMGBoost,Relics.percentImaginaryDMGBoost);
foreach (float stat in newstats)
{
    Console.WriteLine(stat);
}
Console.ReadLine();