using System; 

namespace Master.Mission
{
  public  class Identification
    {
        //ctor
        public Identification()
        {
            int jitem=0;
            jitem++;

            #region Exemples
            foreach (var item in new int[] { 1 })
            {

            }
            while (true)
            {

            }
            for (int j = 0; j < 10; j++)
            {

            } 
            #endregion
        }

        public void Controle(string id, string mdp)
        {
            bool test = EstIdentifie(mdp: "", id: "");
            bool test2 = EstIdentifie( "");
        }
        private bool EstIdentifie(string id,string mdp="**")
        {
            return false;
        }


    }
}
