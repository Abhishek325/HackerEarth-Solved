using System;
using System.Numerics;
using System.Linq;
class War
{
    War()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            BigInteger[] BobArmyStrenghts = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            BigInteger[] AliceArmyStrenghts = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger BobArmyMaxPower = BobArmyStrenghts[0];
            BigInteger AliceArmyMaxPower = AliceArmyStrenghts[0];

            for (int i = 1; i < n; i++)
            {
                if (BobArmyStrenghts[i] > BobArmyMaxPower)
                    BobArmyMaxPower = BobArmyStrenghts[i];

                if (AliceArmyStrenghts[i] > AliceArmyMaxPower)
                    AliceArmyMaxPower = AliceArmyStrenghts[i];
            }
            Console.WriteLine(BobArmyMaxPower > AliceArmyMaxPower ? "Bob" : BobArmyMaxPower < AliceArmyMaxPower ? "Alice" : "Tie");
        }
    }
}
