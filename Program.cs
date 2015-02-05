using System;
using PrincessFrog.Factory;
using PrincessFrog.FactoryMethod;
using PrincessFrog.Refactored1;
using PrincessFrog.State;

namespace PrincessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseSimple();
            Console.ReadLine();
        }

        #region Pattern example cases

        static void CaseSimple()
        {
            var kisser = new PrincessFrogKisser();
            ExecuteAKisserDemo(kisser);
        }

        static void CaseRefactored1()
        {
            var kisser = new CreatureKisser();
            ExecuteAKisserDemo(kisser);
        }

        static void CaseFactoryMethod()
        {
            var kisser = new CreatureKisserFM();
            ExecuteAKisserDemo(kisser);
        }

        static void CaseAbstractFactory()
        {
            var kisser = new CreatureKisserWithFactory(new CommonFrogFactory());
            ExecuteAKisserDemo(kisser);

            var catLover = new CreatureKisserWithFactory(new PussyFactory());
            ExecuteAKisserDemo(catLover);
        }

        static void CaseStateMachine()
        {
            var kisser = new CreatureKisserSM();
            ExecuteAKisserDemo(kisser);
        }

        #endregion

        #region Helpers

        static void ExecuteAKisserDemo(IKisser kisser)
        {
            kisser.Kiss();
            kisser.Kiss();
            kisser.Kiss();
            ShowCreatureNoise(kisser.GetSomeNoise());
        }

        static void ShowCreatureNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        #endregion
    }
}
