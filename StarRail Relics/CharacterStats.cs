using System.Runtime.InteropServices;

namespace StarRail_Relics;

public class CharacterStats
{
    public CharacterStats(float HP, float ATK, float DEF, float SPD, float CRTRate, float CRTDMG, float BreakEffect, float OutgoingHealingBoost, float MaxEnergy, float EnergyRegenRate, 
        float EffectHitRate, float EffectRES, float PhyDMGBoost, float FireDMGBoost, float IceDMGBoost, float LightningDMGBoost, float WindDMGBoost, float QuantumDMGBoost, 
        float ImaginaryDMGBoost){
        this.HP = HP;
        this.ATK = ATK;
        this.DEF = DEF;
        this.SPD = SPD;
        this.CRTRate = CRTRate;
        this.CRTDMG = CRTDMG;
        this.BreakEffect = BreakEffect;
        this.OutgoingHealingBoost = OutgoingHealingBoost;
        this.MaxEnergy = MaxEnergy;
        this.EnergyRegenRate = EnergyRegenRate;
        this.EffectHitRate = EffectHitRate;
        this.EffectRES = EffectRES;
        this.PhyDMGBoost = PhyDMGBoost;
        this.FireDMGBoost = FireDMGBoost;
        this.IceDMGBoost = IceDMGBoost;
        this.LightningDMGBoost = LightningDMGBoost;
        this.WindDMGBoost = WindDMGBoost;
        this.QuantumDMGBoost = QuantumDMGBoost;
        this.ImaginaryDMGBoost = ImaginaryDMGBoost;
    }
    public readonly float HP;
    public readonly float ATK;
    public readonly float DEF;
    public readonly float SPD;
    public readonly float CRTRate;
    public readonly float CRTDMG;
    public readonly float BreakEffect;
    public readonly float OutgoingHealingBoost;
    public readonly float MaxEnergy;
    public readonly float EnergyRegenRate;
    public readonly float EffectHitRate;
    public readonly float EffectRES;
    public readonly float PhyDMGBoost;
    public readonly float FireDMGBoost;
    public readonly float IceDMGBoost;
    public readonly float LightningDMGBoost;
    public readonly float WindDMGBoost;
    public readonly float QuantumDMGBoost;
    public readonly float ImaginaryDMGBoost;
    /*public readonly float PhyRESBoost = 0;
    public readonly float FireRESBoost = 0;
    public readonly float IceRESBoost = 0;
    public readonly float LightningRESBoost = 0;
    public readonly float WindRESBoost = 0;
    public readonly float QuantumRESBoost = 0;
    public readonly float ImaginaryRESBoost = 0;*/
}

public class Characters
{
    public static CharacterStats Acheron = new CharacterStats(1135, 698, 436, 101, 5, 74, 0, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
    public static CharacterStats Asta = new CharacterStats(1023,511,463,106,11.7f,50,0,0,120,100,0,0,0,0,0,0,0,0,0);
    public static CharacterStats Aventurine = new CharacterStats(1203, 446, 654, 106, 5, 50, 0, 0, 110, 100, 0, 10, 0, 0, 0, 0, 0, 0,0);
    public static CharacterStats Bailu = new CharacterStats(1319, 562, 485, 98, 5, 50, 0, 0, 100, 100, 0, 10, 0, 0, 0, 0, 0, 0, 0);
    public static CharacterStats Sushang = new CharacterStats(917, 564, 418,107, 5,50,0,0,120,100,0,0,0,0,0,0,0,0,0);

    public static CharacterStats CharacterChoice()
    {
        Console.WriteLine("Please enter the character you would like to create relics for: ");
        string chosenChar = Console.ReadLine().ToLower();
        if (chosenChar == "acheron")
        {
            return Acheron;
        }
        else
        {
            return Asta;
        }
    }
    
}

public class Relics
{
    public static float flatHP;
    public static float flatATK;
    public static float flatDEF;
    public static float flatSPD; 
    public static float percentHP;
    public static float percentATK;
    public static float percentDEF;
    public static float percentCRTRate;
    public static float percentCRTDMG;
    public static float percentBreakEffect;
    public static float percentOutgoingHealingBoost;
    public static float percentEnergyRegenRate;
    public static float percentEffectHitRate;
    public static float percentEffectRES;
    public static float percentPhyDMGBoost;
    public static float percentFireDMGBoost;
    public static float percentIceDMGBoost;
    public static float percentLightningDMGBoost;
    public static float percentWindDMGBoost;
    public static float percentQuantumDMGBoost;
    public static float percentImaginaryDMGBoost;

    private static string forbiddenBodyMainStatChoice;
    private static string forbiddenBootsMainStatChoice;
    private static string forbiddenPlanarMainStatChoice;
    private static string forbiddenRopeMainStatChoice;
    //Add choices and levelling into relic choices and add check so same main stat and substat on choosable pieces aren't the same
    public void HeadRelic()
    {
        flatHP = flatHP + 705;
        Console.WriteLine("Choosing stats for head piece...");
        subStatChoiceInterface("nostat");
    }
    public void BodyRelic()
    {
        chooseBodyMainStat();
        subStatChoiceInterface(forbiddenBodyMainStatChoice);
    }
    public void ArmRelic()
    {
        Console.WriteLine("Choosing stats for Arm piece...");
        flatATK = flatATK + 352;
        subStatChoiceInterface("nostat");
    }
    public void BootRelic()
    {
        chooseBootsMainStat();
        subStatChoiceInterface(forbiddenBootsMainStatChoice);
    }
    public void PlanarRelic()
    {
        choosePlanarMainStat();
        subStatChoiceInterface(forbiddenPlanarMainStatChoice);
    }
    public void RopeRelic()
    {
        chooseRopeMainStat();
        subStatChoiceInterface(forbiddenRopeMainStatChoice);
    }
    public float[] Calculate(float flatHP, float flatATK, float flatDEF, float flatSPD, float percentHP, float percentATK, float percentDEF, float percentCRTRate, float percentCRTDMG,
                             float percentBreakEffect, float percentOutgoingHealingBoost, float percentEnergyRegenRate, float percentEffectHitRate, float percentEffectRES,
                             float percentPHYDMGBoost, float percentFireDMGBoost, float percentIceDMGBoost, float percentLightningDMGBoost, float percentWindDMGBoost, float percentQuantumDMGBoost, float percentImaginaryDMGBoost/*, Characters characterUpgrade*/)
    {
        float[] finalStats = new float[18];
        finalStats[0] = ((Characters.Acheron.HP/ 100) * percentHP) + flatHP + Characters.Acheron.HP;
        finalStats[1] = ((Characters.Acheron.ATK/ 100) * percentATK) + flatATK + Characters.Acheron.ATK;
        finalStats[2] = ((Characters.Acheron.DEF/ 100) * percentDEF) + flatDEF + Characters.Acheron.DEF;
        finalStats[3] =  Characters.Acheron.SPD + flatSPD;
        finalStats[4] =  Characters.Acheron.CRTRate + percentCRTRate;
        finalStats[5] =  Characters.Acheron.CRTDMG + percentCRTDMG;
        finalStats[6] =  Characters.Acheron.BreakEffect + percentBreakEffect;
        finalStats[7] =  Characters.Acheron.OutgoingHealingBoost + percentOutgoingHealingBoost;
        finalStats[8] =  Characters.Acheron.EnergyRegenRate + percentEnergyRegenRate;
        finalStats[9] =  Characters.Acheron.EffectHitRate + percentEffectHitRate;
        finalStats[10] = Characters.Acheron.EffectRES + percentEffectRES;
        finalStats[11] = percentPHYDMGBoost;
        finalStats[12] = percentFireDMGBoost;
        finalStats[13] = percentIceDMGBoost;
        finalStats[14] = percentLightningDMGBoost;
        finalStats[15] = percentWindDMGBoost;
        finalStats[16] = percentQuantumDMGBoost;
        finalStats[17] = percentImaginaryDMGBoost;
        return finalStats;
    }

    public void chooseBodyMainStat()
    {
        Console.WriteLine("Choose Body Piece Main stat (percentHP, percentATK, percentDEF, percentCRTRate, percentCRTDMG, percentOutgoingHealingBoost, percentEffectHitRate): ");
        string BodyStatChoice = Console.ReadLine().ToLower();
        if (BodyStatChoice == "percenthp")
        {
            percentHP += 43.2f;
        }
        else if (BodyStatChoice== "percentatk")
        {
            percentATK += 43.2f;
        }
        else if (BodyStatChoice == "percentdef")
        {
            percentDEF += 54f;
        }
        else if (BodyStatChoice == "percentcrtrate")
        {
            percentCRTRate += 32.4f;
        }
        else if (BodyStatChoice == "percentcrtdmg")
        {
            percentCRTDMG += 64.8f;
        }
        else if (BodyStatChoice == "percentoutgoinghealingboost")
        {
            percentOutgoingHealingBoost += 34.5f;
        }
        else if (BodyStatChoice == "percenteffecthitrate")
        {
            percentEffectHitRate += 43.2f;
        }
        else
        {
            Console.WriteLine("Not a valid stat. Please input one of the stats shown in the brackets.");
            this.chooseBodyMainStat();
        }

        forbiddenBodyMainStatChoice = BodyStatChoice;
    }
    public void chooseBootsMainStat()
    {
        Console.WriteLine("Choose Boots main stat (percentHP, percentATK, percentDEF, flatSPD): ");
        string BootStatChoice = Console.ReadLine().ToLower();
        if (BootStatChoice == "percenthp")
        {
            percentHP += 43.2f;
        }
        else if (BootStatChoice== "percentatk")
        {
            percentATK += 43.2f;
        }
        else if (BootStatChoice == "percentdef")
        {
            percentDEF += 54f;
        }
        else if (BootStatChoice == "flatspd")
        {
            flatSPD += 25f;
        }
        else
        {
            Console.WriteLine("Not a valid stat. Please input one of the stats shown in the brackets.");
            this.chooseBootsMainStat();
        }
        forbiddenBootsMainStatChoice = BootStatChoice;
    }
    public void choosePlanarMainStat()
    {
        Console.WriteLine("Choose planar orb main stat (percentHP, percentATK, percentDEF, percentPHYDMGBoost, percentFireDMGBoost, percentIceDMGBoost, percentLightningDMGBoost, percentWindDMGBoost, percentQuantumDMGBooost, percentImaginaryDMGBoost): ");
        string PlanarStatChoice = Console.ReadLine().ToLower();
        if (PlanarStatChoice == "percenthp")
        {
            percentHP += 43.2f;
        }
        else if (PlanarStatChoice== "percentatk")
        {
            percentATK += 43.2f;
        }
        else if (PlanarStatChoice == "percentdef")
        {
            percentDEF += 54f;
        }
        else if (PlanarStatChoice == "percentphydmgboost")
        {
            percentPhyDMGBoost += 38.8f;
        }
        else if (PlanarStatChoice == "percentfiredmgboost")
        {
            percentFireDMGBoost += 38.8f;
        }
        else if (PlanarStatChoice == "percenticedmgboost")
        {
            percentIceDMGBoost += 38.8f;
        }
        else if (PlanarStatChoice == "percentlightningdmgboost")
        {
            percentLightningDMGBoost += 38.8f;
        }
        else if (PlanarStatChoice == "percentwinddmgboost")
        {
            percentWindDMGBoost += 38.8f;
        }
        else if (PlanarStatChoice == "percentquantumdmgboost")
        {
            percentQuantumDMGBoost += 38.8f;
        }
        else if (PlanarStatChoice == "percentimaginarydmgboost")
        {
            percentImaginaryDMGBoost += 38.8f;
        }
        else
        {
            Console.WriteLine("Not a valid stat. Please input one of the stats shown in the brackets.");
            this.choosePlanarMainStat();
        }
        forbiddenPlanarMainStatChoice = PlanarStatChoice;
    }
    public void chooseRopeMainStat()
    {
        Console.WriteLine("Choose link rope main stat (percentHP, percentATK, percentDEF, percentBreakEffect, percentEnergyRegenRate): ");
        string RopeStatChoice = Console.ReadLine().ToLower();
        if (RopeStatChoice == "percenthp")
        {
            percentHP += 43.2f;
        }
        else if (RopeStatChoice== "percentatk")
        {
            percentATK += 43.2f;
        }
        else if (RopeStatChoice == "percentdef")
        {
            percentDEF += 54f;
        }
        else if (RopeStatChoice == "percentbreakeffect")
        {
            percentBreakEffect += 64.8f;
        }
        else if (RopeStatChoice == "percentenergyregenrate")
        {
            percentBreakEffect += 19.4f;
        }
        else
        {
            Console.WriteLine("Not a valid stat. Please input one of the stats shown in the brackets.");
            this.chooseRopeMainStat();
        }
        forbiddenRopeMainStatChoice = RopeStatChoice;
    }
    public void chooseSubStat(string subStatChoice)
    {
        // Console.WriteLine("Please choose a substat that you would like to add to your piece (flatHP, flatATK, flatDEF, flatSPD, percentHP, percentATK, percentDEF, percentCRTRate, percentCRTDMG, percentBreakEffect, percentEffectHitRate, percentEffectRES):");
        // string subStatChoice = Console.ReadLine().ToLower();
        if (subStatChoice == "flathp")
        {
            flatHP += 33.87f;
        }
        else if (subStatChoice == "flatatk")
        {
            flatATK += 16.935f;
        }
        else if (subStatChoice == "flatdef")
        {
            flatDEF += 16.935f;
        }
        else if (subStatChoice == "flatspd")
        {
            flatSPD += 2f;
        }
        else if (subStatChoice == "percenthp")
        {
            percentHP += 3.456f;
        }
        else if (subStatChoice == "percentatk")
        {
            percentATK += 3.456f;
        }
        else if (subStatChoice == "percentdef")
        {
            percentDEF += 4.32f;
        }
        else if (subStatChoice == "percentcrtrate")
        {
            percentCRTRate += 2.592f;
        }
        else if (subStatChoice == "percentcrtdmg")
        {
            percentCRTDMG += 5.184f;
        }
        else if (subStatChoice == "percentbreakeffect")
        {
            percentBreakEffect += 5.184f;
        }
        else if (subStatChoice == "percenteffecthitrate")
        {
            percentEffectHitRate += 3.456f;
        }
        else if (subStatChoice == "percenteffectres")
        {
            percentEffectRES += 3.456f;
        }
    }

    public void subStatChoiceInterface(string mainStatChoice)
    {
        string firstSubStatChoice = "";
        string secondSubStatChoice = "";
        string thirdSubStatChoice = "";
        string fourthSubStatChoice = "";
        for (int subStatOptions = 0; subStatOptions < 4; subStatOptions++)
        {
            Console.WriteLine("Please choose a substat that you would like to add to your piece (flatHP, flatATK, flatDEF, flatSPD, percentHP, percentATK, percentDEF, percentCRTRate, percentCRTDMG, percentBreakEffect, percentEffectHitRate, percentEffectRES):");
            string subStatPotentialChoice = Console.ReadLine().ToLower();
            if (subStatPotentialChoice != "flathp" && subStatPotentialChoice != "flatatk" && subStatPotentialChoice != "flatdef" && subStatPotentialChoice != "flatspd" 
                && subStatPotentialChoice != "percenthp" && subStatPotentialChoice != "percentatk" && subStatPotentialChoice != "percentdef" && subStatPotentialChoice != "percentcrtrate" 
                && subStatPotentialChoice != "percentcrtdmg" && subStatPotentialChoice != "percentbreakeffect" && subStatPotentialChoice != "percenteffecthitrate" && subStatPotentialChoice != "percenteffectres")
            {
                Console.WriteLine("Please enter a valid stat. ");
                subStatOptions--;
            }
            else if(subStatPotentialChoice == firstSubStatChoice || subStatPotentialChoice == secondSubStatChoice || subStatPotentialChoice == thirdSubStatChoice || subStatPotentialChoice == fourthSubStatChoice)
            {
                Console.WriteLine("Please choose a different stat, you have already chosen this one.");
                subStatOptions--;
            }
            else if (subStatPotentialChoice == mainStatChoice)
            {
                Console.WriteLine("You can't choose a substat the same as your pieces' main stat. ");
                subStatOptions--;
            }
            else
            {
                if (firstSubStatChoice == "")
                {
                    firstSubStatChoice = subStatPotentialChoice;
                    chooseSubStat(firstSubStatChoice);
                }
                else if(secondSubStatChoice == "")
                {
                    secondSubStatChoice = subStatPotentialChoice;
                    chooseSubStat(secondSubStatChoice);
                }
                else if (thirdSubStatChoice == "")
                {
                    thirdSubStatChoice = subStatPotentialChoice;
                    chooseSubStat(thirdSubStatChoice);
                }
                else
                {
                    fourthSubStatChoice = subStatPotentialChoice;
                    chooseSubStat(fourthSubStatChoice);
                }
            }
        }
        for (int subStatLevelling = 0; subStatLevelling < 5; subStatLevelling++)
        {
            Console.WriteLine("Please Choose which of these stats you would like to level (" + firstSubStatChoice  + ", " + secondSubStatChoice + ", " + thirdSubStatChoice + ", " + fourthSubStatChoice + "): ");
            string subStatPotentialLevelling = Console.ReadLine().ToLower();
            if (subStatPotentialLevelling != firstSubStatChoice && subStatPotentialLevelling != secondSubStatChoice && subStatPotentialLevelling != thirdSubStatChoice && subStatPotentialLevelling != fourthSubStatChoice)
            {
                Console.WriteLine("Please choose on of the stats you have chosen for you piece.");
                subStatLevelling--;
            }
            else
            {
                chooseSubStat(subStatPotentialLevelling);
            }
        }
    }
}
